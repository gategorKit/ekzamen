using Games.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Games
{
    public partial class FormAddGame : Form
    {
        public FormAddGame()
        {
            InitializeComponent();

            // Загрузка категорий в ComboBox
            List<Model.Category> categories = Helper.DB.Category.ToList();
            comboBoxCategory.DataSource = categories;
            comboBoxCategory.DisplayMember = "Name";
            comboBoxCategory.ValueMember = "Id";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Собираем данные из полей
            var newGame = new Model.Games
            {
                Name = textBoxName.Text,
                Description = textBoxDescription.Text,
                Creator = textBoxCreator.Text,
                Cost = textBoxCost.Text,
                CategoryId = (int)comboBoxCategory.SelectedValue,
                // Добавьте код для обработки изображения, если нужно
            };

            // Сохранение новой игры в базу данных
            Helper.DB.Games.Add(newGame);
            Helper.DB.SaveChanges();

            this.DialogResult = DialogResult.OK; // Успешно добавлено
            this.Close();
        }
        private void buttonBack_Click(object sender, EventArgs e)

        {

            this.DialogResult = DialogResult.Cancel; // Закрываем форму без сохранения

            this.Close();

        }
    }

}
