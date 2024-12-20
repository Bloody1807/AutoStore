namespace AutoStore
{
    partial class ClientForm
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
            this.refresh_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.delete_Button = new System.Windows.Forms.Button();
            this.save_Button = new System.Windows.Forms.Button();
            this.refactor_Button = new System.Windows.Forms.Button();
            this.new_record_Button = new System.Windows.Forms.Button();
            this.organize_label = new System.Windows.Forms.Label();
            this.email_textBox = new System.Windows.Forms.TextBox();
            this.number_textBox = new System.Windows.Forms.TextBox();
            this.adress_textBox = new System.Windows.Forms.TextBox();
            this.middle_textBox = new System.Windows.Forms.TextBox();
            this.first_textBox = new System.Windows.Forms.TextBox();
            this.last_textBox = new System.Windows.Forms.TextBox();
            this.km_label = new System.Windows.Forms.Label();
            this.price_label = new System.Windows.Forms.Label();
            this.color_label = new System.Windows.Forms.Label();
            this.year_label = new System.Windows.Forms.Label();
            this.model_label = new System.Windows.Forms.Label();
            this.marka_label = new System.Windows.Forms.Label();
            this.add_label = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.search_textbox = new System.Windows.Forms.TextBox();
            this.find_label = new System.Windows.Forms.Label();
            this.auto_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // refresh_button
            // 
            this.refresh_button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.refresh_button.Location = new System.Drawing.Point(700, 674);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(124, 30);
            this.refresh_button.TabIndex = 51;
            this.refresh_button.Text = "Обновить";
            this.refresh_button.UseVisualStyleBackColor = true;
            this.refresh_button.Click += new System.EventHandler(this.refresh_Click);
            // 
            // back_button
            // 
            this.back_button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back_button.Location = new System.Drawing.Point(700, 710);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(124, 30);
            this.back_button.TabIndex = 50;
            this.back_button.Text = "Назад";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_Click);
            // 
            // delete_Button
            // 
            this.delete_Button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete_Button.Location = new System.Drawing.Point(700, 608);
            this.delete_Button.Name = "delete_Button";
            this.delete_Button.Size = new System.Drawing.Size(124, 30);
            this.delete_Button.TabIndex = 49;
            this.delete_Button.Text = "Удалить";
            this.delete_Button.UseVisualStyleBackColor = true;
            this.delete_Button.Click += new System.EventHandler(this.delete_Click);
            // 
            // save_Button
            // 
            this.save_Button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save_Button.Location = new System.Drawing.Point(700, 572);
            this.save_Button.Name = "save_Button";
            this.save_Button.Size = new System.Drawing.Size(124, 30);
            this.save_Button.TabIndex = 48;
            this.save_Button.Text = "Сохранить";
            this.save_Button.UseVisualStyleBackColor = true;
            this.save_Button.Click += new System.EventHandler(this.save_Click);
            // 
            // refactor_Button
            // 
            this.refactor_Button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.refactor_Button.Location = new System.Drawing.Point(700, 536);
            this.refactor_Button.Name = "refactor_Button";
            this.refactor_Button.Size = new System.Drawing.Size(124, 30);
            this.refactor_Button.TabIndex = 47;
            this.refactor_Button.Text = "Изменить";
            this.refactor_Button.UseVisualStyleBackColor = true;
            this.refactor_Button.Click += new System.EventHandler(this.refactor_Click);
            // 
            // new_record_Button
            // 
            this.new_record_Button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.new_record_Button.Location = new System.Drawing.Point(700, 500);
            this.new_record_Button.Name = "new_record_Button";
            this.new_record_Button.Size = new System.Drawing.Size(124, 30);
            this.new_record_Button.TabIndex = 46;
            this.new_record_Button.Text = "Новая запись";
            this.new_record_Button.UseVisualStyleBackColor = true;
            this.new_record_Button.Click += new System.EventHandler(this.new_record_Click);
            // 
            // organize_label
            // 
            this.organize_label.AutoSize = true;
            this.organize_label.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.organize_label.Location = new System.Drawing.Point(708, 469);
            this.organize_label.Name = "organize_label";
            this.organize_label.Size = new System.Drawing.Size(103, 21);
            this.organize_label.TabIndex = 45;
            this.organize_label.Text = "Управление";
            // 
            // email_textBox
            // 
            this.email_textBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.email_textBox.Location = new System.Drawing.Point(187, 647);
            this.email_textBox.Name = "email_textBox";
            this.email_textBox.Size = new System.Drawing.Size(126, 22);
            this.email_textBox.TabIndex = 44;
            // 
            // number_textBox
            // 
            this.number_textBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number_textBox.Location = new System.Drawing.Point(187, 616);
            this.number_textBox.Name = "number_textBox";
            this.number_textBox.Size = new System.Drawing.Size(126, 22);
            this.number_textBox.TabIndex = 43;
            // 
            // adress_textBox
            // 
            this.adress_textBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adress_textBox.Location = new System.Drawing.Point(187, 586);
            this.adress_textBox.Name = "adress_textBox";
            this.adress_textBox.Size = new System.Drawing.Size(126, 22);
            this.adress_textBox.TabIndex = 42;
            // 
            // middle_textBox
            // 
            this.middle_textBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.middle_textBox.Location = new System.Drawing.Point(187, 557);
            this.middle_textBox.Name = "middle_textBox";
            this.middle_textBox.Size = new System.Drawing.Size(126, 22);
            this.middle_textBox.TabIndex = 41;
            // 
            // first_textBox
            // 
            this.first_textBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.first_textBox.Location = new System.Drawing.Point(187, 528);
            this.first_textBox.Name = "first_textBox";
            this.first_textBox.Size = new System.Drawing.Size(126, 22);
            this.first_textBox.TabIndex = 40;
            // 
            // last_textBox
            // 
            this.last_textBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.last_textBox.Location = new System.Drawing.Point(187, 499);
            this.last_textBox.Name = "last_textBox";
            this.last_textBox.Size = new System.Drawing.Size(126, 22);
            this.last_textBox.TabIndex = 39;
            // 
            // km_label
            // 
            this.km_label.AutoSize = true;
            this.km_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.km_label.Location = new System.Drawing.Point(76, 617);
            this.km_label.Name = "km_label";
            this.km_label.Size = new System.Drawing.Size(65, 19);
            this.km_label.TabIndex = 37;
            this.km_label.Text = "Телефон";
            // 
            // price_label
            // 
            this.price_label.AutoSize = true;
            this.price_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.price_label.Location = new System.Drawing.Point(76, 648);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(50, 19);
            this.price_label.TabIndex = 36;
            this.price_label.Text = "Почта";
            // 
            // color_label
            // 
            this.color_label.AutoSize = true;
            this.color_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.color_label.Location = new System.Drawing.Point(76, 587);
            this.color_label.Name = "color_label";
            this.color_label.Size = new System.Drawing.Size(50, 19);
            this.color_label.TabIndex = 35;
            this.color_label.Text = "Адрес";
            // 
            // year_label
            // 
            this.year_label.AutoSize = true;
            this.year_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.year_label.Location = new System.Drawing.Point(76, 558);
            this.year_label.Name = "year_label";
            this.year_label.Size = new System.Drawing.Size(73, 19);
            this.year_label.TabIndex = 34;
            this.year_label.Text = "Отчество";
            // 
            // model_label
            // 
            this.model_label.AutoSize = true;
            this.model_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.model_label.Location = new System.Drawing.Point(76, 529);
            this.model_label.Name = "model_label";
            this.model_label.Size = new System.Drawing.Size(37, 19);
            this.model_label.TabIndex = 33;
            this.model_label.Text = "Имя";
            // 
            // marka_label
            // 
            this.marka_label.AutoSize = true;
            this.marka_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.marka_label.Location = new System.Drawing.Point(76, 500);
            this.marka_label.Name = "marka_label";
            this.marka_label.Size = new System.Drawing.Size(72, 19);
            this.marka_label.TabIndex = 32;
            this.marka_label.Text = "Фамилия";
            // 
            // add_label
            // 
            this.add_label.AutoSize = true;
            this.add_label.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_label.Location = new System.Drawing.Point(158, 469);
            this.add_label.Name = "add_label";
            this.add_label.Size = new System.Drawing.Size(66, 21);
            this.add_label.TabIndex = 31;
            this.add_label.Text = "Запись";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(30, 64);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(861, 402);
            this.dataGridView3.TabIndex = 30;
            this.dataGridView3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_cellClick);
            // 
            // search_textbox
            // 
            this.search_textbox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.search_textbox.Location = new System.Drawing.Point(669, 27);
            this.search_textbox.Name = "search_textbox";
            this.search_textbox.Size = new System.Drawing.Size(191, 26);
            this.search_textbox.TabIndex = 29;
            this.search_textbox.TextChanged += new System.EventHandler(this.search_textbox_TextChanged);
            // 
            // find_label
            // 
            this.find_label.AutoSize = true;
            this.find_label.BackColor = System.Drawing.SystemColors.Info;
            this.find_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.find_label.Location = new System.Drawing.Point(581, 30);
            this.find_label.Name = "find_label";
            this.find_label.Size = new System.Drawing.Size(54, 19);
            this.find_label.TabIndex = 28;
            this.find_label.Text = "Поиск:";
            // 
            // auto_label
            // 
            this.auto_label.BackColor = System.Drawing.SystemColors.Info;
            this.auto_label.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.auto_label.Location = new System.Drawing.Point(26, 16);
            this.auto_label.Name = "auto_label";
            this.auto_label.Size = new System.Drawing.Size(865, 45);
            this.auto_label.TabIndex = 27;
            this.auto_label.Text = "Клиенты";
            this.auto_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 755);
            this.Controls.Add(this.refresh_button);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.delete_Button);
            this.Controls.Add(this.save_Button);
            this.Controls.Add(this.refactor_Button);
            this.Controls.Add(this.new_record_Button);
            this.Controls.Add(this.organize_label);
            this.Controls.Add(this.email_textBox);
            this.Controls.Add(this.number_textBox);
            this.Controls.Add(this.adress_textBox);
            this.Controls.Add(this.middle_textBox);
            this.Controls.Add(this.first_textBox);
            this.Controls.Add(this.last_textBox);
            this.Controls.Add(this.km_label);
            this.Controls.Add(this.price_label);
            this.Controls.Add(this.color_label);
            this.Controls.Add(this.year_label);
            this.Controls.Add(this.model_label);
            this.Controls.Add(this.marka_label);
            this.Controls.Add(this.add_label);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.search_textbox);
            this.Controls.Add(this.find_label);
            this.Controls.Add(this.auto_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button refresh_button;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button delete_Button;
        private System.Windows.Forms.Button save_Button;
        private System.Windows.Forms.Button refactor_Button;
        private System.Windows.Forms.Button new_record_Button;
        private System.Windows.Forms.Label organize_label;
        private System.Windows.Forms.TextBox email_textBox;
        private System.Windows.Forms.TextBox number_textBox;
        private System.Windows.Forms.TextBox adress_textBox;
        private System.Windows.Forms.TextBox middle_textBox;
        private System.Windows.Forms.TextBox first_textBox;
        private System.Windows.Forms.TextBox last_textBox;
        private System.Windows.Forms.Label km_label;
        private System.Windows.Forms.Label price_label;
        private System.Windows.Forms.Label color_label;
        private System.Windows.Forms.Label year_label;
        private System.Windows.Forms.Label model_label;
        private System.Windows.Forms.Label marka_label;
        private System.Windows.Forms.Label add_label;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TextBox search_textbox;
        private System.Windows.Forms.Label find_label;
        private System.Windows.Forms.Label auto_label;
    }
}