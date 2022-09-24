namespace lab3
{
    partial class WorkDatabaseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridViewStocksTable = new System.Windows.Forms.DataGridView();
            this.фирмаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.курспокупкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.курспродажиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.акцииBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.lab3DataSet = new lab3.lab3DataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.getTableAvgCountButton = new System.Windows.Forms.Button();
            this.getTableCalcButton = new System.Windows.Forms.Button();
            this.profitLabel = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.сортировкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фирмаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поУбываниюToolStripMenuItemФирма = new System.Windows.Forms.ToolStripMenuItem();
            this.поВозрастаниюToolStripMenuItemФирма = new System.Windows.Forms.ToolStripMenuItem();
            this.количествоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поУбываниюToolStripMenuItem1Количество = new System.Windows.Forms.ToolStripMenuItem();
            this.поВозрастаниюToolStripMenuItem1Количество = new System.Windows.Forms.ToolStripMenuItem();
            this.курсПокупкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поУбываниюToolStripMenuItem1КурсПокупки = new System.Windows.Forms.ToolStripMenuItem();
            this.поВозрастаниюToolStripMenuItem2КурсПокупки = new System.Windows.Forms.ToolStripMenuItem();
            this.курсПродажиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поУбываниюToolStripMenuItem1КурсПродажи = new System.Windows.Forms.ToolStripMenuItem();
            this.поВозрастаниюToolStripMenuItem2КурсПродажи = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.акцииTableAdapter = new lab3.lab3DataSetTableAdapters.АкцииTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxInputValue = new System.Windows.Forms.TextBox();
            this.listBoxSymbol = new System.Windows.Forms.ListBox();
            this.listBoxField = new System.Windows.Forms.ListBox();
            this.discardFilterButton = new System.Windows.Forms.Button();
            this.applyFilterButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStocksTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.акцииBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab3DataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewStocksTable
            // 
            this.dataGridViewStocksTable.AllowUserToAddRows = false;
            this.dataGridViewStocksTable.AllowUserToDeleteRows = false;
            this.dataGridViewStocksTable.AutoGenerateColumns = false;
            this.dataGridViewStocksTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStocksTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.фирмаDataGridViewTextBoxColumn,
            this.количествоDataGridViewTextBoxColumn,
            this.курспокупкиDataGridViewTextBoxColumn,
            this.курспродажиDataGridViewTextBoxColumn});
            this.dataGridViewStocksTable.DataSource = this.акцииBindingSource;
            this.dataGridViewStocksTable.Location = new System.Drawing.Point(12, 37);
            this.dataGridViewStocksTable.Name = "dataGridViewStocksTable";
            this.dataGridViewStocksTable.ReadOnly = true;
            this.dataGridViewStocksTable.RowHeadersWidth = 51;
            this.dataGridViewStocksTable.RowTemplate.Height = 24;
            this.dataGridViewStocksTable.Size = new System.Drawing.Size(749, 457);
            this.dataGridViewStocksTable.TabIndex = 0;
            this.dataGridViewStocksTable.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStocksTable_CellEnter);
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
            // курспокупкиDataGridViewTextBoxColumn
            // 
            this.курспокупкиDataGridViewTextBoxColumn.DataPropertyName = "Курс_покупки";
            this.курспокупкиDataGridViewTextBoxColumn.HeaderText = "Курс_покупки";
            this.курспокупкиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.курспокупкиDataGridViewTextBoxColumn.Name = "курспокупкиDataGridViewTextBoxColumn";
            this.курспокупкиDataGridViewTextBoxColumn.ReadOnly = true;
            this.курспокупкиDataGridViewTextBoxColumn.Width = 125;
            // 
            // курспродажиDataGridViewTextBoxColumn
            // 
            this.курспродажиDataGridViewTextBoxColumn.DataPropertyName = "Курс_продажи";
            this.курспродажиDataGridViewTextBoxColumn.HeaderText = "Курс_продажи";
            this.курспродажиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.курспродажиDataGridViewTextBoxColumn.Name = "курспродажиDataGridViewTextBoxColumn";
            this.курспродажиDataGridViewTextBoxColumn.ReadOnly = true;
            this.курспродажиDataGridViewTextBoxColumn.Width = 125;
            // 
            // акцииBindingSource
            // 
            this.акцииBindingSource.DataMember = "Акции";
            this.акцииBindingSource.DataSource = this.bindingSource2;
            this.акцииBindingSource.Filter = "";
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataSource = this.lab3DataSet;
            this.bindingSource2.Filter = "";
            this.bindingSource2.Position = 0;
            // 
            // lab3DataSet
            // 
            this.lab3DataSet.DataSetName = "lab3DataSet";
            this.lab3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.getTableAvgCountButton);
            this.groupBox1.Controls.Add(this.getTableCalcButton);
            this.groupBox1.Controls.Add(this.profitLabel);
            this.groupBox1.Location = new System.Drawing.Point(769, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 204);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вычисления";
            // 
            // getTableAvgCountButton
            // 
            this.getTableAvgCountButton.Location = new System.Drawing.Point(16, 134);
            this.getTableAvgCountButton.Name = "getTableAvgCountButton";
            this.getTableAvgCountButton.Size = new System.Drawing.Size(139, 62);
            this.getTableAvgCountButton.TabIndex = 5;
            this.getTableAvgCountButton.Text = "Среднее количество акций всех фирм";
            this.getTableAvgCountButton.UseVisualStyleBackColor = true;
            this.getTableAvgCountButton.Click += new System.EventHandler(this.getTableAvgCountButton_Click);
            // 
            // getTableCalcButton
            // 
            this.getTableCalcButton.Location = new System.Drawing.Point(16, 80);
            this.getTableCalcButton.Name = "getTableCalcButton";
            this.getTableCalcButton.Size = new System.Drawing.Size(139, 48);
            this.getTableCalcButton.TabIndex = 5;
            this.getTableCalcButton.Text = "Вывод записей по формуле";
            this.getTableCalcButton.UseVisualStyleBackColor = true;
            this.getTableCalcButton.Click += new System.EventHandler(this.getTableCalcButton_Click);
            // 
            // profitLabel
            // 
            this.profitLabel.AutoSize = true;
            this.profitLabel.Location = new System.Drawing.Point(13, 34);
            this.profitLabel.Name = "profitLabel";
            this.profitLabel.Size = new System.Drawing.Size(282, 16);
            this.profitLabel.TabIndex = 4;
            this.profitLabel.Text = "Прибыль при продаже акций: Записей нет";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(1029, 459);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(90, 35);
            this.updateButton.TabIndex = 4;
            this.updateButton.Text = "Обновить";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сортировкаToolStripMenuItem,
            this.закрытьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1131, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // сортировкаToolStripMenuItem
            // 
            this.сортировкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.фирмаToolStripMenuItem,
            this.количествоToolStripMenuItem,
            this.курсПокупкиToolStripMenuItem,
            this.курсПродажиToolStripMenuItem});
            this.сортировкаToolStripMenuItem.Name = "сортировкаToolStripMenuItem";
            this.сортировкаToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.сортировкаToolStripMenuItem.Text = "Сортировка";
            // 
            // фирмаToolStripMenuItem
            // 
            this.фирмаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поУбываниюToolStripMenuItemФирма,
            this.поВозрастаниюToolStripMenuItemФирма});
            this.фирмаToolStripMenuItem.Name = "фирмаToolStripMenuItem";
            this.фирмаToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.фирмаToolStripMenuItem.Text = "Фирма";
            // 
            // поУбываниюToolStripMenuItemФирма
            // 
            this.поУбываниюToolStripMenuItemФирма.Name = "поУбываниюToolStripMenuItemФирма";
            this.поУбываниюToolStripMenuItemФирма.Size = new System.Drawing.Size(208, 26);
            this.поУбываниюToolStripMenuItemФирма.Text = "По убыванию";
            this.поУбываниюToolStripMenuItemФирма.Click += new System.EventHandler(this.поУбываниюToolStripMenuItemФирма_Click);
            // 
            // поВозрастаниюToolStripMenuItemФирма
            // 
            this.поВозрастаниюToolStripMenuItemФирма.Name = "поВозрастаниюToolStripMenuItemФирма";
            this.поВозрастаниюToolStripMenuItemФирма.Size = new System.Drawing.Size(208, 26);
            this.поВозрастаниюToolStripMenuItemФирма.Text = "По возрастанию";
            this.поВозрастаниюToolStripMenuItemФирма.Click += new System.EventHandler(this.поВозрастаниюToolStripMenuItemФирма_Click);
            // 
            // количествоToolStripMenuItem
            // 
            this.количествоToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поУбываниюToolStripMenuItem1Количество,
            this.поВозрастаниюToolStripMenuItem1Количество});
            this.количествоToolStripMenuItem.Name = "количествоToolStripMenuItem";
            this.количествоToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.количествоToolStripMenuItem.Text = "Количество";
            // 
            // поУбываниюToolStripMenuItem1Количество
            // 
            this.поУбываниюToolStripMenuItem1Количество.Name = "поУбываниюToolStripMenuItem1Количество";
            this.поУбываниюToolStripMenuItem1Количество.Size = new System.Drawing.Size(208, 26);
            this.поУбываниюToolStripMenuItem1Количество.Text = "По убыванию";
            this.поУбываниюToolStripMenuItem1Количество.Click += new System.EventHandler(this.поУбываниюToolStripMenuItem1Количество_Click);
            // 
            // поВозрастаниюToolStripMenuItem1Количество
            // 
            this.поВозрастаниюToolStripMenuItem1Количество.Name = "поВозрастаниюToolStripMenuItem1Количество";
            this.поВозрастаниюToolStripMenuItem1Количество.Size = new System.Drawing.Size(208, 26);
            this.поВозрастаниюToolStripMenuItem1Количество.Text = "По возрастанию";
            this.поВозрастаниюToolStripMenuItem1Количество.Click += new System.EventHandler(this.поВозрастаниюToolStripMenuItem1Количество_Click);
            // 
            // курсПокупкиToolStripMenuItem
            // 
            this.курсПокупкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поУбываниюToolStripMenuItem1КурсПокупки,
            this.поВозрастаниюToolStripMenuItem2КурсПокупки});
            this.курсПокупкиToolStripMenuItem.Name = "курсПокупкиToolStripMenuItem";
            this.курсПокупкиToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.курсПокупкиToolStripMenuItem.Text = "Курс покупки";
            // 
            // поУбываниюToolStripMenuItem1КурсПокупки
            // 
            this.поУбываниюToolStripMenuItem1КурсПокупки.Name = "поУбываниюToolStripMenuItem1КурсПокупки";
            this.поУбываниюToolStripMenuItem1КурсПокупки.Size = new System.Drawing.Size(208, 26);
            this.поУбываниюToolStripMenuItem1КурсПокупки.Text = "По убыванию";
            this.поУбываниюToolStripMenuItem1КурсПокупки.Click += new System.EventHandler(this.поУбываниюToolStripMenuItem1КурсПокупки_Click);
            // 
            // поВозрастаниюToolStripMenuItem2КурсПокупки
            // 
            this.поВозрастаниюToolStripMenuItem2КурсПокупки.Name = "поВозрастаниюToolStripMenuItem2КурсПокупки";
            this.поВозрастаниюToolStripMenuItem2КурсПокупки.Size = new System.Drawing.Size(208, 26);
            this.поВозрастаниюToolStripMenuItem2КурсПокупки.Text = "По возрастанию";
            this.поВозрастаниюToolStripMenuItem2КурсПокупки.Click += new System.EventHandler(this.поВозрастаниюToolStripMenuItem2КурсПокупки_Click);
            // 
            // курсПродажиToolStripMenuItem
            // 
            this.курсПродажиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поУбываниюToolStripMenuItem1КурсПродажи,
            this.поВозрастаниюToolStripMenuItem2КурсПродажи});
            this.курсПродажиToolStripMenuItem.Name = "курсПродажиToolStripMenuItem";
            this.курсПродажиToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.курсПродажиToolStripMenuItem.Text = "Курс продажи";
            // 
            // поУбываниюToolStripMenuItem1КурсПродажи
            // 
            this.поУбываниюToolStripMenuItem1КурсПродажи.Name = "поУбываниюToolStripMenuItem1КурсПродажи";
            this.поУбываниюToolStripMenuItem1КурсПродажи.Size = new System.Drawing.Size(208, 26);
            this.поУбываниюToolStripMenuItem1КурсПродажи.Text = "По убыванию";
            this.поУбываниюToolStripMenuItem1КурсПродажи.Click += new System.EventHandler(this.поУбываниюToolStripMenuItem1КурсПродажи_Click);
            // 
            // поВозрастаниюToolStripMenuItem2КурсПродажи
            // 
            this.поВозрастаниюToolStripMenuItem2КурсПродажи.Name = "поВозрастаниюToolStripMenuItem2КурсПродажи";
            this.поВозрастаниюToolStripMenuItem2КурсПродажи.Size = new System.Drawing.Size(208, 26);
            this.поВозрастаниюToolStripMenuItem2КурсПродажи.Text = "По возрастанию";
            this.поВозрастаниюToolStripMenuItem2КурсПродажи.Click += new System.EventHandler(this.поВозрастаниюToolStripMenuItem2КурсПродажи_Click);
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // акцииTableAdapter
            // 
            this.акцииTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBoxInputValue);
            this.groupBox2.Controls.Add(this.listBoxSymbol);
            this.groupBox2.Controls.Add(this.listBoxField);
            this.groupBox2.Controls.Add(this.discardFilterButton);
            this.groupBox2.Controls.Add(this.applyFilterButton);
            this.groupBox2.Location = new System.Drawing.Point(769, 260);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 180);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Фильтрация";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Поле";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Операция";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Значение";
            // 
            // textBoxInputValue
            // 
            this.textBoxInputValue.Location = new System.Drawing.Point(226, 74);
            this.textBoxInputValue.Name = "textBoxInputValue";
            this.textBoxInputValue.Size = new System.Drawing.Size(118, 22);
            this.textBoxInputValue.TabIndex = 4;
            // 
            // listBoxSymbol
            // 
            this.listBoxSymbol.FormattingEnabled = true;
            this.listBoxSymbol.ItemHeight = 16;
            this.listBoxSymbol.Items.AddRange(new object[] {
            "<",
            ">",
            "="});
            this.listBoxSymbol.Location = new System.Drawing.Point(123, 58);
            this.listBoxSymbol.Name = "listBoxSymbol";
            this.listBoxSymbol.Size = new System.Drawing.Size(97, 52);
            this.listBoxSymbol.TabIndex = 3;
            // 
            // listBoxField
            // 
            this.listBoxField.FormattingEnabled = true;
            this.listBoxField.ItemHeight = 16;
            this.listBoxField.Items.AddRange(new object[] {
            "Фирма",
            "Количество",
            "Курс покупки",
            "Курс продажи"});
            this.listBoxField.Location = new System.Drawing.Point(6, 50);
            this.listBoxField.Name = "listBoxField";
            this.listBoxField.Size = new System.Drawing.Size(111, 68);
            this.listBoxField.TabIndex = 2;
            // 
            // discardFilterButton
            // 
            this.discardFilterButton.Location = new System.Drawing.Point(109, 138);
            this.discardFilterButton.Name = "discardFilterButton";
            this.discardFilterButton.Size = new System.Drawing.Size(97, 34);
            this.discardFilterButton.TabIndex = 1;
            this.discardFilterButton.Text = "Отменить";
            this.discardFilterButton.UseVisualStyleBackColor = true;
            this.discardFilterButton.Click += new System.EventHandler(this.discardFilterButton_Click);
            // 
            // applyFilterButton
            // 
            this.applyFilterButton.Location = new System.Drawing.Point(6, 138);
            this.applyFilterButton.Name = "applyFilterButton";
            this.applyFilterButton.Size = new System.Drawing.Size(97, 34);
            this.applyFilterButton.TabIndex = 0;
            this.applyFilterButton.Text = "Применить";
            this.applyFilterButton.UseVisualStyleBackColor = true;
            this.applyFilterButton.Click += new System.EventHandler(this.applyFilterButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 506);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewStocksTable);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Сортировка и фильтрация БД";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStocksTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.акцииBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab3DataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStocksTable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label profitLabel;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button getTableAvgCountButton;
        private System.Windows.Forms.Button getTableCalcButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem сортировкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem курсПокупкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поУбываниюToolStripMenuItem1КурсПокупки;
        private System.Windows.Forms.ToolStripMenuItem поВозрастаниюToolStripMenuItem2КурсПокупки;
        private System.Windows.Forms.ToolStripMenuItem курсПродажиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поУбываниюToolStripMenuItem1КурсПродажи;
        private System.Windows.Forms.ToolStripMenuItem поВозрастаниюToolStripMenuItem2КурсПродажи;
        private lab3DataSet lab3DataSet;
        private System.Windows.Forms.BindingSource акцииBindingSource;
        private lab3DataSetTableAdapters.АкцииTableAdapter акцииTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фирмаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поУбываниюToolStripMenuItemФирма;
        private System.Windows.Forms.ToolStripMenuItem поВозрастаниюToolStripMenuItemФирма;
        private System.Windows.Forms.ToolStripMenuItem количествоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поУбываниюToolStripMenuItem1Количество;
        private System.Windows.Forms.ToolStripMenuItem поВозрастаниюToolStripMenuItem1Количество;
        private System.Windows.Forms.DataGridViewTextBoxColumn фирмаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn курспокупкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn курспродажиDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button discardFilterButton;
        private System.Windows.Forms.Button applyFilterButton;
        private System.Windows.Forms.ListBox listBoxField;
        private System.Windows.Forms.ListBox listBoxSymbol;
        private System.Windows.Forms.TextBox textBoxInputValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}