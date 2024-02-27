namespace WindowsFormsApp7
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
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.HostipalBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.Location = new System.Drawing.Point(372, 187);
            this.RegisterBtn.Margin = new System.Windows.Forms.Padding(4);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(309, 49);
            this.RegisterBtn.TabIndex = 0;
            this.RegisterBtn.Text = "Регистрация";
            this.RegisterBtn.UseVisualStyleBackColor = true;
            this.RegisterBtn.Click += new System.EventHandler(this.Register);
            // 
            // HostipalBtn
            // 
            this.HostipalBtn.Location = new System.Drawing.Point(372, 244);
            this.HostipalBtn.Margin = new System.Windows.Forms.Padding(4);
            this.HostipalBtn.Name = "HostipalBtn";
            this.HostipalBtn.Size = new System.Drawing.Size(309, 49);
            this.HostipalBtn.TabIndex = 1;
            this.HostipalBtn.Text = "Госпитализация";
            this.HostipalBtn.UseVisualStyleBackColor = true;
            this.HostipalBtn.Click += new System.EventHandler(this.HostipalBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(372, 301);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(309, 49);
            this.button1.TabIndex = 2;
            this.button1.Text = "Согласие на обработку ПД";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtnDataWord);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(372, 358);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(309, 49);
            this.button2.TabIndex = 3;
            this.button2.Text = "Мед.Услуги";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.BtnMedService);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(372, 415);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(309, 49);
            this.button3.TabIndex = 4;
            this.button3.Text = "Отслеживание дв.Клиентов";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.TrackBtnClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(372, 472);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(309, 49);
            this.button4.TabIndex = 5;
            this.button4.Text = "Отслеживание дв. в Стационарном";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.BtnStatonaryClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.HostipalBtn);
            this.Controls.Add(this.RegisterBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "МИС \"ГКБ Большие Кабаны\"";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.Button HostipalBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

