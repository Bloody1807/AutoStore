namespace AutoStore
{
    partial class MainForm
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
            this.auto_btn = new System.Windows.Forms.Button();
            this.test_dr_btn = new System.Windows.Forms.Button();
            this.client_btn = new System.Windows.Forms.Button();
            this.feedback_btn = new System.Windows.Forms.Button();
            this.users_btn = new System.Windows.Forms.Button();
            this.provider_btn = new System.Windows.Forms.Button();
            this.sales_btn = new System.Windows.Forms.Button();
            this.services_btn = new System.Windows.Forms.Button();
            this.employee_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // auto_btn
            // 
            this.auto_btn.Location = new System.Drawing.Point(116, 58);
            this.auto_btn.Name = "auto_btn";
            this.auto_btn.Size = new System.Drawing.Size(157, 30);
            this.auto_btn.TabIndex = 0;
            this.auto_btn.Text = "Автомобили";
            this.auto_btn.UseVisualStyleBackColor = true;
            this.auto_btn.Click += new System.EventHandler(this.auto_btn_Click);
            // 
            // test_dr_btn
            // 
            this.test_dr_btn.Location = new System.Drawing.Point(116, 87);
            this.test_dr_btn.Name = "test_dr_btn";
            this.test_dr_btn.Size = new System.Drawing.Size(157, 30);
            this.test_dr_btn.TabIndex = 1;
            this.test_dr_btn.Text = "Запросы на тест-драйв";
            this.test_dr_btn.UseVisualStyleBackColor = true;
            this.test_dr_btn.Click += new System.EventHandler(this.test_dr_btn_Click);
            // 
            // client_btn
            // 
            this.client_btn.Location = new System.Drawing.Point(116, 116);
            this.client_btn.Name = "client_btn";
            this.client_btn.Size = new System.Drawing.Size(157, 30);
            this.client_btn.TabIndex = 2;
            this.client_btn.Text = "Клиенты";
            this.client_btn.UseVisualStyleBackColor = true;
            this.client_btn.Click += new System.EventHandler(this.client_btn_Click);
            // 
            // feedback_btn
            // 
            this.feedback_btn.Location = new System.Drawing.Point(116, 145);
            this.feedback_btn.Name = "feedback_btn";
            this.feedback_btn.Size = new System.Drawing.Size(157, 30);
            this.feedback_btn.TabIndex = 3;
            this.feedback_btn.Text = "Отзывы";
            this.feedback_btn.UseVisualStyleBackColor = true;
            this.feedback_btn.Click += new System.EventHandler(this.fb_btn_Click);
            // 
            // users_btn
            // 
            this.users_btn.Location = new System.Drawing.Point(116, 174);
            this.users_btn.Name = "users_btn";
            this.users_btn.Size = new System.Drawing.Size(157, 30);
            this.users_btn.TabIndex = 4;
            this.users_btn.Text = "Пользователи";
            this.users_btn.UseVisualStyleBackColor = true;
            this.users_btn.Click += new System.EventHandler(this.users_btn_Click);
            // 
            // provider_btn
            // 
            this.provider_btn.Location = new System.Drawing.Point(116, 203);
            this.provider_btn.Name = "provider_btn";
            this.provider_btn.Size = new System.Drawing.Size(157, 30);
            this.provider_btn.TabIndex = 5;
            this.provider_btn.Text = "Поставщики";
            this.provider_btn.UseVisualStyleBackColor = true;
            this.provider_btn.Click += new System.EventHandler(this.provider_btn_Click);
            // 
            // sales_btn
            // 
            this.sales_btn.Location = new System.Drawing.Point(116, 232);
            this.sales_btn.Name = "sales_btn";
            this.sales_btn.Size = new System.Drawing.Size(157, 30);
            this.sales_btn.TabIndex = 6;
            this.sales_btn.Text = "Продажи";
            this.sales_btn.UseVisualStyleBackColor = true;
            this.sales_btn.Click += new System.EventHandler(this.sale_btn_Click);
            // 
            // services_btn
            // 
            this.services_btn.Location = new System.Drawing.Point(116, 261);
            this.services_btn.Name = "services_btn";
            this.services_btn.Size = new System.Drawing.Size(157, 30);
            this.services_btn.TabIndex = 7;
            this.services_btn.Text = "Сервисное обслуживание";
            this.services_btn.UseVisualStyleBackColor = true;
            this.services_btn.Click += new System.EventHandler(this.services_btn_Click);
            // 
            // employee_btn
            // 
            this.employee_btn.Location = new System.Drawing.Point(116, 290);
            this.employee_btn.Name = "employee_btn";
            this.employee_btn.Size = new System.Drawing.Size(157, 30);
            this.employee_btn.TabIndex = 8;
            this.employee_btn.Text = "Сотрудники";
            this.employee_btn.UseVisualStyleBackColor = true;
            this.employee_btn.Click += new System.EventHandler(this.employee_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit_btn.Location = new System.Drawing.Point(287, 12);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(90, 30);
            this.exit_btn.TabIndex = 9;
            this.exit_btn.Text = "Выйти";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_sign_in_btn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 377);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.employee_btn);
            this.Controls.Add(this.services_btn);
            this.Controls.Add(this.sales_btn);
            this.Controls.Add(this.provider_btn);
            this.Controls.Add(this.users_btn);
            this.Controls.Add(this.feedback_btn);
            this.Controls.Add(this.client_btn);
            this.Controls.Add(this.test_dr_btn);
            this.Controls.Add(this.auto_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button auto_btn;
        private System.Windows.Forms.Button test_dr_btn;
        private System.Windows.Forms.Button client_btn;
        private System.Windows.Forms.Button feedback_btn;
        private System.Windows.Forms.Button users_btn;
        private System.Windows.Forms.Button provider_btn;
        private System.Windows.Forms.Button sales_btn;
        private System.Windows.Forms.Button services_btn;
        private System.Windows.Forms.Button employee_btn;
        private System.Windows.Forms.Button exit_btn;
    }
}

