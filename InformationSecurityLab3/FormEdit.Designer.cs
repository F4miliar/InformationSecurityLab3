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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBoxUserPick = new System.Windows.Forms.ComboBox();
            this.comboBoxObjectPick = new System.Windows.Forms.ComboBox();
            this.buttonUserDelete = new System.Windows.Forms.Button();
            this.buttonObjectDelete = new System.Windows.Forms.Button();
            this.numericUpDownAccessPick = new System.Windows.Forms.NumericUpDown();
            this.buttonAccessPick = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAccessPick)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(12, 32);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(100, 20);
            this.textBoxUserName.TabIndex = 0;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(9, 9);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(103, 13);
            this.labelUserName.TabIndex = 1;
            this.labelUserName.Text = "Имя пользователя";
            // 
            // buttonUserAdd
            // 
            this.buttonUserAdd.Location = new System.Drawing.Point(13, 59);
            this.buttonUserAdd.Name = "buttonUserAdd";
            this.buttonUserAdd.Size = new System.Drawing.Size(99, 23);
            this.buttonUserAdd.TabIndex = 2;
            this.buttonUserAdd.Text = "Добавить";
            this.buttonUserAdd.UseVisualStyleBackColor = true;
            this.buttonUserAdd.Click += new System.EventHandler(this.buttonUserAdd_Click);
            // 
            // buttonObjectAdd
            // 
            this.buttonObjectAdd.Location = new System.Drawing.Point(139, 59);
            this.buttonObjectAdd.Name = "buttonObjectAdd";
            this.buttonObjectAdd.Size = new System.Drawing.Size(99, 23);
            this.buttonObjectAdd.TabIndex = 5;
            this.buttonObjectAdd.Text = "Добавить";
            this.buttonObjectAdd.UseVisualStyleBackColor = true;
            this.buttonObjectAdd.Click += new System.EventHandler(this.buttonObjectAdd_Click);
            // 
            // labelObjectName
            // 
            this.labelObjectName.AutoSize = true;
            this.labelObjectName.Location = new System.Drawing.Point(135, 9);
            this.labelObjectName.Name = "labelObjectName";
            this.labelObjectName.Size = new System.Drawing.Size(92, 13);
            this.labelObjectName.TabIndex = 4;
            this.labelObjectName.Text = "Название файла";
            // 
            // textBoxObjectName
            // 
            this.textBoxObjectName.Location = new System.Drawing.Point(138, 32);
            this.textBoxObjectName.Name = "textBoxObjectName";
            this.textBoxObjectName.Size = new System.Drawing.Size(100, 20);
            this.textBoxObjectName.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(225, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // comboBoxUserPick
            // 
            this.comboBoxUserPick.FormattingEnabled = true;
            this.comboBoxUserPick.Location = new System.Drawing.Point(13, 258);
            this.comboBoxUserPick.Name = "comboBoxUserPick";
            this.comboBoxUserPick.Size = new System.Drawing.Size(99, 21);
            this.comboBoxUserPick.TabIndex = 7;
            // 
            // comboBoxObjectPick
            // 
            this.comboBoxObjectPick.FormattingEnabled = true;
            this.comboBoxObjectPick.Location = new System.Drawing.Point(138, 257);
            this.comboBoxObjectPick.Name = "comboBoxObjectPick";
            this.comboBoxObjectPick.Size = new System.Drawing.Size(99, 21);
            this.comboBoxObjectPick.TabIndex = 8;
            // 
            // buttonUserDelete
            // 
            this.buttonUserDelete.Location = new System.Drawing.Point(12, 285);
            this.buttonUserDelete.Name = "buttonUserDelete";
            this.buttonUserDelete.Size = new System.Drawing.Size(99, 23);
            this.buttonUserDelete.TabIndex = 9;
            this.buttonUserDelete.Text = "Удалить";
            this.buttonUserDelete.UseVisualStyleBackColor = true;
            // 
            // buttonObjectDelete
            // 
            this.buttonObjectDelete.Location = new System.Drawing.Point(138, 285);
            this.buttonObjectDelete.Name = "buttonObjectDelete";
            this.buttonObjectDelete.Size = new System.Drawing.Size(99, 23);
            this.buttonObjectDelete.TabIndex = 10;
            this.buttonObjectDelete.Text = "Удалить";
            this.buttonObjectDelete.UseVisualStyleBackColor = true;
            // 
            // numericUpDownAccessPick
            // 
            this.numericUpDownAccessPick.Location = new System.Drawing.Point(13, 314);
            this.numericUpDownAccessPick.Name = "numericUpDownAccessPick";
            this.numericUpDownAccessPick.Size = new System.Drawing.Size(51, 20);
            this.numericUpDownAccessPick.TabIndex = 11;
            // 
            // buttonAccessPick
            // 
            this.buttonAccessPick.Location = new System.Drawing.Point(70, 314);
            this.buttonAccessPick.Name = "buttonAccessPick";
            this.buttonAccessPick.Size = new System.Drawing.Size(167, 23);
            this.buttonAccessPick.TabIndex = 12;
            this.buttonAccessPick.Text = "Добавить права";
            this.buttonAccessPick.UseVisualStyleBackColor = true;
            // 
            // FormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 344);
            this.Controls.Add(this.buttonAccessPick);
            this.Controls.Add(this.numericUpDownAccessPick);
            this.Controls.Add(this.buttonObjectDelete);
            this.Controls.Add(this.buttonUserDelete);
            this.Controls.Add(this.comboBoxObjectPick);
            this.Controls.Add(this.comboBoxUserPick);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonObjectAdd);
            this.Controls.Add(this.labelObjectName);
            this.Controls.Add(this.textBoxObjectName);
            this.Controls.Add(this.buttonUserAdd);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.textBoxUserName);
            this.Name = "FormEdit";
            this.Text = "FormEdit";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxUserPick;
        private System.Windows.Forms.ComboBox comboBoxObjectPick;
        private System.Windows.Forms.Button buttonUserDelete;
        private System.Windows.Forms.Button buttonObjectDelete;
        private System.Windows.Forms.NumericUpDown numericUpDownAccessPick;
        private System.Windows.Forms.Button buttonAccessPick;
    }
}