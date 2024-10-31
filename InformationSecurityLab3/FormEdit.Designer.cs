namespace InformationSecurityLab3
{
    partial class FormEdit
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
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.buttonUserAdd = new System.Windows.Forms.Button();
            this.buttonObjectAdd = new System.Windows.Forms.Button();
            this.labelObjectName = new System.Windows.Forms.Label();
            this.textBoxObjectName = new System.Windows.Forms.TextBox();
            this.dataGridViewAccesses = new System.Windows.Forms.DataGridView();
            this.comboBoxUserPick = new System.Windows.Forms.ComboBox();
            this.comboBoxObjectPick = new System.Windows.Forms.ComboBox();
            this.buttonUserDelete = new System.Windows.Forms.Button();
            this.buttonObjectDelete = new System.Windows.Forms.Button();
            this.numericUpDownAccessPick = new System.Windows.Forms.NumericUpDown();
            this.buttonAccessAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccesses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAccessPick)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(16, 39);
            this.textBoxUserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(132, 22);
            this.textBoxUserName.TabIndex = 0;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(12, 11);
            this.labelUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(129, 16);
            this.labelUserName.TabIndex = 1;
            this.labelUserName.Text = "Имя пользователя";
            // 
            // buttonUserAdd
            // 
            this.buttonUserAdd.Location = new System.Drawing.Point(17, 73);
            this.buttonUserAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonUserAdd.Name = "buttonUserAdd";
            this.buttonUserAdd.Size = new System.Drawing.Size(132, 28);
            this.buttonUserAdd.TabIndex = 2;
            this.buttonUserAdd.Text = "Добавить";
            this.buttonUserAdd.UseVisualStyleBackColor = true;
            this.buttonUserAdd.Click += new System.EventHandler(this.buttonUserAdd_Click);
            // 
            // buttonObjectAdd
            // 
            this.buttonObjectAdd.Location = new System.Drawing.Point(185, 73);
            this.buttonObjectAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonObjectAdd.Name = "buttonObjectAdd";
            this.buttonObjectAdd.Size = new System.Drawing.Size(132, 28);
            this.buttonObjectAdd.TabIndex = 5;
            this.buttonObjectAdd.Text = "Добавить";
            this.buttonObjectAdd.UseVisualStyleBackColor = true;
            this.buttonObjectAdd.Click += new System.EventHandler(this.buttonObjectAdd_Click);
            // 
            // labelObjectName
            // 
            this.labelObjectName.AutoSize = true;
            this.labelObjectName.Location = new System.Drawing.Point(180, 11);
            this.labelObjectName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelObjectName.Name = "labelObjectName";
            this.labelObjectName.Size = new System.Drawing.Size(119, 16);
            this.labelObjectName.TabIndex = 4;
            this.labelObjectName.Text = "Название файла";
            // 
            // textBoxObjectName
            // 
            this.textBoxObjectName.Location = new System.Drawing.Point(184, 39);
            this.textBoxObjectName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxObjectName.Name = "textBoxObjectName";
            this.textBoxObjectName.Size = new System.Drawing.Size(132, 22);
            this.textBoxObjectName.TabIndex = 3;
            // 
            // dataGridViewAccesses
            // 
            this.dataGridViewAccesses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAccesses.Location = new System.Drawing.Point(17, 124);
            this.dataGridViewAccesses.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewAccesses.MultiSelect = false;
            this.dataGridViewAccesses.Name = "dataGridViewAccesses";
            this.dataGridViewAccesses.RowHeadersVisible = false;
            this.dataGridViewAccesses.RowHeadersWidth = 51;
            this.dataGridViewAccesses.Size = new System.Drawing.Size(300, 185);
            this.dataGridViewAccesses.TabIndex = 6;
            // 
            // comboBoxUserPick
            // 
            this.comboBoxUserPick.FormattingEnabled = true;
            this.comboBoxUserPick.Location = new System.Drawing.Point(17, 318);
            this.comboBoxUserPick.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxUserPick.Name = "comboBoxUserPick";
            this.comboBoxUserPick.Size = new System.Drawing.Size(131, 24);
            this.comboBoxUserPick.TabIndex = 7;
            // 
            // comboBoxObjectPick
            // 
            this.comboBoxObjectPick.FormattingEnabled = true;
            this.comboBoxObjectPick.Location = new System.Drawing.Point(184, 316);
            this.comboBoxObjectPick.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxObjectPick.Name = "comboBoxObjectPick";
            this.comboBoxObjectPick.Size = new System.Drawing.Size(131, 24);
            this.comboBoxObjectPick.TabIndex = 8;
            // 
            // buttonUserDelete
            // 
            this.buttonUserDelete.Location = new System.Drawing.Point(16, 351);
            this.buttonUserDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonUserDelete.Name = "buttonUserDelete";
            this.buttonUserDelete.Size = new System.Drawing.Size(132, 28);
            this.buttonUserDelete.TabIndex = 9;
            this.buttonUserDelete.Text = "Удалить";
            this.buttonUserDelete.UseVisualStyleBackColor = true;
            this.buttonUserDelete.Click += new System.EventHandler(this.buttonUserDelete_Click);
            // 
            // buttonObjectDelete
            // 
            this.buttonObjectDelete.Location = new System.Drawing.Point(184, 351);
            this.buttonObjectDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonObjectDelete.Name = "buttonObjectDelete";
            this.buttonObjectDelete.Size = new System.Drawing.Size(132, 28);
            this.buttonObjectDelete.TabIndex = 10;
            this.buttonObjectDelete.Text = "Удалить";
            this.buttonObjectDelete.UseVisualStyleBackColor = true;
            this.buttonObjectDelete.Click += new System.EventHandler(this.buttonObjectDelete_Click);
            // 
            // numericUpDownAccessPick
            // 
            this.numericUpDownAccessPick.Location = new System.Drawing.Point(17, 386);
            this.numericUpDownAccessPick.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDownAccessPick.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownAccessPick.Name = "numericUpDownAccessPick";
            this.numericUpDownAccessPick.Size = new System.Drawing.Size(68, 22);
            this.numericUpDownAccessPick.TabIndex = 11;
            // 
            // buttonAccessAdd
            // 
            this.buttonAccessAdd.Location = new System.Drawing.Point(93, 386);
            this.buttonAccessAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAccessAdd.Name = "buttonAccessAdd";
            this.buttonAccessAdd.Size = new System.Drawing.Size(223, 28);
            this.buttonAccessAdd.TabIndex = 12;
            this.buttonAccessAdd.Text = "Добавить права";
            this.buttonAccessAdd.UseVisualStyleBackColor = true;
            this.buttonAccessAdd.Click += new System.EventHandler(this.buttonAccessAdd_Click);
            // 
            // FormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 423);
            this.Controls.Add(this.buttonAccessAdd);
            this.Controls.Add(this.numericUpDownAccessPick);
            this.Controls.Add(this.buttonObjectDelete);
            this.Controls.Add(this.buttonUserDelete);
            this.Controls.Add(this.comboBoxObjectPick);
            this.Controls.Add(this.comboBoxUserPick);
            this.Controls.Add(this.dataGridViewAccesses);
            this.Controls.Add(this.buttonObjectAdd);
            this.Controls.Add(this.labelObjectName);
            this.Controls.Add(this.textBoxObjectName);
            this.Controls.Add(this.buttonUserAdd);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.textBoxUserName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormEdit";
            this.Text = "FormEdit";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccesses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAccessPick)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Button buttonUserAdd;
        private System.Windows.Forms.Button buttonObjectAdd;
        private System.Windows.Forms.Label labelObjectName;
        private System.Windows.Forms.TextBox textBoxObjectName;
        private System.Windows.Forms.DataGridView dataGridViewAccesses;
        private System.Windows.Forms.ComboBox comboBoxUserPick;
        private System.Windows.Forms.ComboBox comboBoxObjectPick;
        private System.Windows.Forms.Button buttonUserDelete;
        private System.Windows.Forms.Button buttonObjectDelete;
        private System.Windows.Forms.NumericUpDown numericUpDownAccessPick;
        private System.Windows.Forms.Button buttonAccessAdd;
    }
}