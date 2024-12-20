namespace AutoStore
{
    partial class AddUsersForm
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
            this.password1_textBox = new System.Windows.Forms.TextBox();
            this.login1_textBox = new System.Windows.Forms.TextBox();
            this.model_label = new System.Windows.Forms.Label();
            this.marka_label = new System.Windows.Forms.Label();
            this.add_label = new System.Windows.Forms.Label();
            this.save_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // password1_textBox
            // 
            this.password1_textBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password1_textBox.Location = new System.Drawing.Point(163, 206);
            this.password1_textBox.Name = "password1_textBox";
            this.password1_textBox.Size = new System.Drawing.Size(126, 22);
            this.password1_textBox.TabIndex = 67;
            // 
            // login1_textBox
            // 
            this.login1_textBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login1_textBox.Location = new System.Drawing.Point(163, 177);
            this.login1_textBox.Name = "login1_textBox";
            this.login1_textBox.Size = new System.Drawing.Size(126, 22);
            this.login1_textBox.TabIndex = 66;
            // 
            // model_label
            // 
            this.model_label.AutoSize = true;
            this.model_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.model_label.Location = new System.Drawing.Point(29, 206);
            this.model_label.Name = "model_label";
            this.model_label.Size = new System.Drawing.Size(58, 19);
            this.model_label.TabIndex = 65;
            this.model_label.Text = "Пароль";
            // 
            // marka_label
            // 
            this.marka_label.AutoSize = true;
            this.marka_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.marka_label.Location = new System.Drawing.Point(29, 178);
            this.marka_label.Name = "marka_label";
            this.marka_label.Size = new System.Drawing.Size(52, 19);
            this.marka_label.TabIndex = 64;
            this.marka_label.Text = "Логин";
            // 
            // add_label
            // 
            this.add_label.AutoSize = true;
            this.add_label.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_label.Location = new System.Drawing.Point(116, 147);
            this.add_label.Name = "add_label";
            this.add_label.Size = new System.Drawing.Size(66, 21);
            this.add_label.TabIndex = 63;
            this.add_label.Text = "Запись";
            // 
            // save_Button
            // 
            this.save_Button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save_Button.Location = new System.Drawing.Point(86, 260);
            this.save_Button.Name = "save_Button";
            this.save_Button.Size = new System.Drawing.Size(124, 30);
            this.save_Button.TabIndex = 69;
            this.save_Button.Text = "Сохранить";
            this.save_Button.UseVisualStyleBackColor = true;
            this.save_Button.Click += new System.EventHandler(this.save_Click);
            // 
            // AddUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 399);
            this.Controls.Add(this.save_Button);
            this.Controls.Add(this.password1_textBox);
            this.Controls.Add(this.login1_textBox);
            this.Controls.Add(this.model_label);
            this.Controls.Add(this.marka_label);
            this.Controls.Add(this.add_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddUsersForm";
            this.Text = "AddUsersForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox password1_textBox;
        private System.Windows.Forms.TextBox login1_textBox;
        private System.Windows.Forms.Label model_label;
        private System.Windows.Forms.Label marka_label;
        private System.Windows.Forms.Label add_label;
        private System.Windows.Forms.Button save_Button;
    }
}