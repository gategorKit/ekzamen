using System.Media;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using Microsoft.VisualBasic;
using System.IO;
using System.Text;
using System.Web;
using System;
using System.Drawing;

namespace сапёр
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer gameTimer;
        private Panel overlayPanel; // Панель для затемнения

        public Form1()
        {
            InitializeComponent();
        }
        public static int totalMines = 1;
        public static int defusedMines = 0;
        public static int gameTimeMinutes = 5;
        private int secondsPassed = 0; // Количество секунд, прошедших с момента запуска игры

        private void kolvo_min_ValueChanged(object sender, EventArgs e)
        {
            totalMines = Convert.ToInt32(kolvo_min.Value);
        }



        private void pictureBox2_MouseMove(object sender, MouseEventArgs g)
        {
            /*koordx.Text = g.X.ToString();
            koordy.Text = g.Y.ToString();*/
        }
        private void Form1_MouseMove(object sender, MouseEventArgs g)
        {
            koordx.Text = g.X.ToString();
            koordy.Text = g.Y.ToString();
            int p1x = g.X - pictureBox1.Location.X;
            int p1y = g.Y - pictureBox1.Location.Y;
            int coord = Convert.ToInt32(Math.Sqrt(p1x * p1x + p1y * p1y));

            rasst_min.Text = coord.ToString();

        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {

            pictureBox2.BackgroundImage = Properties.Resources.vzriv;
            
            defusedMines = defusedMines + 1;
            int min = totalMines - defusedMines;
            if (defusedMines < totalMines)
            {
                MessageBox.Show("Поздравляем! Вы обезвредили 1 мину! Вам осталось обезвредить " + min + " мин(у)!", "-1 мина", MessageBoxButtons.OK, MessageBoxIcon.None);
                pictureBox2.BackgroundImage = Properties.Resources.mina;
                pictureBox2.Visible = false;
                pictureBox1.Size = new Size(pictureBox1.Width - 5, pictureBox1.Height - 5);
                pictureBox2.Size = new Size(pictureBox1.Width, pictureBox1.Height);
                PlaceMine();
                return;
            }
            if (defusedMines == totalMines)
            {
                DialogResult vopros;
                vopros = MessageBox.Show("Поздравляем! Вы обезвредили все мины! Желаете сыграть ещё?", "Перезагрузка", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (vopros == DialogResult.Yes)
                {
                    Application.Restart();
                }
                if (vopros == DialogResult.No)
                {
                    Environment.Exit(0);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;


            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;

            // Создание и настройка панели для затемнения
            overlayPanel = new Panel();
            overlayPanel.BackColor = Color.Black; // Черный цвет
            overlayPanel.Size = new Size(882, 564); // Размеры как у pictureBox1
            overlayPanel.Location = new Point(0, 0);
            this.Controls.Add(overlayPanel);
            overlayPanel.BringToFront(); // Помещаем поверх pictureBox1
            overlayPanel.Visible = true; // Сначала отображаем затемнение

            totalMines = Convert.ToInt32(kolvo_min.Value);
            gameTimeMinutes = Convert.ToInt32(Interaction.InputBox("Введите время на игру (в минутах):", "Настройка игры", "5"));

            gameTimer = new System.Windows.Forms.Timer();
            gameTimer.Interval = 1000;
            gameTimer.Tick += GameTimer_Tick;

            PlaceMine();
        }
        private void PlaceMine()
        {
            Random x = new Random();
            Random y = new Random();
            int x_new, y_new;

            // Генерация координат, пока они не будут удовлетворять условиям
            do
            {
                x_new = x.Next(0, 882 - pictureBox2.Width);  // Граница меню
                y_new = y.Next(0, 564 - pictureBox2.Height); // Нижняя граница
            } while (x_new < 0 || x_new > 882 - pictureBox2.Width || y_new < 0 || y_new > 564 - pictureBox2.Height);

            pictureBox1.Location = new Point(x_new, y_new);
            pictureBox2.Location = new Point(x_new, y_new);


        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            secondsPassed++;

            if (secondsPassed >= gameTimeMinutes * 60) // Проверка, прошло ли указанное количество минут
            {
                gameTimer.Stop();
                MessageBox.Show("Время вышло! Игра завершена.", "Конец игры", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Environment.Exit(0);
            }

            // Вывод оставшегося времени в минутах и секундах
            int minutesLeft = (gameTimeMinutes * 60 - secondsPassed) / 60;
            int secondsLeft = (gameTimeMinutes * 60 - secondsPassed) % 60;

            // Вывод времени на форме (например, в label)
            // label1.Text = $"Осталось: {minutesLeft:00}:{secondsLeft:00}";
        }





        private void exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0); // Закрытие приложения
        }

        private void start_Click(object sender, EventArgs e)
        {
            if (totalMines <= 0)
            {
                MessageBox.Show("Введите количество мин перед началом игры!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Убираем затемнение
            overlayPanel.Visible = false;


            // Включение взаимодействия с элементами
            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;


            // Запуск таймера и размещение мин
            gameTimer.Start();

            for (int i = 0; i < totalMines; i++)
            {
                PlaceMine();
            }

            MessageBox.Show($"Игра началась! На поле размещено {totalMines} мин.", "Начало игры", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
