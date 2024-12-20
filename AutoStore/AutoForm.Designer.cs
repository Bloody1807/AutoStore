namespace AutoStore
{
    partial class AutoForm
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
            this.auto_label = new System.Windows.Forms.Label();
            this.find_label = new System.Windows.Forms.Label();
            this.search_textbox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.add_label = new System.Windows.Forms.Label();
            this.marka_label = new System.Windows.Forms.Label();
            this.model_label = new System.Windows.Forms.Label();
            this.year_label = new System.Windows.Forms.Label();
            this.color_label = new System.Windows.Forms.Label();
            this.price_label = new System.Windows.Forms.Label();
            this.km_label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.marka_textBox = new System.Windows.Forms.TextBox();
            this.model_textBox = new System.Windows.Forms.TextBox();
            this.year_textBox = new System.Windows.Forms.TextBox();
            this.color_textBox = new System.Windows.Forms.TextBox();
            this.km_textBox = new System.Windows.Forms.TextBox();
            this.price_textBox = new System.Windows.Forms.TextBox();
            this.organize_label = new System.Windows.Forms.Label();
            this.new_record_Button = new System.Windows.Forms.Button();
            this.refactor_Button = new System.Windows.Forms.Button();
            this.save_Button = new System.Windows.Forms.Button();
            this.delete_Button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.refresh_button = new System.Windows.Forms.Button();
            this.provider_textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // auto_label
            // 
            this.auto_label.BackColor = System.Drawing.SystemColors.Info;
            this.auto_label.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.auto_label.Location = new System.Drawing.Point(12, 9);
            this.auto_label.Name = "auto_label";
            this.auto_label.Size = new System.Drawing.Size(865, 45);
            this.auto_label.TabIndex = 0;
            this.auto_label.Text = "Автомобили";
            this.auto_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.auto_label.Click += new System.EventHandler(this.auto_label_Click);
            // 
            // find_label
            // 
            this.find_label.AutoSize = true;
            this.find_label.BackColor = System.Drawing.SystemColors.Info;
            this.find_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.find_label.Location = new System.Drawing.Point(567, 23);
            this.find_label.Name = "find_label";
            this.find_label.Size = new System.Drawing.Size(54, 19);
            this.find_label.TabIndex = 1;
            this.find_label.Text = "Поиск:";
            this.find_label.Click += new System.EventHandler(this.find_label_Click);
            // 
            // search_textbox
            // 
            this.search_textbox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.search_textbox.Location = new System.Drawing.Point(655, 20);
            this.search_textbox.Name = "search_textbox";
            this.search_textbox.Size = new System.Drawing.Size(191, 26);
            this.search_textbox.TabIndex = 2;
            this.search_textbox.TextChanged += new System.EventHandler(this.search_textbox_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(861, 402);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // add_label
            // 
            this.add_label.AutoSize = true;
            this.add_label.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_label.Location = new System.Drawing.Point(144, 462);
            this.add_label.Name = "add_label";
            this.add_label.Size = new System.Drawing.Size(66, 21);
            this.add_label.TabIndex = 4;
            this.add_label.Text = "Запись";
            this.add_label.Click += new System.EventHandler(this.add_label_Click);
            // 
            // marka_label
            // 
            this.marka_label.AutoSize = true;
            this.marka_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.marka_label.Location = new System.Drawing.Point(62, 493);
            this.marka_label.Name = "marka_label";
            this.marka_label.Size = new System.Drawing.Size(52, 19);
            this.marka_label.TabIndex = 5;
            this.marka_label.Text = "Марка";
            this.marka_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // model_label
            // 
            this.model_label.AutoSize = true;
            this.model_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.model_label.Location = new System.Drawing.Point(62, 522);
            this.model_label.Name = "model_label";
            this.model_label.Size = new System.Drawing.Size(61, 19);
            this.model_label.TabIndex = 6;
            this.model_label.Text = "Модель";
            this.model_label.Click += new System.EventHandler(this.model_label_Click);
            // 
            // year_label
            // 
            this.year_label.AutoSize = true;
            this.year_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.year_label.Location = new System.Drawing.Point(62, 551);
            this.year_label.Name = "year_label";
            this.year_label.Size = new System.Drawing.Size(93, 19);
            this.year_label.TabIndex = 7;
            this.year_label.Text = "Год выпуска";
            this.year_label.Click += new System.EventHandler(this.year_label_Click);
            // 
            // color_label
            // 
            this.color_label.AutoSize = true;
            this.color_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.color_label.Location = new System.Drawing.Point(62, 580);
            this.color_label.Name = "color_label";
            this.color_label.Size = new System.Drawing.Size(42, 19);
            this.color_label.TabIndex = 8;
            this.color_label.Text = "Цвет";
            this.color_label.Click += new System.EventHandler(this.color_label_Click);
            // 
            // price_label
            // 
            this.price_label.AutoSize = true;
            this.price_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.price_label.Location = new System.Drawing.Point(62, 641);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(43, 19);
            this.price_label.TabIndex = 9;
            this.price_label.Text = "Цена";
            this.price_label.Click += new System.EventHandler(this.price_label_Click);
            // 
            // km_label
            // 
            this.km_label.AutoSize = true;
            this.km_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.km_label.Location = new System.Drawing.Point(62, 610);
            this.km_label.Name = "km_label";
            this.km_label.Size = new System.Drawing.Size(57, 19);
            this.km_label.TabIndex = 10;
            this.km_label.Text = "Пробег";
            this.km_label.Click += new System.EventHandler(this.km_label_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(62, 670);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Поставщик";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // marka_textBox
            // 
            this.marka_textBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.marka_textBox.Location = new System.Drawing.Point(173, 492);
            this.marka_textBox.Name = "marka_textBox";
            this.marka_textBox.Size = new System.Drawing.Size(126, 22);
            this.marka_textBox.TabIndex = 12;
            this.marka_textBox.TextChanged += new System.EventHandler(this.marka_textBox_TextChanged);
            // 
            // model_textBox
            // 
            this.model_textBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.model_textBox.Location = new System.Drawing.Point(173, 521);
            this.model_textBox.Name = "model_textBox";
            this.model_textBox.Size = new System.Drawing.Size(126, 22);
            this.model_textBox.TabIndex = 13;
            this.model_textBox.TextChanged += new System.EventHandler(this.model_textBox_TextChanged);
            // 
            // year_textBox
            // 
            this.year_textBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.year_textBox.Location = new System.Drawing.Point(173, 550);
            this.year_textBox.Name = "year_textBox";
            this.year_textBox.Size = new System.Drawing.Size(126, 22);
            this.year_textBox.TabIndex = 14;
            this.year_textBox.TextChanged += new System.EventHandler(this.year_textBox_TextChanged);
            // 
            // color_textBox
            // 
            this.color_textBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.color_textBox.Location = new System.Drawing.Point(173, 579);
            this.color_textBox.Name = "color_textBox";
            this.color_textBox.Size = new System.Drawing.Size(126, 22);
            this.color_textBox.TabIndex = 15;
            this.color_textBox.TextChanged += new System.EventHandler(this.color_textBox_TextChanged);
            // 
            // km_textBox
            // 
            this.km_textBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.km_textBox.Location = new System.Drawing.Point(173, 609);
            this.km_textBox.Name = "km_textBox";
            this.km_textBox.Size = new System.Drawing.Size(126, 22);
            this.km_textBox.TabIndex = 16;
            this.km_textBox.TextChanged += new System.EventHandler(this.km_textBox_TextChanged);
            // 
            // price_textBox
            // 
            this.price_textBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.price_textBox.Location = new System.Drawing.Point(173, 640);
            this.price_textBox.Name = "price_textBox";
            this.price_textBox.Size = new System.Drawing.Size(126, 22);
            this.price_textBox.TabIndex = 17;
            this.price_textBox.TextChanged += new System.EventHandler(this.price_textBox_TextChanged);
            // 
            // organize_label
            // 
            this.organize_label.AutoSize = true;
            this.organize_label.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.organize_label.Location = new System.Drawing.Point(694, 462);
            this.organize_label.Name = "organize_label";
            this.organize_label.Size = new System.Drawing.Size(103, 21);
            this.organize_label.TabIndex = 19;
            this.organize_label.Text = "Управление";
            this.organize_label.Click += new System.EventHandler(this.organize_label_Click);
            // 
            // new_record_Button
            // 
            this.new_record_Button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.new_record_Button.Location = new System.Drawing.Point(686, 493);
            this.new_record_Button.Name = "new_record_Button";
            this.new_record_Button.Size = new System.Drawing.Size(124, 30);
            this.new_record_Button.TabIndex = 20;
            this.new_record_Button.Text = "Новая запись";
            this.new_record_Button.UseVisualStyleBackColor = true;
            this.new_record_Button.Click += new System.EventHandler(this.new_record_Click);
            // 
            // refactor_Button
            // 
            this.refactor_Button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.refactor_Button.Location = new System.Drawing.Point(686, 529);
            this.refactor_Button.Name = "refactor_Button";
            this.refactor_Button.Size = new System.Drawing.Size(124, 30);
            this.refactor_Button.TabIndex = 21;
            this.refactor_Button.Text = "Изменить";
            this.refactor_Button.UseVisualStyleBackColor = true;
            this.refactor_Button.Click += new System.EventHandler(this.refactor_Click);
            // 
            // save_Button
            // 
            this.save_Button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save_Button.Location = new System.Drawing.Point(686, 565);
            this.save_Button.Name = "save_Button";
            this.save_Button.Size = new System.Drawing.Size(124, 30);
            this.save_Button.TabIndex = 22;
            this.save_Button.Text = "Сохранить";
            this.save_Button.UseVisualStyleBackColor = true;
            this.save_Button.Click += new System.EventHandler(this.save_Click);
            // 
            // delete_Button
            // 
            this.delete_Button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete_Button.Location = new System.Drawing.Point(686, 601);
            this.delete_Button.Name = "delete_Button";
            this.delete_Button.Size = new System.Drawing.Size(124, 30);
            this.delete_Button.TabIndex = 23;
            this.delete_Button.Text = "Удалить";
            this.delete_Button.UseVisualStyleBackColor = true;
            this.delete_Button.Click += new System.EventHandler(this.delete_Click);
            // 
            // back_button
            // 
            this.back_button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back_button.Location = new System.Drawing.Point(686, 703);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(124, 30);
            this.back_button.TabIndex = 24;
            this.back_button.Text = "Назад";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_Click);
            // 
            // refresh_button
            // 
            this.refresh_button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.refresh_button.Location = new System.Drawing.Point(686, 667);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(124, 30);
            this.refresh_button.TabIndex = 25;
            this.refresh_button.Text = "Обновить";
            this.refresh_button.UseVisualStyleBackColor = true;
            this.refresh_button.Click += new System.EventHandler(this.refresh_button_Click);
            // 
            // provider_textBox
            // 
            this.provider_textBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.provider_textBox.Location = new System.Drawing.Point(173, 670);
            this.provider_textBox.Name = "provider_textBox";
            this.provider_textBox.Size = new System.Drawing.Size(126, 22);
            this.provider_textBox.TabIndex = 26;
            this.provider_textBox.TextChanged += new System.EventHandler(this.provider_textBox_TextChanged);
            // 
            // AutoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 761);
            this.Controls.Add(this.provider_textBox);
            this.Controls.Add(this.refresh_button);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.delete_Button);
            this.Controls.Add(this.save_Button);
            this.Controls.Add(this.refactor_Button);
            this.Controls.Add(this.new_record_Button);
            this.Controls.Add(this.organize_label);
            this.Controls.Add(this.price_textBox);
            this.Controls.Add(this.km_textBox);
            this.Controls.Add(this.color_textBox);
            this.Controls.Add(this.year_textBox);
            this.Controls.Add(this.model_textBox);
            this.Controls.Add(this.marka_textBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.km_label);
            this.Controls.Add(this.price_label);
            this.Controls.Add(this.color_label);
            this.Controls.Add(this.year_label);
            this.Controls.Add(this.model_label);
            this.Controls.Add(this.marka_label);
            this.Controls.Add(this.add_label);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.search_textbox);
            this.Controls.Add(this.find_label);
            this.Controls.Add(this.auto_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AutoForm";
            this.Text = "AutoForm";
            this.Load += new System.EventHandler(this.AutoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label auto_label;
        private System.Windows.Forms.Label find_label;
        private System.Windows.Forms.TextBox search_textbox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label add_label;
        private System.Windows.Forms.Label marka_label;
        private System.Windows.Forms.Label model_label;
        private System.Windows.Forms.Label year_label;
        private System.Windows.Forms.Label color_label;
        private System.Windows.Forms.Label price_label;
        private System.Windows.Forms.Label km_label;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox marka_textBox;
        private System.Windows.Forms.TextBox model_textBox;
        private System.Windows.Forms.TextBox year_textBox;
        private System.Windows.Forms.TextBox color_textBox;
        private System.Windows.Forms.TextBox km_textBox;
        private System.Windows.Forms.TextBox price_textBox;
        private System.Windows.Forms.Label organize_label;
        private System.Windows.Forms.Button new_record_Button;
        private System.Windows.Forms.Button refactor_Button;
        private System.Windows.Forms.Button save_Button;
        private System.Windows.Forms.Button delete_Button;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button refresh_button;
        private System.Windows.Forms.TextBox provider_textBox;
    }
}