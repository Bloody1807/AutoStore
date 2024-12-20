namespace AutoStore
{
    partial class ServicesForm
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
            this.price_textBox = new System.Windows.Forms.TextBox();
            this.opis_textBox = new System.Windows.Forms.TextBox();
            this.data_textBox = new System.Windows.Forms.TextBox();
            this.autoid_textBox = new System.Windows.Forms.TextBox();
            this.color_label = new System.Windows.Forms.Label();
            this.year_label = new System.Windows.Forms.Label();
            this.model_label = new System.Windows.Forms.Label();
            this.marka_label = new System.Windows.Forms.Label();
            this.add_label = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.search_textbox = new System.Windows.Forms.TextBox();
            this.find_label = new System.Windows.Forms.Label();
            this.auto_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // refresh_button
            // 
            this.refresh_button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.refresh_button.Location = new System.Drawing.Point(693, 672);
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
            this.back_button.Location = new System.Drawing.Point(693, 708);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(124, 30);
            this.back_button.TabIndex = 50;
            this.back_button.Text = "Назад";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.backmenu_Click);
            // 
            // delete_Button
            // 
            this.delete_Button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete_Button.Location = new System.Drawing.Point(693, 606);
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
            this.save_Button.Location = new System.Drawing.Point(693, 570);
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
            this.refactor_Button.Location = new System.Drawing.Point(693, 534);
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
            this.new_record_Button.Location = new System.Drawing.Point(693, 498);
            this.new_record_Button.Name = "new_record_Button";
            this.new_record_Button.Size = new System.Drawing.Size(124, 30);
            this.new_record_Button.TabIndex = 46;
            this.new_record_Button.Text = "Новая запись";
            this.new_record_Button.UseVisualStyleBackColor = true;
            this.new_record_Button.Click += new System.EventHandler(this.new_record_Button_Click);
            // 
            // organize_label
            // 
            this.organize_label.AutoSize = true;
            this.organize_label.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.organize_label.Location = new System.Drawing.Point(701, 467);
            this.organize_label.Name = "organize_label";
            this.organize_label.Size = new System.Drawing.Size(103, 21);
            this.organize_label.TabIndex = 45;
            this.organize_label.Text = "Управление";
            // 
            // price_textBox
            // 
            this.price_textBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.price_textBox.Location = new System.Drawing.Point(180, 584);
            this.price_textBox.Name = "price_textBox";
            this.price_textBox.Size = new System.Drawing.Size(126, 22);
            this.price_textBox.TabIndex = 42;
            // 
            // opis_textBox
            // 
            this.opis_textBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.opis_textBox.Location = new System.Drawing.Point(180, 555);
            this.opis_textBox.Name = "opis_textBox";
            this.opis_textBox.Size = new System.Drawing.Size(126, 22);
            this.opis_textBox.TabIndex = 41;
            // 
            // data_textBox
            // 
            this.data_textBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.data_textBox.Location = new System.Drawing.Point(180, 526);
            this.data_textBox.Name = "data_textBox";
            this.data_textBox.Size = new System.Drawing.Size(126, 22);
            this.data_textBox.TabIndex = 40;
            // 
            // autoid_textBox
            // 
            this.autoid_textBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.autoid_textBox.Location = new System.Drawing.Point(180, 497);
            this.autoid_textBox.Name = "autoid_textBox";
            this.autoid_textBox.Size = new System.Drawing.Size(126, 22);
            this.autoid_textBox.TabIndex = 39;
            this.autoid_textBox.TextChanged += new System.EventHandler(this.autoid_textBox_TextChanged);
            // 
            // color_label
            // 
            this.color_label.AutoSize = true;
            this.color_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.color_label.Location = new System.Drawing.Point(46, 584);
            this.color_label.Name = "color_label";
            this.color_label.Size = new System.Drawing.Size(83, 19);
            this.color_label.TabIndex = 35;
            this.color_label.Text = "Стоимость";
            // 
            // year_label
            // 
            this.year_label.AutoSize = true;
            this.year_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.year_label.Location = new System.Drawing.Point(46, 555);
            this.year_label.Name = "year_label";
            this.year_label.Size = new System.Drawing.Size(78, 19);
            this.year_label.TabIndex = 34;
            this.year_label.Text = "Описание";
            // 
            // model_label
            // 
            this.model_label.AutoSize = true;
            this.model_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.model_label.Location = new System.Drawing.Point(46, 526);
            this.model_label.Name = "model_label";
            this.model_label.Size = new System.Drawing.Size(136, 19);
            this.model_label.TabIndex = 33;
            this.model_label.Text = "Дата облуживания";
            // 
            // marka_label
            // 
            this.marka_label.AutoSize = true;
            this.marka_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.marka_label.Location = new System.Drawing.Point(46, 498);
            this.marka_label.Name = "marka_label";
            this.marka_label.Size = new System.Drawing.Size(113, 19);
            this.marka_label.TabIndex = 32;
            this.marka_label.Text = "ID Автомобиля";
            this.marka_label.Click += new System.EventHandler(this.marka_label_Click);
            // 
            // add_label
            // 
            this.add_label.AutoSize = true;
            this.add_label.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_label.Location = new System.Drawing.Point(133, 467);
            this.add_label.Name = "add_label";
            this.add_label.Size = new System.Drawing.Size(66, 21);
            this.add_label.TabIndex = 31;
            this.add_label.Text = "Запись";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(23, 62);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(861, 402);
            this.dataGridView2.TabIndex = 30;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw2_CellClick);
            // 
            // search_textbox
            // 
            this.search_textbox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.search_textbox.Location = new System.Drawing.Point(662, 25);
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
            this.find_label.Location = new System.Drawing.Point(574, 28);
            this.find_label.Name = "find_label";
            this.find_label.Size = new System.Drawing.Size(54, 19);
            this.find_label.TabIndex = 28;
            this.find_label.Text = "Поиск:";
            // 
            // auto_label
            // 
            this.auto_label.BackColor = System.Drawing.SystemColors.Info;
            this.auto_label.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.auto_label.Location = new System.Drawing.Point(19, 14);
            this.auto_label.Name = "auto_label";
            this.auto_label.Size = new System.Drawing.Size(865, 45);
            this.auto_label.TabIndex = 27;
            this.auto_label.Text = "Сервисное обслуживание";
            this.auto_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ServicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 791);
            this.Controls.Add(this.refresh_button);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.delete_Button);
            this.Controls.Add(this.save_Button);
            this.Controls.Add(this.refactor_Button);
            this.Controls.Add(this.new_record_Button);
            this.Controls.Add(this.organize_label);
            this.Controls.Add(this.price_textBox);
            this.Controls.Add(this.opis_textBox);
            this.Controls.Add(this.data_textBox);
            this.Controls.Add(this.autoid_textBox);
            this.Controls.Add(this.color_label);
            this.Controls.Add(this.year_label);
            this.Controls.Add(this.model_label);
            this.Controls.Add(this.marka_label);
            this.Controls.Add(this.add_label);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.search_textbox);
            this.Controls.Add(this.find_label);
            this.Controls.Add(this.auto_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ServicesForm";
            this.Text = "ServicesForm";
            this.Load += new System.EventHandler(this.ServicesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
        private System.Windows.Forms.TextBox price_textBox;
        private System.Windows.Forms.TextBox opis_textBox;
        private System.Windows.Forms.TextBox data_textBox;
        private System.Windows.Forms.TextBox autoid_textBox;
        private System.Windows.Forms.Label color_label;
        private System.Windows.Forms.Label year_label;
        private System.Windows.Forms.Label model_label;
        private System.Windows.Forms.Label marka_label;
        private System.Windows.Forms.Label add_label;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox search_textbox;
        private System.Windows.Forms.Label find_label;
        private System.Windows.Forms.Label auto_label;
    }
}