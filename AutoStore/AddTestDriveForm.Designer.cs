namespace AutoStore
{
    partial class AddTestDriveForm
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
            this.date1_textBox = new System.Windows.Forms.TextBox();
            this.employeeid1_textBox = new System.Windows.Forms.TextBox();
            this.clientid1_textBox = new System.Windows.Forms.TextBox();
            this.autoid1_textBox = new System.Windows.Forms.TextBox();
            this.color_label = new System.Windows.Forms.Label();
            this.year_label = new System.Windows.Forms.Label();
            this.model_label = new System.Windows.Forms.Label();
            this.marka_label = new System.Windows.Forms.Label();
            this.add_label = new System.Windows.Forms.Label();
            this.save_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // date1_textBox
            // 
            this.date1_textBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date1_textBox.Location = new System.Drawing.Point(159, 189);
            this.date1_textBox.Name = "date1_textBox";
            this.date1_textBox.Size = new System.Drawing.Size(126, 22);
            this.date1_textBox.TabIndex = 51;
            // 
            // employeeid1_textBox
            // 
            this.employeeid1_textBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.employeeid1_textBox.Location = new System.Drawing.Point(159, 160);
            this.employeeid1_textBox.Name = "employeeid1_textBox";
            this.employeeid1_textBox.Size = new System.Drawing.Size(126, 22);
            this.employeeid1_textBox.TabIndex = 50;
            // 
            // clientid1_textBox
            // 
            this.clientid1_textBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientid1_textBox.Location = new System.Drawing.Point(159, 131);
            this.clientid1_textBox.Name = "clientid1_textBox";
            this.clientid1_textBox.Size = new System.Drawing.Size(126, 22);
            this.clientid1_textBox.TabIndex = 49;
            // 
            // autoid1_textBox
            // 
            this.autoid1_textBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.autoid1_textBox.Location = new System.Drawing.Point(159, 102);
            this.autoid1_textBox.Name = "autoid1_textBox";
            this.autoid1_textBox.Size = new System.Drawing.Size(126, 22);
            this.autoid1_textBox.TabIndex = 48;
            this.autoid1_textBox.TextChanged += new System.EventHandler(this.autoid_textBox_TextChanged);
            // 
            // color_label
            // 
            this.color_label.AutoSize = true;
            this.color_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.color_label.Location = new System.Drawing.Point(48, 190);
            this.color_label.Name = "color_label";
            this.color_label.Size = new System.Drawing.Size(97, 19);
            this.color_label.TabIndex = 47;
            this.color_label.Text = "Дата запроса";
            // 
            // year_label
            // 
            this.year_label.AutoSize = true;
            this.year_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.year_label.Location = new System.Drawing.Point(48, 161);
            this.year_label.Name = "year_label";
            this.year_label.Size = new System.Drawing.Size(109, 19);
            this.year_label.TabIndex = 46;
            this.year_label.Text = "ID Сотрудника";
            // 
            // model_label
            // 
            this.model_label.AutoSize = true;
            this.model_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.model_label.Location = new System.Drawing.Point(48, 132);
            this.model_label.Name = "model_label";
            this.model_label.Size = new System.Drawing.Size(87, 19);
            this.model_label.TabIndex = 45;
            this.model_label.Text = "ID Клиента";
            // 
            // marka_label
            // 
            this.marka_label.AutoSize = true;
            this.marka_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.marka_label.Location = new System.Drawing.Point(48, 103);
            this.marka_label.Name = "marka_label";
            this.marka_label.Size = new System.Drawing.Size(113, 19);
            this.marka_label.TabIndex = 44;
            this.marka_label.Text = "ID Автомобиля";
            // 
            // add_label
            // 
            this.add_label.AutoSize = true;
            this.add_label.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_label.Location = new System.Drawing.Point(130, 72);
            this.add_label.Name = "add_label";
            this.add_label.Size = new System.Drawing.Size(66, 21);
            this.add_label.TabIndex = 43;
            this.add_label.Text = "Запись";
            // 
            // save_Button
            // 
            this.save_Button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save_Button.Location = new System.Drawing.Point(96, 250);
            this.save_Button.Name = "save_Button";
            this.save_Button.Size = new System.Drawing.Size(124, 30);
            this.save_Button.TabIndex = 52;
            this.save_Button.Text = "Сохранить";
            this.save_Button.UseVisualStyleBackColor = true;
            this.save_Button.Click += new System.EventHandler(this.save_Click);
            // 
            // AddTestDriveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 385);
            this.Controls.Add(this.save_Button);
            this.Controls.Add(this.date1_textBox);
            this.Controls.Add(this.employeeid1_textBox);
            this.Controls.Add(this.clientid1_textBox);
            this.Controls.Add(this.autoid1_textBox);
            this.Controls.Add(this.color_label);
            this.Controls.Add(this.year_label);
            this.Controls.Add(this.model_label);
            this.Controls.Add(this.marka_label);
            this.Controls.Add(this.add_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddTestDriveForm";
            this.Text = "AddTestDriveForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox date1_textBox;
        private System.Windows.Forms.TextBox employeeid1_textBox;
        private System.Windows.Forms.TextBox clientid1_textBox;
        private System.Windows.Forms.TextBox autoid1_textBox;
        private System.Windows.Forms.Label color_label;
        private System.Windows.Forms.Label year_label;
        private System.Windows.Forms.Label model_label;
        private System.Windows.Forms.Label marka_label;
        private System.Windows.Forms.Label add_label;
        private System.Windows.Forms.Button save_Button;
    }
}