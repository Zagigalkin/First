using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSMoney;

namespace CSLessons6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            balance = 1000;
        }

        private double balance;

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            MoneyEntry me = new MoneyEntry();

            double _income;
            double.TryParse(textBoxAmount.Text, out _income);

            me.Amount = _income;
            me.EntryDate = dtpdate.Value;
            me.Destriction = textBoxDescription.Text;
            me.Category = textBoxCategory.Text;

            AddEntry(me);

           UpdateBalance();
           ClearField();
        }

        private void UpdateBalance()
        {

            double balance = 0;
            foreach (DataGridViewRow row in dataGridViewEntries.Rows)
            {
                double income;
                double.TryParse((row.Cells[1].Value ?? "0").ToString(), out income);

                balance += income;
            }

            textBoxBalance.Text = balance.ToString();

        }

        private void AddEntry(MoneyEntry me)
        {
            dataGridViewEntries.Rows.Add(me.IsDebit ? "Доход":"Расход",
                me.Amount,
                me.EntryDate.ToShortDateString(),
                me.Destriction,
                me.Category    );
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ClearField()
        {
            textBoxAmount.Text = "";
            textBoxCategory.Text = "";
            textBoxDescription.Text = "";
            dtpdate.Value = DateTime.Now;
        }

        private void dataGridViewEntries_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 && dataGridViewEntries.Rows.Count > 0)
            {
                double income;
                double.TryParse((dataGridViewEntries[e.ColumnIndex, e.RowIndex].Value ?? "0").ToString(), out income);

                dataGridViewEntries[0, e.RowIndex].Value = (income < 0) ? "Расход" : "Доход";
                
                UpdateBalance();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Привет!");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show(string.Format("Ваш баланс равен {0}", textBoxBalance.Text));

            man.SaveAll();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LoadEntriesToInterface()
        {
            foreach (MoneyEntry me in man.Entries)
            {
                AddEntry(me);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        StrictsMoneyEntryDescriptionFilter strictFilter = new StrictsMoneyEntryDescriptionFilter();
                        strictFilter.SearchPettern = textBox1.Text;
                        man.Filter = strictFilter;
                        break;
                    case 1:
                        LeftMoneyEntryDescriptionFilter leftFilter = new LeftMoneyEntryDescriptionFilter();
                        leftFilter.SearchPettern = textBox1.Text;
                        man.Filter = leftFilter;
                        break;
                    case 2:
                        RightMoneyEntryDescriptionFilter RightFilter = new RightMoneyEntryDescriptionFilter();
                        RightFilter.SearchPettern = textBox1.Text;
                        man.Filter = RightFilter;
                        break;
                    case 3:
                        FreeMoneyEntryDescriptionFilter FreeFilter = new FreeMoneyEntryDescriptionFilter();
                        FreeFilter.SearchPettern = textBox1.Text;
                        man.Filter = FreeFilter;
                        break;
                    case 4:
                        FullMoneyEntryDescriptionFilter FullFilter = new FullMoneyEntryDescriptionFilter();
                        FullFilter.SearchPettern = textBox1.Text;
                        man.Filter = FullFilter;
                        break;
                }

                RefreshTable();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            man.Filter = null;
            RefreshTable();
        }

        private void RefreshTable()
            {
            dataGridViewEntries.Rows.Clear();
            LoadEntriesToInterface();
            }
    }
}
