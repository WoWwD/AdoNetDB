using System;
using System.Windows.Forms;

namespace lab3
{
    public partial class AboutAppForm : Form
    {
        public AboutAppForm()
        {
            InitializeComponent();
            label1.Text = $"{Convert.ToChar(169)}2022 Кандрин, Inc.\nВсе права защищены.";
            label2.Text = "Благодарим за использование этой программы.\nНадеемся, она вам понравилась.";
            label3.Text = "Программа для учёта акций компаний,\nсделанная на основе технологии ADO.NET";
        }

        private void closeFormButton_Click(object sender, EventArgs e) => Close();
    }
}