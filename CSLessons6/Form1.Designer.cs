namespace CSLessons6
{
    partial class Form1
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
            this.textBoxBalance = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewEntries = new System.Windows.Forms.DataGridView();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpdate = new System.Windows.Forms.DateTimePicker();
            this.textBoxCategory = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEntries)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxBalance
            // 
            this.textBoxBalance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBalance.Location = new System.Drawing.Point(95, 549);
            this.textBoxBalance.Name = "textBoxBalance";
            this.textBoxBalance.ReadOnly = true;
            this.textBoxBalance.Size = new System.Drawing.Size(593, 22);
            this.textBoxBalance.TabIndex = 5;
            this.textBoxBalance.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 549);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Баланс";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataGridViewEntries
            // 
            this.dataGridViewEntries.AllowUserToAddRows = false;
            this.dataGridViewEntries.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewEntries.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewEntries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEntries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Type,
            this.Amount,
            this.Date,
            this.Description,
            this.Category});
            this.dataGridViewEntries.Location = new System.Drawing.Point(18, 268);
            this.dataGridViewEntries.Name = "dataGridViewEntries";
            this.dataGridViewEntries.RowTemplate.Height = 24;
            this.dataGridViewEntries.Size = new System.Drawing.Size(666, 264);
            this.dataGridViewEntries.TabIndex = 11;
            this.dataGridViewEntries.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEntries_CellValueChanged);
            // 
            // Type
            // 
            this.Type.HeaderText = "Тип записи";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Сумма";
            this.Amount.Name = "Amount";
            // 
            // Date
            // 
            this.Date.HeaderText = "Дата";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.HeaderText = "Описание";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Category
            // 
            this.Category.HeaderText = "Категория";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(18, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(666, 255);
            this.tabControl1.TabIndex = 12;
            this.tabControl1.UseWaitCursor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.dtpdate);
            this.tabPage1.Controls.Add(this.textBoxCategory);
            this.tabPage1.Controls.Add(this.textBoxDescription);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.buttonAdd);
            this.tabPage1.Controls.Add(this.textBoxAmount);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(658, 226);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Добавление";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.UseWaitCursor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(658, 226);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Фильтр";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Категория";
            this.label5.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Описание";
            this.label4.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Дата";
            this.label3.UseWaitCursor = true;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dtpdate
            // 
            this.dtpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpdate.Location = new System.Drawing.Point(120, 55);
            this.dtpdate.Name = "dtpdate";
            this.dtpdate.Size = new System.Drawing.Size(524, 22);
            this.dtpdate.TabIndex = 12;
            this.dtpdate.UseWaitCursor = true;
            // 
            // textBoxCategory
            // 
            this.textBoxCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCategory.Location = new System.Drawing.Point(120, 147);
            this.textBoxCategory.Name = "textBoxCategory";
            this.textBoxCategory.Size = new System.Drawing.Size(524, 22);
            this.textBoxCategory.TabIndex = 15;
            this.textBoxCategory.UseWaitCursor = true;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDescription.Location = new System.Drawing.Point(120, 101);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(524, 22);
            this.textBoxDescription.TabIndex = 13;
            this.textBoxDescription.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Сумма:";
            this.label1.UseWaitCursor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonAdd.Location = new System.Drawing.Point(538, 185);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(114, 33);
            this.buttonAdd.TabIndex = 16;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.UseWaitCursor = true;
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAmount.Location = new System.Drawing.Point(120, 10);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(524, 22);
            this.textBoxAmount.TabIndex = 11;
            this.textBoxAmount.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Описание";
            this.label6.UseWaitCursor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(122, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(326, 22);
            this.textBox1.TabIndex = 19;
            this.textBox1.UseWaitCursor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(524, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Фильтровать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(404, 197);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Сбросить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "полное совпадение",
            "совпадение справа",
            "совпадение слева",
            "любое вхождение",
            "искать по всем полям"});
            this.comboBox1.Location = new System.Drawing.Point(454, 15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(185, 24);
            this.comboBox1.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 544);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dataGridViewEntries);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxBalance);
            this.Name = "Form1";
            this.Text = "Менеджер доходов";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEntries)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxBalance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewEntries;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpdate;
        private System.Windows.Forms.TextBox textBoxCategory;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
    }
}

