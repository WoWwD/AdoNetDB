using lab3.forms;
using lab3.lab3DataSetTableAdapters;
using lab3.src;
using lab3.src.interfaces;
using System;
using System.Windows.Forms;
using static lab3.src.CustomChart;
using static lab3.src.Report;

namespace lab3
{
    public partial class MainForm : Form
    {
        private Helper hlp;
        private Random r = new Random();
        private OperationDatabase opDB;
        public MainForm()
        {
            InitializeComponent();
            opDB = new OperationDatabase(акцииTableAdapter, брокерTableAdapter, lab3DataSet, r);
            hlp = new Helper();
        }

        private void Form1_Load(object sender, EventArgs e) => opDB.fillDatabase();

        private void addNewStockButton_Click(object sender, EventArgs e)
        {
            if (hlp.isEmpty(textBoxFirm.Text) ||
                hlp.isEmpty(textBoxCourseOfSell.Text) ||
                hlp.isEmpty(textBoxCount.Text) ||
                hlp.isEmpty(textBoxCourseOfBuy.Text)
            )
            {
                MessageBox.Show(
                  "Заполнены не все поля!",
                  "Сообщение",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information
               );
            }
            else
            {
                try
                {
                    opDB.addEntryDatabase(
                        textBoxFirm.Text, 
                        Convert.ToInt32(textBoxCount.Text), 
                        textBoxCourseOfBuy.Text,
                        textBoxCourseOfSell.Text,
                        true
                    );
                    opDB.updateDatabase();
                    opDB.fillDatabase();
                    textBoxFirm.Clear();
                    textBoxCourseOfSell.Clear();
                    textBoxCount.Clear();
                    textBoxCourseOfBuy.Clear();
                }
                catch
                {
                    MessageBox.Show(
                        "Неверный формат строки!",
                        "Сообщение",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        private void updateStockButton_Click(object sender, EventArgs e)
        {
            try
            {
                string originalFirm = dataGridViewStockTable.CurrentRow.Cells[0].Value.ToString();
                int originalCount = Convert.ToInt32(dataGridViewStockTable.CurrentRow.Cells[1].Value);
                decimal originalCourseOfBuy = Convert.ToDecimal(dataGridViewStockTable.CurrentRow.Cells[2].Value);
                decimal originalCourseOfSell = Convert.ToDecimal(dataGridViewStockTable.CurrentRow.Cells[3].Value);

                string newFirm = textBoxEditFirm.Text.ToString();
                int newCount = Convert.ToInt32(textBoxEditCount.Text);
                decimal newCourseOfBuy = Convert.ToDecimal(textBoxEditCourseOfBuy.Text);
                decimal newCourseOfSell = Convert.ToDecimal(textBoxEditCourseOfSell.Text);

                if (!hlp.isAllEquals(
                    originalFirm,
                    originalCount,
                    originalCourseOfBuy,
                    originalCourseOfSell,
                    newFirm,
                    newCount,
                    newCourseOfBuy,
                    newCourseOfSell
                    )
                )
                {
                    акцииTableAdapter.Update(
                        newFirm,
                        newCount,
                        newCourseOfBuy,
                        newCourseOfSell,
                        originalFirm,
                        originalCount,
                        originalCourseOfBuy,
                        originalCourseOfSell
                    );
                    брокерTableAdapter.Update(lab3DataSet.Брокер);
                    opDB.fillDatabase();
                }
                else
                {
                    MessageBox.Show(
                       "Не введены новые значения!",
                       "Сообщение",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information
                    );
                }
            }
            catch
            {
                MessageBox.Show(
                    "Неверный формат строки!",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            opDB.updateDatabase();
            opDB.fillDatabase();
        }

        private void dataGridViewStockTable_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBoxEditFirm.Text = dataGridViewStockTable.CurrentRow.Cells[0].Value.ToString();
            textBoxEditCount.Text = dataGridViewStockTable.CurrentRow.Cells[1].Value.ToString();
            textBoxEditCourseOfBuy.Text = dataGridViewStockTable.CurrentRow.Cells[2].Value.ToString();
            textBoxEditCourseOfSell.Text = dataGridViewStockTable.CurrentRow.Cells[3].Value.ToString();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) => opDB.closeConnectionDatabase();

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Вы действительно хотите выйти?",
                "Сообщение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information
            );

            if (result == DialogResult.Yes)
            {
                opDB.closeConnectionDatabase();
                Close();
            }         
        }

        private void сортировкаФильтрацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorkDatabaseForm f = new WorkDatabaseForm();
            f.Show();
        }

        private void среднийКурсПокупкиИПродажиАкцийToolStripMenuItemОтчёты_Click(object sender, EventArgs e)
        {
            reportEnums = ReportEnums.AvgCourseOfBuyAndCourseOfSell;
            ReportForm f = new ReportForm();
            f.Text = "Средний курс покупки и продажи акций";
            f.Show();
        }

        private void общееКоличествоАкцийФирмToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reportEnums = ReportEnums.SumCountStockOfFirms;
            ReportForm f = new ReportForm();
            f.Text = "Общее количество акций фирм";
            f.Show();
        }

        private void количествоАкционеровФирмУБрокераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chartEnums = ChartEnums.CountOfShareholdersBroker;
            DiagramForm f = new DiagramForm();
            f.Show();
        }

        private void доляАкцийВсехФирмToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chartEnums = ChartEnums.PartOfStocksAllFirms;
            DiagramForm f = new DiagramForm();
            f.Show();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutAppForm f = new AboutAppForm();
            f.Show();
        }

        private void бДБрокераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatabaseBrokerForm f = new DatabaseBrokerForm();
            f.Show();
        }
    }
    public class OperationDatabase : IOperationDatabase
    {
        public АкцииTableAdapter акцииTableAdapter;
        public БрокерTableAdapter брокерTableAdapter;
        public lab3DataSet lab3DataSet;
        public Random r;

        public OperationDatabase(АкцииTableAdapter акцииTableAdapter, БрокерTableAdapter брокерTableAdapter, lab3DataSet lab3DataSet, Random r)
        {
            this.акцииTableAdapter = акцииTableAdapter;
            this.брокерTableAdapter = брокерTableAdapter;
            this.lab3DataSet = lab3DataSet;
            this.r = r;
        }
        public void addEntryDatabase(string firm, int count, string courseOfBuy, string courseOfSell, bool withBroker)
        {
            акцииTableAdapter.Insert(firm, count, Convert.ToDecimal(courseOfBuy), Convert.ToDecimal(courseOfSell));
            if (withBroker)
            {
                брокерTableAdapter.Insert(firm, DateTime.Today, r.Next(1, 2022202));
            }
        }

        public void closeConnectionDatabase()
        {
            акцииTableAdapter.Connection.Close();
            брокерTableAdapter.Connection.Close();
        }

        public void fillDatabase()
        {
            акцииTableAdapter.Fill(lab3DataSet.Акции);
            брокерTableAdapter.Fill(lab3DataSet.Брокер);
        }

        public void updateDatabase()
        {
            акцииTableAdapter.Update(lab3DataSet.Акции);
            брокерTableAdapter.Update(lab3DataSet.Брокер);
        }
    }
}