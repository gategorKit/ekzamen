using Games.Class;
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

namespace Games
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetUpRadioButtonEvents();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            List<Model.Category> categories = Helper.DB.Category.ToList();

            categories.Insert(0, new Model.Category { Id = 0, Name = "Все жанры" });

            comboBoxCat.DataSource = categories;

            comboBoxCat.DisplayMember = "Name";

            comboBoxCat.ValueMember = "Id";
            comboBoxCat.SelectedIndexChanged += ComboBoxCat_SelectedIndexChanged;

            textBoxSearch.TextChanged += TextBoxSearch_TextChanged;

            LoadGameData();
        }

        private void SetUpRadioButtonEvents()
        {
            radioButtonSortAsc.CheckedChanged += RadioButtonSort_CheckedChanged;
            radioButtonSortDesc.CheckedChanged += RadioButtonSort_CheckedChanged;
        }

        private void ComboBoxCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadGameData();
        }
        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            LoadGameData();
        }

        private void RadioButtonSort_CheckedChanged(object sender, EventArgs e)
        {
            LoadGameData();
        }


        private void LoadGameData()
        {
            int selectedCategoryId = 0;

            if (comboBoxCat.SelectedValue != null && int.TryParse(comboBoxCat.SelectedValue.ToString(), out int value))
            {
                selectedCategoryId = value;
            }

            string searchText = textBoxSearch.Text.ToLower();

            List<Model.Games> games = Helper.DB.Games
                .Where(g => (selectedCategoryId == 0 || g.CategoryId == selectedCategoryId) && g.Name.ToLower().Contains(searchText))
                .ToList();

            if (radioButtonSortAsc.Checked)
            {
                games = games.OrderBy(g => g.Cost == "FREE" ? 0 : Convert.ToDouble(g.Cost)).ToList();
            }
            else if (radioButtonSortDesc.Checked)
            {
                games = games.OrderByDescending(g => g.Cost == "FREE" ? 0 : Convert.ToDouble(g.Cost)).ToList();
            }

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("Id", "Id");
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Description", "Description");
            dataGridView1.Columns.Add("Creator", "Creator");
            dataGridView1.Columns.Add("Cost", "Cost");

            dataGridView1.Columns.Add("CategoryName", "Категория");

            var imgColumn = new DataGridViewImageColumn();
            imgColumn.HeaderText = "Image";
            imgColumn.Name = "Image";
            dataGridView1.Columns.Add(imgColumn);

            foreach (var game in games)
            {
                var category = Helper.DB.Category.FirstOrDefault(c => c.Id == game.CategoryId);

                int rowIndex = dataGridView1.Rows.Add(
                    game.Id,
                    game.Name,
                    game.Description,
                    game.Creator,
                    game.Cost,
                    category?.Name 
                );

                try
                {
                    string imagePath = Path.Combine("..", "..", "Resources", $"{game.Name}.jpg"); ;
                    Bitmap img = new Bitmap(imagePath);
                    dataGridView1.Rows[rowIndex].Cells["Image"].Value = img;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка загрузки изображения {game.Name}: {ex.Message}");
                    dataGridView1.Rows[rowIndex].Cells["Image"].Value = null; 
                }
            }
        }
        private void buttonAddGame_Click(object sender, EventArgs e)
        {
            using (var addGameForm = new FormAddGame())
            {
                if (addGameForm.ShowDialog() == DialogResult.OK)
                {
                    LoadGameData(); // Обновляем данные после добавления игры
                }
            }
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Закрывает все формы и завершает приложение
        }


    }
}

