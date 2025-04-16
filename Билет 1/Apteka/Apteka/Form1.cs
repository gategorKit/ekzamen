using Apteka.Class;
using Apteka.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apteka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            List<Model.Pathologic> pathologics = Helper.DB.Pathologic.ToList();
            pathologics.Insert(0, new Model.Pathologic { Id = 0, Name = "Все категории" });
            comboBoxCat.DataSource = pathologics;
            comboBoxCat.DisplayMember = "Name";
            comboBoxCat.ValueMember = "Id";
            comboBoxCat.SelectedIndexChanged += ComboBoxCat_SelectedIndexChanged;
            textBoxSearch.TextChanged += TextBoxSearch_TextChanged;

            LoadMedicData();
        }

        private void ComboBoxCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMedicData();
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            LoadMedicData();
        }

        private void LoadMedicData()
        {
            int selectedPathologyId = 0;

            if (comboBoxCat.SelectedValue != null && int.TryParse(comboBoxCat.SelectedValue.ToString(), out int value))
            {
                selectedPathologyId = value;
            }

            List<Model.Med> meds;

            string searchText = textBoxSearch.Text.ToLower(); 

            if (selectedPathologyId > 0)
            {
                meds = Helper.DB.Med
                    .Where(m => m.Pathologic == selectedPathologyId && m.Name.ToLower().Contains(searchText))
                    .ToList();
            }
            else
            {
                meds = Helper.DB.Med
                    .Where(m => m.Name.ToLower().Contains(searchText))
                    .ToList(); 
            }

            var displayData = new List<dynamic>();

            foreach (Model.Med med in meds)
            {
                List<Model.Pathologic> pathologics = Helper.DB.Pathologic
                    .Where(p => p.Id == med.Pathologic)
                    .ToList();

                double costWithDiscount = med.Cost * (1 - med.Skidka);
                
                displayData.Add(new
                {
                    Id = med.Id,
                    Name = med.Name,
                    Description = med.Descript,
                    Pathologic = pathologics.FirstOrDefault()?.Name,
                    Partner = med.Partner,
                    Diagnosis = med.Diognas,
                    Form = med.Form,
                    Cost = costWithDiscount.ToString("F2"),
                    Discount = (med.Skidka * 100).ToString("F2") + "%",
                    
                    ImagePath = Path.Combine("..", "..", "Resoursec", $"{med.Name}.jpg")
            });
            }

            var sortedData = displayData.OrderBy(m => m.Cost).ToList();

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("Id", "Id");
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Description", "Description");
            dataGridView1.Columns.Add("Pathologic", "Pathologic");
            dataGridView1.Columns.Add("Partner", "Partner");
            dataGridView1.Columns.Add("Diagnosis", "Diagnosis");
            dataGridView1.Columns.Add("Form", "Form");
            dataGridView1.Columns.Add("Cost", "Cost");
            dataGridView1.Columns.Add("Discount", "Discount");

            var imgColumn = new DataGridViewImageColumn();
            imgColumn.HeaderText = "Image";
            imgColumn.Name = "Image";
            dataGridView1.Columns.Add(imgColumn);

            foreach (var item in sortedData)
            {
                int rowIndex = dataGridView1.Rows.Add(
                    item.Id,
                    item.Name,
                    item.Description,
                    item.Pathologic,
                    item.Partner,
                    item.Diagnosis,
                    item.Form,
                    item.Cost,
                    item.Discount
                );

                try
                {
                    Bitmap img = new Bitmap(item.ImagePath);
                    dataGridView1.Rows[rowIndex].Cells["Image"].Value = img;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка загрузки изображения {item.ImagePath}: {ex.Message}");
                    dataGridView1.Rows[rowIndex].Cells["Image"].Value = null;
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }

}
