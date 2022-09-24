namespace lab3
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lab3DataSet = new lab3.lab3DataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addNewStockButton = new System.Windows.Forms.Button();
            this.textBoxCourseOfBuy = new System.Windows.Forms.TextBox();
            this.labelCourseOfSell = new System.Windows.Forms.Label();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.labelCourseOfBuy = new System.Windows.Forms.Label();
            this.textBoxCourseOfSell = new System.Windows.Forms.TextBox();
            this.labelCount = new System.Windows.Forms.Label();
            this.textBoxFirm = new System.Windows.Forms.TextBox();
            this.labelFirm = new System.Windows.Forms.Label();
            this.dataGridViewStockTable = new System.Windows.Forms.DataGridView();
            this.фирмаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.акцииBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.updateStockButton = new System.Windows.Forms.Button();
            this.textBoxEditCourseOfBuy = new System.Windows.Forms.TextBox();
            this.labelCourseOfSellEdit = new System.Windows.Forms.Label();
            this.textBoxEditCount = new System.Windows.Forms.TextBox();
            this.labelCourseOfBuyEdit = new System.Windows.Forms.Label();
            this.textBoxEditCourseOfSell = new System.Windows.Forms.TextBox();
            this.labelCountEdit = new System.Windows.Forms.Label();
            this.textBoxEditFirm = new System.Windows.Forms.TextBox();
            this.labelFirmEdit = new System.Windows.Forms.Label();
            this.акцииTableAdapter = new lab3.lab3DataSetTableAdapters.АкцииTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.работаСБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортировкаФильтрацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.бДБрокераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчётыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.среднийКурсПокупкиИПродажиАкцийToolStripMenuItemОтчёты = new System.Windows.Forms.ToolStripMenuItem();
            this.общееКоличествоАкцийФирмToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.диаграммыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.количествоАкционеровФирмУБрокераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.доляАкцийВсехФирмToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.брокерTableAdapter = new lab3.lab3DataSetTableAdapters.БрокерTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab3DataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStockTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.акцииBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.lab3DataSet;
            this.bindingSource1.Position = 0;
            // 
            // lab3DataSet
            // 
            this.lab3DataSet.DataSetName = "lab3DataSet";
            this.lab3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addNewStockButton);
            this.groupBox1.Controls.Add(this.textBoxCourseOfBuy);
            this.groupBox1.Controls.Add(this.labelCourseOfSell);
            this.groupBox1.Controls.Add(this.textBoxCount);
            this.groupBox1.Controls.Add(this.labelCourseOfBuy);
            this.groupBox1.Controls.Add(this.textBoxCourseOfSell);
            this.groupBox1.Controls.Add(this.labelCount);
            this.groupBox1.Controls.Add(this.textBoxFirm);
            this.groupBox1.Controls.Add(this.labelFirm);
            this.groupBox1.Location = new System.Drawing.Point(788, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 213);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление";
            // 
            // addNewStockButton
            // 
            this.addNewStockButton.Location = new System.Drawing.Point(88, 168);
            this.addNewStockButton.Name = "addNewStockButton";
            this.addNewStockButton.Size = new System.Drawing.Size(90, 40);
            this.addNewStockButton.TabIndex = 7;
            this.addNewStockButton.Text = "Добавить";
            this.addNewStockButton.UseVisualStyleBackColor = true;
            this.addNewStockButton.Click += new System.EventHandler(this.addNewStockButton_Click);
            // 
            // textBoxCourseOfBuy
            // 
            this.textBoxCourseOfBuy.Location = new System.Drawing.Point(107, 92);
            this.textBoxCourseOfBuy.Name = "textBoxCourseOfBuy";
            this.textBoxCourseOfBuy.Size = new System.Drawing.Size(100, 22);
            this.textBoxCourseOfBuy.TabIndex = 3;
            // 
            // labelCourseOfSell
            // 
            this.labelCourseOfSell.AutoSize = true;
            this.labelCourseOfSell.Location = new System.Drawing.Point(6, 124);
            this.labelCourseOfSell.Name = "labelCourseOfSell";
            this.labelCourseOfSell.Size = new System.Drawing.Size(98, 16);
            this.labelCourseOfSell.TabIndex = 6;
            this.labelCourseOfSell.Text = "Курс продажи";
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(107, 64);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(100, 22);
            this.textBoxCount.TabIndex = 2;
            // 
            // labelCourseOfBuy
            // 
            this.labelCourseOfBuy.AutoSize = true;
            this.labelCourseOfBuy.Location = new System.Drawing.Point(6, 95);
            this.labelCourseOfBuy.Name = "labelCourseOfBuy";
            this.labelCourseOfBuy.Size = new System.Drawing.Size(95, 16);
            this.labelCourseOfBuy.TabIndex = 5;
            this.labelCourseOfBuy.Text = "Курс покупки";
            // 
            // textBoxCourseOfSell
            // 
            this.textBoxCourseOfSell.Location = new System.Drawing.Point(107, 121);
            this.textBoxCourseOfSell.Name = "textBoxCourseOfSell";
            this.textBoxCourseOfSell.Size = new System.Drawing.Size(100, 22);
            this.textBoxCourseOfSell.TabIndex = 1;
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(6, 66);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(85, 16);
            this.labelCount.TabIndex = 4;
            this.labelCount.Text = "Количество";
            // 
            // textBoxFirm
            // 
            this.textBoxFirm.Location = new System.Drawing.Point(107, 36);
            this.textBoxFirm.Name = "textBoxFirm";
            this.textBoxFirm.Size = new System.Drawing.Size(100, 22);
            this.textBoxFirm.TabIndex = 0;
            // 
            // labelFirm
            // 
            this.labelFirm.AutoSize = true;
            this.labelFirm.Location = new System.Drawing.Point(6, 39);
            this.labelFirm.Name = "labelFirm";
            this.labelFirm.Size = new System.Drawing.Size(51, 16);
            this.labelFirm.TabIndex = 3;
            this.labelFirm.Text = "Фирма";
            // 
            // dataGridViewStockTable
            // 
            this.dataGridViewStockTable.AllowUserToAddRows = false;
            this.dataGridViewStockTable.AllowUserToDeleteRows = false;
            this.dataGridViewStockTable.AutoGenerateColumns = false;
            this.dataGridViewStockTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStockTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.фирмаDataGridViewTextBoxColumn,
            this.количествоDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridViewStockTable.DataSource = this.акцииBindingSource;
            this.dataGridViewStockTable.Location = new System.Drawing.Point(12, 64);
            this.dataGridViewStockTable.Name = "dataGridViewStockTable";
            this.dataGridViewStockTable.ReadOnly = true;
            this.dataGridViewStockTable.RowHeadersWidth = 51;
            this.dataGridViewStockTable.RowTemplate.Height = 24;
            this.dataGridViewStockTable.Size = new System.Drawing.Size(749, 446);
            this.dataGridViewStockTable.TabIndex = 0;
            this.dataGridViewStockTable.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStockTable_CellEnter);
            // 
            // фирмаDataGridViewTextBoxColumn
            // 
            this.фирмаDataGridViewTextBoxColumn.DataPropertyName = "Фирма";
            this.фирмаDataGridViewTextBoxColumn.HeaderText = "Фирма";
            this.фирмаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.фирмаDataGridViewTextBoxColumn.Name = "фирмаDataGridViewTextBoxColumn";
            this.фирмаDataGridViewTextBoxColumn.ReadOnly = true;
            this.фирмаDataGridViewTextBoxColumn.Width = 125;
            // 
            // количествоDataGridViewTextBoxColumn
            // 
            this.количествоDataGridViewTextBoxColumn.DataPropertyName = "Количество";
            this.количествоDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.количествоDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.количествоDataGridViewTextBoxColumn.Name = "количествоDataGridViewTextBoxColumn";
            this.количествоDataGridViewTextBoxColumn.ReadOnly = true;
            this.количествоDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Курс_покупки";
            this.dataGridViewTextBoxColumn1.HeaderText = "Курс_покупки";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Курс_продажи";
            this.dataGridViewTextBoxColumn2.HeaderText = "Курс_продажи";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // акцииBindingSource
            // 
            this.акцииBindingSource.DataMember = "Акции";
            this.акцииBindingSource.DataSource = this.bindingSource1;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.акцииBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 30);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1071, 31);
            this.bindingNavigator1.TabIndex = 4;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.updateStockButton);
            this.groupBox2.Controls.Add(this.textBoxEditCourseOfBuy);
            this.groupBox2.Controls.Add(this.labelCourseOfSellEdit);
            this.groupBox2.Controls.Add(this.textBoxEditCount);
            this.groupBox2.Controls.Add(this.labelCourseOfBuyEdit);
            this.groupBox2.Controls.Add(this.textBoxEditCourseOfSell);
            this.groupBox2.Controls.Add(this.labelCountEdit);
            this.groupBox2.Controls.Add(this.textBoxEditFirm);
            this.groupBox2.Controls.Add(this.labelFirmEdit);
            this.groupBox2.Location = new System.Drawing.Point(788, 297);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 213);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Редактирование";
            // 
            // updateStockButton
            // 
            this.updateStockButton.Location = new System.Drawing.Point(88, 167);
            this.updateStockButton.Name = "updateStockButton";
            this.updateStockButton.Size = new System.Drawing.Size(90, 40);
            this.updateStockButton.TabIndex = 7;
            this.updateStockButton.Text = "Обновить";
            this.updateStockButton.UseVisualStyleBackColor = true;
            this.updateStockButton.Click += new System.EventHandler(this.updateStockButton_Click);
            // 
            // textBoxEditCourseOfBuy
            // 
            this.textBoxEditCourseOfBuy.Location = new System.Drawing.Point(107, 92);
            this.textBoxEditCourseOfBuy.Name = "textBoxEditCourseOfBuy";
            this.textBoxEditCourseOfBuy.Size = new System.Drawing.Size(100, 22);
            this.textBoxEditCourseOfBuy.TabIndex = 3;
            // 
            // labelCourseOfSellEdit
            // 
            this.labelCourseOfSellEdit.AutoSize = true;
            this.labelCourseOfSellEdit.Location = new System.Drawing.Point(6, 124);
            this.labelCourseOfSellEdit.Name = "labelCourseOfSellEdit";
            this.labelCourseOfSellEdit.Size = new System.Drawing.Size(98, 16);
            this.labelCourseOfSellEdit.TabIndex = 6;
            this.labelCourseOfSellEdit.Text = "Курс продажи";
            // 
            // textBoxEditCount
            // 
            this.textBoxEditCount.Location = new System.Drawing.Point(107, 64);
            this.textBoxEditCount.Name = "textBoxEditCount";
            this.textBoxEditCount.Size = new System.Drawing.Size(100, 22);
            this.textBoxEditCount.TabIndex = 2;
            // 
            // labelCourseOfBuyEdit
            // 
            this.labelCourseOfBuyEdit.AutoSize = true;
            this.labelCourseOfBuyEdit.Location = new System.Drawing.Point(6, 95);
            this.labelCourseOfBuyEdit.Name = "labelCourseOfBuyEdit";
            this.labelCourseOfBuyEdit.Size = new System.Drawing.Size(95, 16);
            this.labelCourseOfBuyEdit.TabIndex = 5;
            this.labelCourseOfBuyEdit.Text = "Курс покупки";
            // 
            // textBoxEditCourseOfSell
            // 
            this.textBoxEditCourseOfSell.Location = new System.Drawing.Point(107, 121);
            this.textBoxEditCourseOfSell.Name = "textBoxEditCourseOfSell";
            this.textBoxEditCourseOfSell.Size = new System.Drawing.Size(100, 22);
            this.textBoxEditCourseOfSell.TabIndex = 1;
            // 
            // labelCountEdit
            // 
            this.labelCountEdit.AutoSize = true;
            this.labelCountEdit.Location = new System.Drawing.Point(6, 66);
            this.labelCountEdit.Name = "labelCountEdit";
            this.labelCountEdit.Size = new System.Drawing.Size(85, 16);
            this.labelCountEdit.TabIndex = 4;
            this.labelCountEdit.Text = "Количество";
            // 
            // textBoxEditFirm
            // 
            this.textBoxEditFirm.Location = new System.Drawing.Point(107, 36);
            this.textBoxEditFirm.Name = "textBoxEditFirm";
            this.textBoxEditFirm.Size = new System.Drawing.Size(100, 22);
            this.textBoxEditFirm.TabIndex = 0;
            // 
            // labelFirmEdit
            // 
            this.labelFirmEdit.AutoSize = true;
            this.labelFirmEdit.Location = new System.Drawing.Point(6, 39);
            this.labelFirmEdit.Name = "labelFirmEdit";
            this.labelFirmEdit.Size = new System.Drawing.Size(51, 16);
            this.labelFirmEdit.TabIndex = 3;
            this.labelFirmEdit.Text = "Фирма";
            // 
            // акцииTableAdapter
            // 
            this.акцииTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.работаСБДToolStripMenuItem,
            this.отчётыToolStripMenuItem,
            this.диаграммыToolStripMenuItem,
            this.оПрограммеToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1071, 30);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // работаСБДToolStripMenuItem
            // 
            this.работаСБДToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сортировкаФильтрацияToolStripMenuItem,
            this.бДБрокераToolStripMenuItem});
            this.работаСБДToolStripMenuItem.Name = "работаСБДToolStripMenuItem";
            this.работаСБДToolStripMenuItem.Size = new System.Drawing.Size(105, 26);
            this.работаСБДToolStripMenuItem.Text = "Работа с БД";
            // 
            // сортировкаФильтрацияToolStripMenuItem
            // 
            this.сортировкаФильтрацияToolStripMenuItem.Name = "сортировкаФильтрацияToolStripMenuItem";
            this.сортировкаФильтрацияToolStripMenuItem.Size = new System.Drawing.Size(345, 26);
            this.сортировкаФильтрацияToolStripMenuItem.Text = "Сортировка и фильтрация БД акций";
            this.сортировкаФильтрацияToolStripMenuItem.Click += new System.EventHandler(this.сортировкаФильтрацияToolStripMenuItem_Click);
            // 
            // бДБрокераToolStripMenuItem
            // 
            this.бДБрокераToolStripMenuItem.Name = "бДБрокераToolStripMenuItem";
            this.бДБрокераToolStripMenuItem.Size = new System.Drawing.Size(345, 26);
            this.бДБрокераToolStripMenuItem.Text = "БД брокера";
            this.бДБрокераToolStripMenuItem.Click += new System.EventHandler(this.бДБрокераToolStripMenuItem_Click);
            // 
            // отчётыToolStripMenuItem
            // 
            this.отчётыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.среднийКурсПокупкиИПродажиАкцийToolStripMenuItemОтчёты,
            this.общееКоличествоАкцийФирмToolStripMenuItem});
            this.отчётыToolStripMenuItem.Name = "отчётыToolStripMenuItem";
            this.отчётыToolStripMenuItem.Size = new System.Drawing.Size(73, 26);
            this.отчётыToolStripMenuItem.Text = "Отчёты";
            // 
            // среднийКурсПокупкиИПродажиАкцийToolStripMenuItemОтчёты
            // 
            this.среднийКурсПокупкиИПродажиАкцийToolStripMenuItemОтчёты.Name = "среднийКурсПокупкиИПродажиАкцийToolStripMenuItemОтчёты";
            this.среднийКурсПокупкиИПродажиАкцийToolStripMenuItemОтчёты.Size = new System.Drawing.Size(374, 26);
            this.среднийКурсПокупкиИПродажиАкцийToolStripMenuItemОтчёты.Text = "Средний курс покупки и продажи акций";
            this.среднийКурсПокупкиИПродажиАкцийToolStripMenuItemОтчёты.Click += new System.EventHandler(this.среднийКурсПокупкиИПродажиАкцийToolStripMenuItemОтчёты_Click);
            // 
            // общееКоличествоАкцийФирмToolStripMenuItem
            // 
            this.общееКоличествоАкцийФирмToolStripMenuItem.Name = "общееКоличествоАкцийФирмToolStripMenuItem";
            this.общееКоличествоАкцийФирмToolStripMenuItem.Size = new System.Drawing.Size(374, 26);
            this.общееКоличествоАкцийФирмToolStripMenuItem.Text = "Общее количество акций фирм";
            this.общееКоличествоАкцийФирмToolStripMenuItem.Click += new System.EventHandler(this.общееКоличествоАкцийФирмToolStripMenuItem_Click);
            // 
            // диаграммыToolStripMenuItem
            // 
            this.диаграммыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.количествоАкционеровФирмУБрокераToolStripMenuItem,
            this.доляАкцийВсехФирмToolStripMenuItem});
            this.диаграммыToolStripMenuItem.Name = "диаграммыToolStripMenuItem";
            this.диаграммыToolStripMenuItem.Size = new System.Drawing.Size(106, 26);
            this.диаграммыToolStripMenuItem.Text = "Диаграммы";
            // 
            // количествоАкционеровФирмУБрокераToolStripMenuItem
            // 
            this.количествоАкционеровФирмУБрокераToolStripMenuItem.Name = "количествоАкционеровФирмУБрокераToolStripMenuItem";
            this.количествоАкционеровФирмУБрокераToolStripMenuItem.Size = new System.Drawing.Size(379, 26);
            this.количествоАкционеровФирмУБрокераToolStripMenuItem.Text = "Количество акционеров фирм у брокера";
            this.количествоАкционеровФирмУБрокераToolStripMenuItem.Click += new System.EventHandler(this.количествоАкционеровФирмУБрокераToolStripMenuItem_Click);
            // 
            // доляАкцийВсехФирмToolStripMenuItem
            // 
            this.доляАкцийВсехФирмToolStripMenuItem.Name = "доляАкцийВсехФирмToolStripMenuItem";
            this.доляАкцийВсехФирмToolStripMenuItem.Size = new System.Drawing.Size(379, 26);
            this.доляАкцийВсехФирмToolStripMenuItem.Text = "Доля акций всех фирм";
            this.доляАкцийВсехФирмToolStripMenuItem.Click += new System.EventHandler(this.доляАкцийВсехФирмToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(118, 26);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(67, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // брокерTableAdapter
            // 
            this.брокерTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 530);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewStockTable);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "БД акций";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab3DataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStockTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.акцииBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addNewStockButton;
        private System.Windows.Forms.TextBox textBoxCourseOfBuy;
        private System.Windows.Forms.Label labelCourseOfSell;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.Label labelCourseOfBuy;
        private System.Windows.Forms.TextBox textBoxCourseOfSell;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.TextBox textBoxFirm;
        private System.Windows.Forms.Label labelFirm;
        private System.Windows.Forms.DataGridView dataGridViewStockTable;
        private lab3DataSet lab3DataSet;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button updateStockButton;
        private System.Windows.Forms.TextBox textBoxEditCourseOfBuy;
        private System.Windows.Forms.Label labelCourseOfSellEdit;
        private System.Windows.Forms.TextBox textBoxEditCount;
        private System.Windows.Forms.Label labelCourseOfBuyEdit;
        private System.Windows.Forms.TextBox textBoxEditCourseOfSell;
        private System.Windows.Forms.Label labelCountEdit;
        private System.Windows.Forms.TextBox textBoxEditFirm;
        private System.Windows.Forms.Label labelFirmEdit;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource акцииBindingSource;
        private lab3DataSetTableAdapters.АкцииTableAdapter акцииTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn фирмаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem работаСБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчётыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортировкаФильтрацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem среднийКурсПокупкиИПродажиАкцийToolStripMenuItemОтчёты;
        private System.Windows.Forms.ToolStripMenuItem общееКоличествоАкцийФирмToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem диаграммыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem количествоАкционеровФирмУБрокераToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem доляАкцийВсехФирмToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem бДБрокераToolStripMenuItem;
        private lab3DataSetTableAdapters.БрокерTableAdapter брокерTableAdapter;
    }
}

