using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
namespace TextDataExamen_3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<String> titles = new List<String>();
        List<double> prices = new List<double>();
        public MainWindow()
        {
            InitializeComponent();
            try
            {
                StreamReader streamReader = new StreamReader("input.txt");
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    titles.Add(line.Split(':')[0].Trim());
                    prices.Add(double.Parse(line.Split(':')[1].Trim()));
                }
                streamReader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Не удалось загрузить данные из файла.\n" + e.Message);
            }
            cbName.ItemsSource = titles;
        }
        List<Product> products = new List<Product>();
        public void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            var name = cbName.Text;
            int amount;
            double price, sale;
            if (!int.TryParse(tbAmount.Text, out amount))
            {
                MessageBox.Show("Количество не int");
                return;
            }
            if (!double.TryParse(tbPrice.Text, out price))
            {
                MessageBox.Show("Цена не double");
                return;
            }
            if (!double.TryParse(tbSale.Text, out sale))
            {
                MessageBox.Show("Скидка не double");
                return;
            }
            if (sale < 0 || sale > 90)
            {
                MessageBox.Show("Скидка от 0 до 90");
                return;
            }
            if (amount <= 0)
            {
                MessageBox.Show("Количество дурное");
                return;
            }
            var newProduct = new Product(name, amount, price, sale);
            products.Add(newProduct);
            tbTab.Text = "";
            string tabText = "";
            double noSaleSumm = 0;
            double pureSaleSumm = 0;
            double saleSumm = 0;
            using (StreamWriter writer = new StreamWriter("output.txt", false))
            {
                foreach (var product in products)
                {
                    tabText += "Товар: " + product.name + "\n";
                    tabText += "Количество: " + product.amount + "\n";
                    tabText += "Цена товара: " + product.price + "\n";
                    tabText += "Скидка: " + product.pureSale + "\n";
                    tabText += "Итог: " + product.total + "\n";
                    tabText += "--------------------------------\n";
                    tbTab.Text += tabText;
                    noSaleSumm += product.price * product.amount;
                    pureSaleSumm += product.pureSale;
                    saleSumm += product.total;
                    writer.WriteLine(tabText);
                }
            }
            tbSaleOutput.Text = pureSaleSumm.ToString();
            tbTotalNoSaleOutput.Text = noSaleSumm.ToString();
            tbTotalOutput.Text = saleSumm.ToString();


        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            products.Clear();
            tbTab.Text = "";
            tbSaleOutput.Text = "";
            tbTotalNoSaleOutput.Text = "";
            tbTotalOutput.Text = "";
            using (StreamWriter writer = new StreamWriter("output.txt", false)){}
        }

        private void cbName_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            tbPrice.Text = prices[cbName.SelectedIndex].ToString();
        }

        private void tbAmount_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text[0]))
            {
                e.Handled = true;
            }
        }

        private void tbSale_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit((char)e.Text[0]))
            {
                e.Handled = true;
            }
        }
    }
}
