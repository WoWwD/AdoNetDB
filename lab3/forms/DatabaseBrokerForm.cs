using lab3.lab3DataSetTableAdapters;
using lab3.src;
using lab3.src.interfaces;
using System;
using System.Windows.Forms;

namespace lab3.forms
{
    public partial class DatabaseBrokerForm : Form
    {
        private Helper hlp;
        private OperationsBrokerDatabase opDB;
        public DatabaseBrokerForm()
        {
            InitializeComponent();
            opDB = new OperationsBrokerDatabase(брокерTableAdapter, lab3DataSet);
            hlp = new Helper();
        }

        private void DatabaseBrokerForm_Load(object sender, EventArgs e)
            => opDB.fillDatabase();

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            opDB.closeConnectionDatabase();
            Close();
        }

        private void DatabaseBrokerForm_FormClosing(object sender, FormClosingEventArgs e)
            => брокерTableAdapter.Connection.Close();
    }
    public class OperationsBrokerDatabase: IOperationDatabase
    {
        public БрокерTableAdapter брокерTableAdapter;
        public lab3DataSet lab3DataSet;
        public OperationsBrokerDatabase(БрокерTableAdapter брокерTableAdapter, lab3DataSet lab3DataSet)
        {
            this.брокерTableAdapter = брокерTableAdapter;
            this.lab3DataSet = lab3DataSet;
        }

        public void addEntryDatabase(string firm, int count, string courseOfBuy, string courseOfSell, bool withBroker)
            => throw new Exception("Добавления записей нет");

        public void closeConnectionDatabase() => брокерTableAdapter.Connection.Close();

        public void fillDatabase() => брокерTableAdapter.Fill(lab3DataSet.Брокер);

        public void updateDatabase()
            => throw new Exception("Не используется");
    }
}