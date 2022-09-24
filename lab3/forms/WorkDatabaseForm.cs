using lab3.src;
using lab3.src.interfaces;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace lab3
{
    public partial class WorkDatabaseForm : Form
    {
        OperationDatabaseStocks opDBStocks;
        DataSet dataset;
        OleDbCommand oleDbCommand;
        OleDbDataAdapter oleDbDataAdapter;
        OleDbConnection oleDbConnection;
        public WorkDatabaseForm()
        {
            InitializeComponent();
            oleDbConnection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\lab3.accdb");
            oleDbCommand = new OleDbCommand();
            oleDbDataAdapter = new OleDbDataAdapter();
            dataset = new DataSet();
            opDBStocks = new OperationDatabaseStocks(oleDbConnection, dataset, oleDbCommand, oleDbDataAdapter, dataGridViewStocksTable);

            oleDbConnection.Open();
            oleDbCommand.Connection = oleDbConnection;


            opDBStocks.fillDatabase();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            opDBStocks.closeConnectionDatabase();
            Close();
        }

        private void dataGridViewStocksTable_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            decimal res = opDBStocks.calc();
            if (res == 0)
            {
                profitLabel.Text = $"Прибыль при продаже акций: Записей нет";

            }
            else
            {
                profitLabel.Text = $"Прибыль при продаже акций: {res.ToString("C")}";
            }
        }

        private void getTableCalcButton_Click(object sender, EventArgs e) => opDBStocks.getTableCalc();

        private void getTableAvgCountButton_Click(object sender, EventArgs e) => opDBStocks.getTableAvgCount();

        private void Form2_FormClosing(object sender, FormClosingEventArgs e) 
            => opDBStocks.closeConnectionDatabase();

        private void поУбываниюToolStripMenuItem1КурсПокупки_Click(object sender, EventArgs e)
            => opDBStocks.newTable(new DataSet(), SQLCommands.sortCourseOfBuyDESCCommand);

        private void поВозрастаниюToolStripMenuItem2КурсПокупки_Click(object sender, EventArgs e)
            => opDBStocks.newTable(new DataSet(), SQLCommands.sortCourseOfBuyASCCommand);

        private void поУбываниюToolStripMenuItem1КурсПродажи_Click(object sender, EventArgs e)
            => opDBStocks.newTable(new DataSet(), SQLCommands.sortCourseOfSellDESCCommand);

        private void поВозрастаниюToolStripMenuItem2КурсПродажи_Click(object sender, EventArgs e)
            => opDBStocks.newTable(new DataSet(), SQLCommands.sortCourseOfBuyASCCommand);

        private void updateButton_Click(object sender, EventArgs e) => opDBStocks.fillDatabase();

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            opDBStocks.closeConnectionDatabase();
            Close();
        }

        private void поУбываниюToolStripMenuItemФирма_Click(object sender, EventArgs e)
            => opDBStocks.newTable(new DataSet(), SQLCommands.sortFirmDESCCommand);

        private void поВозрастаниюToolStripMenuItemФирма_Click(object sender, EventArgs e)
            => opDBStocks.newTable(new DataSet(), SQLCommands.sortFirmASCCommand);

        private void поУбываниюToolStripMenuItem1Количество_Click(object sender, EventArgs e)
            => opDBStocks.newTable(new DataSet(), SQLCommands.sortCountDESCCommand);

        private void поВозрастаниюToolStripMenuItem1Количество_Click(object sender, EventArgs e)
            => opDBStocks.newTable(new DataSet(), SQLCommands.sortCountASCCommand);

        private void applyFilterButton_Click(object sender, EventArgs e)
        {
            string _symbol = "";
            int _symbolSwitch = listBoxSymbol.SelectedIndex;
            int _valueField = listBoxField.SelectedIndex;

            switch (_symbolSwitch)
            {
                case 0:
                    _symbol = "<";
                    break;
                case 1:
                    _symbol = ">";
                    break;
                case 2:
                    _symbol = "=";
                    break;
            }
            try
            {
                switch (_valueField)
                {
                    case 0:
                        opDBStocks.filter("Фирма", _symbol, textBoxInputValue.Text);
                        break;
                    case 1:
                        opDBStocks.filter("Количество", _symbol, textBoxInputValue.Text);
                        break;
                    case 2:
                        opDBStocks.filter("Курс_покупки", _symbol, textBoxInputValue.Text);
                        break;
                    case 3:
                        opDBStocks.filter("Курс_продажи", _symbol, textBoxInputValue.Text);
                        break;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(
                    "Неверный формат строки!",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void discardFilterButton_Click(object sender, EventArgs e)
        {
            listBoxField.ClearSelected();
            listBoxSymbol.ClearSelected();
            textBoxInputValue.Clear();
            opDBStocks.fillDatabase();
        }
    }

    public class OperationDatabaseStocks : IOperationDatabase
    {
        public OleDbConnection oleDbConnection;
        public DataSet dataset;
        public OleDbCommand oleDbCommand;
        public OleDbDataAdapter oleDbDataAdapter;
        public DataGridView dataGridViewStocksTable;

        public OperationDatabaseStocks(OleDbConnection oleDbConnection, DataSet dataset, OleDbCommand oleDbCommand, OleDbDataAdapter oleDbDataAdapter, DataGridView dataGridViewStocksTable)
        {
            this.oleDbConnection = oleDbConnection;
            this.dataset = dataset;
            this.oleDbCommand = oleDbCommand;
            this.oleDbDataAdapter = oleDbDataAdapter;
            this.dataGridViewStocksTable = dataGridViewStocksTable;
        }

        public void addEntryDatabase(string firm, int count, string courseOfBuy, string courseOfSell, bool withBroker)
            => throw new Exception("Добавления записей нет");

        public void closeConnectionDatabase() => oleDbConnection.Close();

        public void fillDatabase() => newTable(new DataSet(), SQLCommands.defaultCommand);

        public void updateDatabase() => throw new Exception("Обновления БД нет");

        public void getTableCalc() => newTable(new DataSet(), SQLCommands.calcCommand);

        public void getTableAvgCount() => newTable(new DataSet(), SQLCommands.avgCommand);

        public void newTable(DataSet ds, string command)
        {
            oleDbCommand.CommandText = command;
            oleDbDataAdapter.SelectCommand = oleDbCommand;
            oleDbDataAdapter.Fill(ds, "Акции");
            dataGridViewStocksTable.DataSource = ds;
            dataGridViewStocksTable.DataMember = "Акции";
        }
        public void filter(string field, string symbol, string value)
        {
            BindingSource bs = new BindingSource();
            DataSet ds = new DataSet();
            oleDbCommand.CommandText = SQLCommands.defaultCommand;
            oleDbDataAdapter.SelectCommand = oleDbCommand;
            oleDbDataAdapter.Fill(ds, "Акции");

            bs.DataSource = ds.Tables["Акции"];
            dataGridViewStocksTable.DataSource = ds.Tables["Акции"];
            bs.Filter = $"{field} {symbol} '{value}'";
        }
        public decimal calc()
        {
            try
            {
                decimal count = Convert.ToDecimal(dataGridViewStocksTable.CurrentRow.Cells[1].Value);
                decimal courseOfBuy = Convert.ToDecimal(dataGridViewStocksTable.CurrentRow.Cells[2].Value);
                decimal courseOfSell = Convert.ToDecimal(dataGridViewStocksTable.CurrentRow.Cells[3].Value);
                return count * courseOfSell - count * courseOfBuy;
            }
            catch
            {
                return 0;
            }
        }
    }
}