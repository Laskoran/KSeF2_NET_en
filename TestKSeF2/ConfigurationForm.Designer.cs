namespace TestKSeF2
{
    partial class ConfigurationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            components = new System.ComponentModel.Container();
            okButton = new Button();
            label1 = new Label();
            dataGridView1 = new GbbLibWin.OurDataGridView();
            URL_BindingSource = new BindingSource(components);
            PublicKey_BindingSource = new BindingSource(components);
            configurationLineBindingSource = new BindingSource(components);
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nIPDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tokenDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            uRLDataGridViewTextBoxColumn = new GbbLibWin.OurDataGridViewComboBoxColumn2();
            publicKeyDataGridViewTextBoxColumn = new GbbLibWin.OurDataGridViewComboBoxColumn2();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)URL_BindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PublicKey_BindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)configurationLineBindingSource).BeginInit();
            SuspendLayout();
            // 
            // okButton
            // 
            okButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            okButton.DialogResult = DialogResult.Cancel;
            okButton.Location = new Point(821, 206);
            okButton.Margin = new Padding(4, 3, 4, 3);
            okButton.Name = "okButton";
            okButton.Size = new Size(88, 27);
            okButton.TabIndex = 24;
            okButton.Text = "&OK";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 10);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 25;
            label1.Text = "Konfiguracje:";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, nIPDataGridViewTextBoxColumn, tokenDataGridViewTextBoxColumn, uRLDataGridViewTextBoxColumn, publicKeyDataGridViewTextBoxColumn });
            dataGridView1.DataSource = configurationLineBindingSource;
            dataGridView1.Location = new Point(13, 28);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.OurPaste_BlockMultiLine = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(897, 172);
            dataGridView1.TabIndex = 26;
            // 
            // URL_BindingSource
            // 
            URL_BindingSource.DataSource = typeof(DropDownString);
            // 
            // PublicKey_BindingSource
            // 
            PublicKey_BindingSource.DataSource = typeof(DropDownString);
            // 
            // configurationLineBindingSource
            // 
            configurationLineBindingSource.DataSource = typeof(ConfigurationLine);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // nIPDataGridViewTextBoxColumn
            // 
            nIPDataGridViewTextBoxColumn.DataPropertyName = "NIP";
            nIPDataGridViewTextBoxColumn.HeaderText = "NIP";
            nIPDataGridViewTextBoxColumn.Name = "nIPDataGridViewTextBoxColumn";
            // 
            // tokenDataGridViewTextBoxColumn
            // 
            tokenDataGridViewTextBoxColumn.DataPropertyName = "Token";
            tokenDataGridViewTextBoxColumn.HeaderText = "Token";
            tokenDataGridViewTextBoxColumn.Name = "tokenDataGridViewTextBoxColumn";
            tokenDataGridViewTextBoxColumn.Width = 200;
            // 
            // uRLDataGridViewTextBoxColumn
            // 
            uRLDataGridViewTextBoxColumn.DataPropertyName = "URL";
            uRLDataGridViewTextBoxColumn.DataSource = URL_BindingSource;
            uRLDataGridViewTextBoxColumn.DisplayMember = "Name";
            uRLDataGridViewTextBoxColumn.HeaderText = "URL";
            uRLDataGridViewTextBoxColumn.Name = "uRLDataGridViewTextBoxColumn";
            uRLDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            uRLDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            uRLDataGridViewTextBoxColumn.ValueMember = "Value";
            uRLDataGridViewTextBoxColumn.Width = 200;
            // 
            // publicKeyDataGridViewTextBoxColumn
            // 
            publicKeyDataGridViewTextBoxColumn.DataPropertyName = "PublicKey";
            publicKeyDataGridViewTextBoxColumn.DataSource = PublicKey_BindingSource;
            publicKeyDataGridViewTextBoxColumn.DisplayMember = "Name";
            publicKeyDataGridViewTextBoxColumn.HeaderText = "PublicKey";
            publicKeyDataGridViewTextBoxColumn.Name = "publicKeyDataGridViewTextBoxColumn";
            publicKeyDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            publicKeyDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            publicKeyDataGridViewTextBoxColumn.ValueMember = "Value";
            publicKeyDataGridViewTextBoxColumn.Width = 200;
            // 
            // ConfigurationForm
            // 
            AcceptButton = okButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 246);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(okButton);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ConfigurationForm";
            Padding = new Padding(10);
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "ConfigurationForm";
            FormClosing += ConfigurationForm_FormClosing;
            Load += ConfigurationForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)URL_BindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)PublicKey_BindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)configurationLineBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button okButton;
        private Label label1;
        private GbbLibWin.OurDataGridView dataGridView1;
        private BindingSource configurationLineBindingSource;
        private BindingSource URL_BindingSource;
        private BindingSource PublicKey_BindingSource;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nIPDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tokenDataGridViewTextBoxColumn;
        private GbbLibWin.OurDataGridViewComboBoxColumn2 uRLDataGridViewTextBoxColumn;
        private GbbLibWin.OurDataGridViewComboBoxColumn2 publicKeyDataGridViewTextBoxColumn;
    }
}
