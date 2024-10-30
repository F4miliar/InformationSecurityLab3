namespace InformationSecurityLab3
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
            this.comboBoxUserPick = new System.Windows.Forms.ComboBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.buttonUserEdit = new System.Windows.Forms.Button();
            this.listBoxObject = new System.Windows.Forms.ListBox();
            this.textBoxObjectEdit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBoxUserPick
            // 
            this.comboBoxUserPick.FormattingEnabled = true;
            this.comboBoxUserPick.Location = new System.Drawing.Point(212, 11);
            this.comboBoxUserPick.Name = "comboBoxUserPick";
            this.comboBoxUserPick.Size = new System.Drawing.Size(135, 24);
            this.comboBoxUserPick.TabIndex = 0;
            this.comboBoxUserPick.SelectedIndexChanged += new System.EventHandler(this.comboBoxUserPick_SelectedIndexChanged);
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUser.Location = new System.Drawing.Point(12, 9);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(158, 25);
            this.labelUser.TabIndex = 1;
            this.labelUser.Text = "Пользователь";
            // 
            // buttonUserEdit
            // 
            this.buttonUserEdit.Location = new System.Drawing.Point(415, 11);
            this.buttonUserEdit.Name = "buttonUserEdit";
            this.buttonUserEdit.Size = new System.Drawing.Size(225, 24);
            this.buttonUserEdit.TabIndex = 2;
            this.buttonUserEdit.Text = "Редактировать пользователя";
            this.buttonUserEdit.UseVisualStyleBackColor = true;
            // 
            // listBoxObject
            // 
            this.listBoxObject.FormattingEnabled = true;
            this.listBoxObject.ItemHeight = 16;
            this.listBoxObject.Location = new System.Drawing.Point(17, 48);
            this.listBoxObject.Name = "listBoxObject";
            this.listBoxObject.Size = new System.Drawing.Size(330, 260);
            this.listBoxObject.TabIndex = 3;
            this.listBoxObject.SelectedIndexChanged += new System.EventHandler(this.listBoxObject_SelectedIndexChanged);
            // 
            // textBoxObjectEdit
            // 
            this.textBoxObjectEdit.Location = new System.Drawing.Point(355, 48);
            this.textBoxObjectEdit.Multiline = true;
            this.textBoxObjectEdit.Name = "textBoxObjectEdit";
            this.textBoxObjectEdit.Size = new System.Drawing.Size(330, 260);
            this.textBoxObjectEdit.TabIndex = 4;
            this.textBoxObjectEdit.TextChanged += new System.EventHandler(this.textBoxObjectEdit_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 322);
            this.Controls.Add(this.textBoxObjectEdit);
            this.Controls.Add(this.listBoxObject);
            this.Controls.Add(this.buttonUserEdit);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.comboBoxUserPick);
            this.Name = "Form1";
            this.Text = "Матрица доступа (Выбор)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxUserPick;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Button buttonUserEdit;
        private System.Windows.Forms.ListBox listBoxObject;
        private System.Windows.Forms.TextBox textBoxObjectEdit;
    }
}

