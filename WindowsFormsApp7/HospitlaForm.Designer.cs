namespace WindowsFormsApp7
{
    partial class HospitlaForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.HospCodeTxtBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimeBegin = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.StPolisCompanyTxtBox = new System.Windows.Forms.TextBox();
            this.dateEndPolis = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NumPolisTxtBox = new System.Windows.Forms.TextBox();
            this.dateBirth = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.fatherNameTxtBox = new System.Windows.Forms.TextBox();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.surnameTxtBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.placeWorkTxtBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.addressTxtBox = new System.Windows.Forms.TextBox();
            this.emailTxtBox = new System.Windows.Forms.TextBox();
            this.phoneTxtBox = new System.Windows.Forms.TextBox();
            this.seriaPasport = new System.Windows.Forms.TextBox();
            this.numberPasport = new System.Windows.Forms.TextBox();
            this.dateTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.deportamentTxtBox = new System.Windows.Forms.TextBox();
            this.DiagnosTxtBox = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.GoalTxtBox = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.searchCodeHosp = new System.Windows.Forms.TextBox();
            this.genderTxtBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(285, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 41);
            this.button1.TabIndex = 99;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(13, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 16);
            this.label5.TabIndex = 103;
            this.label5.Text = "Дата и время начала";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(13, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 16);
            this.label6.TabIndex = 101;
            this.label6.Text = "Код на госпитализацию";
            // 
            // HospCodeTxtBox
            // 
            this.HospCodeTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HospCodeTxtBox.Location = new System.Drawing.Point(182, 254);
            this.HospCodeTxtBox.Name = "HospCodeTxtBox";
            this.HospCodeTxtBox.Size = new System.Drawing.Size(201, 22);
            this.HospCodeTxtBox.TabIndex = 139;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 397);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(235, 41);
            this.button2.TabIndex = 109;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.BackClick);
            // 
            // dateTimeBegin
            // 
            this.dateTimeBegin.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateTimeBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeBegin.Location = new System.Drawing.Point(182, 283);
            this.dateTimeBegin.Name = "dateTimeBegin";
            this.dateTimeBegin.Size = new System.Drawing.Size(201, 20);
            this.dateTimeBegin.TabIndex = 140;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(426, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 138;
            this.label4.Text = "Компания";
            // 
            // StPolisCompanyTxtBox
            // 
            this.StPolisCompanyTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StPolisCompanyTxtBox.Location = new System.Drawing.Point(560, 185);
            this.StPolisCompanyTxtBox.Name = "StPolisCompanyTxtBox";
            this.StPolisCompanyTxtBox.Size = new System.Drawing.Size(224, 22);
            this.StPolisCompanyTxtBox.TabIndex = 138;
            // 
            // dateEndPolis
            // 
            this.dateEndPolis.Location = new System.Drawing.Point(560, 158);
            this.dateEndPolis.Name = "dateEndPolis";
            this.dateEndPolis.Size = new System.Drawing.Size(224, 20);
            this.dateEndPolis.TabIndex = 137;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(426, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 135;
            this.label2.Text = "Дата окончания";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(426, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 16);
            this.label3.TabIndex = 134;
            this.label3.Text = "Номер Ст.Полиса";
            // 
            // NumPolisTxtBox
            // 
            this.NumPolisTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumPolisTxtBox.Location = new System.Drawing.Point(560, 130);
            this.NumPolisTxtBox.Name = "NumPolisTxtBox";
            this.NumPolisTxtBox.Size = new System.Drawing.Size(224, 22);
            this.NumPolisTxtBox.TabIndex = 136;
            // 
            // dateBirth
            // 
            this.dateBirth.Location = new System.Drawing.Point(560, 9);
            this.dateBirth.Name = "dateBirth";
            this.dateBirth.Size = new System.Drawing.Size(224, 20);
            this.dateBirth.TabIndex = 133;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(426, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 16);
            this.label7.TabIndex = 131;
            this.label7.Text = "Дата рождения";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(12, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 16);
            this.label8.TabIndex = 130;
            this.label8.Text = "Отчество";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(12, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 16);
            this.label9.TabIndex = 129;
            this.label9.Text = "Имя";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(12, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 16);
            this.label10.TabIndex = 128;
            this.label10.Text = "Фамилия";
            // 
            // fatherNameTxtBox
            // 
            this.fatherNameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fatherNameTxtBox.Location = new System.Drawing.Point(146, 58);
            this.fatherNameTxtBox.Name = "fatherNameTxtBox";
            this.fatherNameTxtBox.Size = new System.Drawing.Size(224, 22);
            this.fatherNameTxtBox.TabIndex = 127;
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTxtBox.Location = new System.Drawing.Point(146, 32);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(224, 22);
            this.nameTxtBox.TabIndex = 126;
            // 
            // surnameTxtBox
            // 
            this.surnameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameTxtBox.Location = new System.Drawing.Point(146, 6);
            this.surnameTxtBox.Name = "surnameTxtBox";
            this.surnameTxtBox.Size = new System.Drawing.Size(224, 22);
            this.surnameTxtBox.TabIndex = 125;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(12, 211);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 16);
            this.label11.TabIndex = 124;
            this.label11.Text = "Место работы";
            // 
            // placeWorkTxtBox
            // 
            this.placeWorkTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.placeWorkTxtBox.Location = new System.Drawing.Point(146, 208);
            this.placeWorkTxtBox.Name = "placeWorkTxtBox";
            this.placeWorkTxtBox.Size = new System.Drawing.Size(224, 22);
            this.placeWorkTxtBox.TabIndex = 132;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(12, 185);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 16);
            this.label12.TabIndex = 122;
            this.label12.Text = "Адрес";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(12, 159);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 16);
            this.label13.TabIndex = 121;
            this.label13.Text = "Эл.почта";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(12, 133);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 16);
            this.label14.TabIndex = 120;
            this.label14.Text = "Телефон";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(426, 63);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(112, 16);
            this.label15.TabIndex = 119;
            this.label15.Text = "Серия паспорта";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(426, 37);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(115, 16);
            this.label16.TabIndex = 118;
            this.label16.Text = "Номер паспорта";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(12, 89);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(33, 16);
            this.label17.TabIndex = 117;
            this.label17.Text = "Пол";
            // 
            // addressTxtBox
            // 
            this.addressTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addressTxtBox.Location = new System.Drawing.Point(146, 182);
            this.addressTxtBox.Name = "addressTxtBox";
            this.addressTxtBox.Size = new System.Drawing.Size(224, 22);
            this.addressTxtBox.TabIndex = 131;
            // 
            // emailTxtBox
            // 
            this.emailTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailTxtBox.Location = new System.Drawing.Point(146, 156);
            this.emailTxtBox.Name = "emailTxtBox";
            this.emailTxtBox.Size = new System.Drawing.Size(224, 22);
            this.emailTxtBox.TabIndex = 130;
            // 
            // phoneTxtBox
            // 
            this.phoneTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneTxtBox.Location = new System.Drawing.Point(146, 130);
            this.phoneTxtBox.Name = "phoneTxtBox";
            this.phoneTxtBox.Size = new System.Drawing.Size(224, 22);
            this.phoneTxtBox.TabIndex = 129;
            // 
            // seriaPasport
            // 
            this.seriaPasport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.seriaPasport.Location = new System.Drawing.Point(560, 60);
            this.seriaPasport.Name = "seriaPasport";
            this.seriaPasport.Size = new System.Drawing.Size(224, 22);
            this.seriaPasport.TabIndex = 135;
            // 
            // numberPasport
            // 
            this.numberPasport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberPasport.Location = new System.Drawing.Point(560, 34);
            this.numberPasport.Name = "numberPasport";
            this.numberPasport.Size = new System.Drawing.Size(224, 22);
            this.numberPasport.TabIndex = 134;
            // 
            // dateTimeEnd
            // 
            this.dateTimeEnd.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeEnd.Location = new System.Drawing.Point(182, 309);
            this.dateTimeEnd.Name = "dateTimeEnd";
            this.dateTimeEnd.Size = new System.Drawing.Size(201, 20);
            this.dateTimeEnd.TabIndex = 141;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 16);
            this.label1.TabIndex = 139;
            this.label1.Text = "Дата и время окончания";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(427, 257);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(80, 16);
            this.label18.TabIndex = 142;
            this.label18.Text = "Отделение";
            // 
            // deportamentTxtBox
            // 
            this.deportamentTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deportamentTxtBox.Location = new System.Drawing.Point(561, 254);
            this.deportamentTxtBox.Name = "deportamentTxtBox";
            this.deportamentTxtBox.Size = new System.Drawing.Size(224, 22);
            this.deportamentTxtBox.TabIndex = 142;
            // 
            // DiagnosTxtBox
            // 
            this.DiagnosTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiagnosTxtBox.Location = new System.Drawing.Point(561, 280);
            this.DiagnosTxtBox.Name = "DiagnosTxtBox";
            this.DiagnosTxtBox.Size = new System.Drawing.Size(224, 22);
            this.DiagnosTxtBox.TabIndex = 143;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(427, 283);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(62, 16);
            this.label19.TabIndex = 144;
            this.label19.Text = "Диагноз";
            // 
            // GoalTxtBox
            // 
            this.GoalTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoalTxtBox.Location = new System.Drawing.Point(561, 306);
            this.GoalTxtBox.Name = "GoalTxtBox";
            this.GoalTxtBox.Size = new System.Drawing.Size(224, 22);
            this.GoalTxtBox.TabIndex = 144;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.Location = new System.Drawing.Point(427, 309);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(39, 16);
            this.label20.TabIndex = 146;
            this.label20.Text = "Цель";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(553, 397);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(235, 41);
            this.button3.TabIndex = 148;
            this.button3.Text = "Поиск по коду госпитализации";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.SearchBtnClick);
            // 
            // searchCodeHosp
            // 
            this.searchCodeHosp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchCodeHosp.Location = new System.Drawing.Point(553, 369);
            this.searchCodeHosp.Name = "searchCodeHosp";
            this.searchCodeHosp.Size = new System.Drawing.Size(231, 22);
            this.searchCodeHosp.TabIndex = 149;
            this.searchCodeHosp.Text = "Введите код для поиска";
            // 
            // genderTxtBox
            // 
            this.genderTxtBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderTxtBox.FormattingEnabled = true;
            this.genderTxtBox.Items.AddRange(new object[] {
            "М",
            "Ж"});
            this.genderTxtBox.Location = new System.Drawing.Point(146, 88);
            this.genderTxtBox.Name = "genderTxtBox";
            this.genderTxtBox.Size = new System.Drawing.Size(224, 21);
            this.genderTxtBox.TabIndex = 150;
            // 
            // HospitlaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.genderTxtBox);
            this.Controls.Add(this.searchCodeHosp);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.GoalTxtBox);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.DiagnosTxtBox);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.deportamentTxtBox);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.dateTimeEnd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.StPolisCompanyTxtBox);
            this.Controls.Add(this.dateEndPolis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NumPolisTxtBox);
            this.Controls.Add(this.dateBirth);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.fatherNameTxtBox);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.surnameTxtBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.placeWorkTxtBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.addressTxtBox);
            this.Controls.Add(this.emailTxtBox);
            this.Controls.Add(this.phoneTxtBox);
            this.Controls.Add(this.seriaPasport);
            this.Controls.Add(this.numberPasport);
            this.Controls.Add(this.dateTimeBegin);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.HospCodeTxtBox);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "HospitlaForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Госпитализация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox HospCodeTxtBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTimeBegin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox StPolisCompanyTxtBox;
        private System.Windows.Forms.DateTimePicker dateEndPolis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NumPolisTxtBox;
        private System.Windows.Forms.DateTimePicker dateBirth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox fatherNameTxtBox;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.TextBox surnameTxtBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox placeWorkTxtBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox addressTxtBox;
        private System.Windows.Forms.TextBox emailTxtBox;
        private System.Windows.Forms.TextBox phoneTxtBox;
        private System.Windows.Forms.TextBox seriaPasport;
        private System.Windows.Forms.TextBox numberPasport;
        private System.Windows.Forms.DateTimePicker dateTimeEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox deportamentTxtBox;
        private System.Windows.Forms.TextBox DiagnosTxtBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox GoalTxtBox;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox searchCodeHosp;
        private System.Windows.Forms.ComboBox genderTxtBox;
    }
}