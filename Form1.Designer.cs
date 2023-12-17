namespace School
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
            this.subjectsComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OrderIdTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.servicesGridView = new System.Windows.Forms.DataGridView();
            this.ColumnServiceBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnServiceTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnServicePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // subjectsComboBox
            // 
            this.subjectsComboBox.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.subjectsComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subjectsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subjectsComboBox.FormattingEnabled = true;
            this.subjectsComboBox.Location = new System.Drawing.Point(124, 17);
            this.subjectsComboBox.Name = "subjectsComboBox";
            this.subjectsComboBox.Size = new System.Drawing.Size(248, 33);
            this.subjectsComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Предмет:";
            // 
            // OrderIdTextBox
            // 
            this.OrderIdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderIdTextBox.Location = new System.Drawing.Point(124, 85);
            this.OrderIdTextBox.Name = "OrderIdTextBox";
            this.OrderIdTextBox.Size = new System.Drawing.Size(247, 20);
            this.OrderIdTextBox.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.servicesGridView);
            this.groupBox1.Location = new System.Drawing.Point(17, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 273);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите услуги";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(124, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Найти";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // servicesGridView
            // 
            this.servicesGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.servicesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.servicesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnServiceBox,
            this.ColumnServiceTitle,
            this.ColumnServicePrice});
            this.servicesGridView.Location = new System.Drawing.Point(6, 19);
            this.servicesGridView.Name = "servicesGridView";
            this.servicesGridView.Size = new System.Drawing.Size(342, 248);
            this.servicesGridView.TabIndex = 0;
            // 
            // ColumnServiceBox
            // 
            this.ColumnServiceBox.DataPropertyName = "selected";
            this.ColumnServiceBox.Frozen = true;
            this.ColumnServiceBox.HeaderText = "";
            this.ColumnServiceBox.Name = "ColumnServiceBox";
            this.ColumnServiceBox.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnServiceBox.Width = 20;
            // 
            // ColumnServiceTitle
            // 
            this.ColumnServiceTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnServiceTitle.DataPropertyName = "subjectName";
            this.ColumnServiceTitle.HeaderText = "Наименование";
            this.ColumnServiceTitle.Name = "ColumnServiceTitle";
            this.ColumnServiceTitle.ReadOnly = true;
            this.ColumnServiceTitle.Width = 108;
            // 
            // ColumnServicePrice
            // 
            this.ColumnServicePrice.DataPropertyName = "price";
            this.ColumnServicePrice.HeaderText = "Стоимость";
            this.ColumnServicePrice.Name = "ColumnServicePrice";
            this.ColumnServicePrice.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.OrderIdTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.subjectsComboBox);
            this.MinimumSize = new System.Drawing.Size(400, 500);
            this.Name = "Form1";
            this.Text = "Создание заказа";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.servicesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox subjectsComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OrderIdTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView servicesGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnServiceBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnServiceTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnServicePrice;
    }
}

