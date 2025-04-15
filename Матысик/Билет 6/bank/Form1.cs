using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bank
{
    public partial class Form1 : Form
    {

        List<ClassFolder.BankAccount> bankAccounts = new List<ClassFolder.BankAccount>();
        int rowID = 0;
        public Form1()
        {
            InitializeComponent();
            bankDGV.Rows.Clear();
            bankDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            bankDGV.RowHeaderMouseClick += BankDGV_RowHeaderMouseClick;
            bankDGV.CellClick += BankDGV_CellClick;
        }

        private void ButtonEvents_Click(object sender, EventArgs e)
        {
            if (!IsDoubleValid(addToAccountTB.Text) & !IsIntValid(accountIDTB.Text) & !IsDoubleValid(getFromAccountTB.Text) & !IsDoubleValid(moneyTransferTB.Text))
            {
                MessageBox.Show("попробуйте ввести другое значение");
                return;
            }
            if (addToAccountTB.Text.Contains("-") & !IsDoubleValid(getFromAccountTB.Text) & !IsDoubleValid(moneyTransferTB.Text))
            {
                MessageBox.Show("значение не может быть отрицательное");
                return;
            }


            if ((sender as Button).Text.ToLower() == "положить на счёт")
            {
                bankAccounts[rowID].CurrentAmountOfMoney = (float)Convert.ToDouble(String.Format("{0:0.00}", addToAccountTB.Text));
                bankDGV.DataSource = null;
                bankDGV.Refresh();
            }
            if ((sender as Button).Text.ToLower() == "снять со счёта")
            {
                if (bankAccounts[rowID].CurrentAmountOfMoney - (float)Convert.ToDouble(String.Format("{0:0.00}", getFromAccountTB.Text)) < 0)
                {
                    MessageBox.Show("Вы не можете снять денег больше чем лежит на счёте");
                    return;
                }
                bankAccounts[rowID].CurrentAmountOfMoney = bankAccounts[rowID].CurrentAmountOfMoney - (float)Convert.ToDouble(String.Format("{0:0.00}", getFromAccountTB.Text));
                bankDGV.DataSource = null;
                bankDGV.Refresh();
            }
            if ((sender as Button).Text.ToLower() == "перевод со счёта")
            {
                int idOfReciever = int.Parse(accountIDTB.Text);
                try
                {
                    if (bankAccounts[rowID].Id == idOfReciever)
                    {
                        MessageBox.Show("Вы не можете перевести деньги себе же");
                        return;
                    }
                    if (bankAccounts[rowID].CurrentAmountOfMoney - (float)double.Parse(moneyTransferTB.Text) < 0)
                    {
                        MessageBox.Show("Вы не можете снять денег больше чем лежит на счёте");
                        return;
                    }
                    bankAccounts[rowID].CurrentAmountOfMoney -= (float)double.Parse(moneyTransferTB.Text);
                    for (int i = 0; i < bankAccounts.Count; i++)
                    {
                        if (bankAccounts[i].Id == idOfReciever)
                        {
                            idOfReciever = i;
                            break;
                        }
                    }
                    bankAccounts[idOfReciever].CurrentAmountOfMoney += (float)double.Parse(moneyTransferTB.Text);
                }
                catch {
                    MessageBox.Show("что-то пошло не так! Перепроверьте правильность введённой информации!");
                }
            }
            bankDGV.DataSource = null;
            bankDGV.DataSource = bankAccounts;
            accountIDTB.Clear();
            addToAccountTB.Clear();
            getFromAccountTB.Clear();
            moneyTransferTB.Clear();
        }
        private void clearAccountButton_Click(object sender, EventArgs e)
        {
            bankAccounts[rowID].CurrentAmountOfMoney = 0;
            bankDGV.DataSource = null;
            bankDGV.Refresh();
            bankDGV.DataSource = bankAccounts;
        }

        private void BankDGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            rowID = e.RowIndex;
        }
        private void BankDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowID = e.RowIndex;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //default
            ClassFolder.BankAccount defaultBankAcc = new ClassFolder.BankAccount();
            //not default
            ClassFolder.BankAccount notDefaultAcc = new ClassFolder.BankAccount(1337, "Иванов Иван Иванович", 1231.12321312678, new DateTime(2012, 7, 20), DateTime.Now);

            bankAccounts.Add(defaultBankAcc);
            bankAccounts.Add(notDefaultAcc);
            bankDGV.DataSource = bankAccounts;
            AmountOfAccsInBankLabel.Text += bankAccounts.Count;
        }

        private bool IsDoubleValid(string valToCheck)
        {
            if (double.TryParse(valToCheck, out double result))
            {
                return true;
            }
            return false;
        }
        private bool IsIntValid(string valToCheck)
        {
            if (int.TryParse(valToCheck, out int result))
            {
                return true;
            }
            return false;
        }
    }
}
