namespace AutoStore
{
    partial class FeedbackForm
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
            this.back_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.search_textbox = new System.Windows.Forms.TextBox();
            this.find_label = new System.Windows.Forms.Label();
            this.auto_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // back_button
            // 
            this.back_button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back_button.Location = new System.Drawing.Point(718, 464);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(124, 30);
            this.back_button.TabIndex = 50;
            this.back_button.Text = "Назад";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(861, 402);
            this.dataGridView1.TabIndex = 30;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // search_textbox
            // 
            this.search_textbox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.search_textbox.Location = new System.Drawing.Point(651, 19);
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
            this.find_label.Location = new System.Drawing.Point(563, 22);
            this.find_label.Name = "find_label";
            this.find_label.Size = new System.Drawing.Size(54, 19);
            this.find_label.TabIndex = 28;
            this.find_label.Text = "Поиск:";
            // 
            // auto_label
            // 
            this.auto_label.BackColor = System.Drawing.SystemColors.Info;
            this.auto_label.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.auto_label.Location = new System.Drawing.Point(8, 8);
            this.auto_label.Name = "auto_label";
            this.auto_label.Size = new System.Drawing.Size(865, 45);
            this.auto_label.TabIndex = 27;
            this.auto_label.Text = "Отзывы";
            this.auto_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FeedbackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 510);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.search_textbox);
            this.Controls.Add(this.find_label);
            this.Controls.Add(this.auto_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FeedbackForm";
            this.Text = "FeedbackForm";
            this.Load += new System.EventHandler(this.FeedbackForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox search_textbox;
        private System.Windows.Forms.Label find_label;
        private System.Windows.Forms.Label auto_label;
    }
}