namespace EquipmentCalculatorAPPWF
{
    partial class EquipmentCalculatorAPPWF
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
            this.UploadButton = new System.Windows.Forms.Button();
            this.EnterName = new System.Windows.Forms.Label();
            this.EnteredName = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CycleTime = new System.Windows.Forms.TextBox();
            this.WorkingDays = new System.Windows.Forms.TextBox();
            this.Cycle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EfficiencyFactor = new System.Windows.Forms.TextBox();
            this.KPI = new System.Windows.Forms.Label();
            this.VorkValue = new System.Windows.Forms.Label();
            this.WorkValueBox = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.FilePath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UploadButton
            // 
            this.UploadButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.UploadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UploadButton.Location = new System.Drawing.Point(194, 389);
            this.UploadButton.Name = "UploadButton";
            this.UploadButton.Size = new System.Drawing.Size(336, 50);
            this.UploadButton.TabIndex = 0;
            this.UploadButton.Text = "Выгрузка результатов";
            this.UploadButton.UseVisualStyleBackColor = false;
            this.UploadButton.Click += new System.EventHandler(this.UploadButton_Click);
            // 
            // EnterName
            // 
            this.EnterName.AutoSize = true;
            this.EnterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterName.Location = new System.Drawing.Point(12, 12);
            this.EnterName.Name = "EnterName";
            this.EnterName.Size = new System.Drawing.Size(250, 16);
            this.EnterName.TabIndex = 1;
            this.EnterName.Text = "Введите наименование экскаватора";
            // 
            // EnteredName
            // 
            this.EnteredName.BackColor = System.Drawing.SystemColors.Info;
            this.EnteredName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnteredName.Location = new System.Drawing.Point(268, 9);
            this.EnteredName.Name = "EnteredName";
            this.EnteredName.Size = new System.Drawing.Size(262, 22);
            this.EnteredName.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "1 кубический метр",
            "5 кубических метров",
            "10 кубических метров",
            "20 кубических метров",
            "50 кубических метров"});
            this.comboBox1.BackColor = System.Drawing.SystemColors.Info;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "5",
            "10",
            "20",
            "50"});
            this.comboBox1.Location = new System.Drawing.Point(268, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(262, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Выберите объём ковша";
            // 
            // CycleTime
            // 
            this.CycleTime.BackColor = System.Drawing.SystemColors.Info;
            this.CycleTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CycleTime.Location = new System.Drawing.Point(268, 67);
            this.CycleTime.Name = "CycleTime";
            this.CycleTime.Size = new System.Drawing.Size(262, 22);
            this.CycleTime.TabIndex = 5;
            this.CycleTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CycleTime_KeyPress);
            // 
            // WorkingDays
            // 
            this.WorkingDays.BackColor = System.Drawing.SystemColors.Info;
            this.WorkingDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WorkingDays.Location = new System.Drawing.Point(268, 95);
            this.WorkingDays.Name = "WorkingDays";
            this.WorkingDays.Size = new System.Drawing.Size(262, 22);
            this.WorkingDays.TabIndex = 6;
            this.WorkingDays.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WorkingDays_KeyPress);
            // 
            // Cycle
            // 
            this.Cycle.AutoSize = true;
            this.Cycle.BackColor = System.Drawing.SystemColors.Control;
            this.Cycle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cycle.Location = new System.Drawing.Point(12, 70);
            this.Cycle.Name = "Cycle";
            this.Cycle.Size = new System.Drawing.Size(222, 16);
            this.Cycle.TabIndex = 7;
            this.Cycle.Text = "Введите время цикла в секундах";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Введите кол рабочих дней в году ";
            // 
            // EfficiencyFactor
            // 
            this.EfficiencyFactor.BackColor = System.Drawing.SystemColors.Info;
            this.EfficiencyFactor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EfficiencyFactor.Location = new System.Drawing.Point(268, 123);
            this.EfficiencyFactor.Name = "EfficiencyFactor";
            this.EfficiencyFactor.Size = new System.Drawing.Size(262, 22);
            this.EfficiencyFactor.TabIndex = 9;
            this.EfficiencyFactor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EfficiencyFactor_KeyPress);
            // 
            // KPI
            // 
            this.KPI.AutoSize = true;
            this.KPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KPI.Location = new System.Drawing.Point(12, 126);
            this.KPI.Name = "KPI";
            this.KPI.Size = new System.Drawing.Size(226, 16);
            this.KPI.TabIndex = 10;
            this.KPI.Text = "Введите КПИ с точность до сотых";
            // 
            // VorkValue
            // 
            this.VorkValue.AutoSize = true;
            this.VorkValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VorkValue.Location = new System.Drawing.Point(12, 153);
            this.VorkValue.Name = "VorkValue";
            this.VorkValue.Size = new System.Drawing.Size(161, 16);
            this.VorkValue.TabIndex = 11;
            this.VorkValue.Text = "Введите Объём работы";
            // 
            // WorkValueBox
            // 
            this.WorkValueBox.BackColor = System.Drawing.SystemColors.Info;
            this.WorkValueBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WorkValueBox.Location = new System.Drawing.Point(268, 153);
            this.WorkValueBox.Name = "WorkValueBox";
            this.WorkValueBox.Size = new System.Drawing.Size(262, 22);
            this.WorkValueBox.TabIndex = 12;
            this.WorkValueBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WorkValueBox_KeyPress);
            // 
            // Result
            // 
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Result.Location = new System.Drawing.Point(15, 223);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(515, 29);
            this.Result.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(190, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Результат выгрузки";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(517, 46);
            this.button1.TabIndex = 15;
            this.button1.Text = "Вывести расчёт в результат";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonBrowse.Location = new System.Drawing.Point(12, 320);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(120, 62);
            this.buttonBrowse.TabIndex = 16;
            this.buttonBrowse.Text = "Выбор пути скачивания";
            this.buttonBrowse.UseVisualStyleBackColor = false;
            this.buttonBrowse.Click += new System.EventHandler(this.ButtonBrowse_Click);
            // 
            // FilePath
            // 
            this.FilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilePath.Location = new System.Drawing.Point(164, 327);
            this.FilePath.Name = "FilePath";
            this.FilePath.Size = new System.Drawing.Size(365, 29);
            this.FilePath.TabIndex = 17;
            // 
            // EquipmentCalculatorAPPWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 451);
            this.Controls.Add(this.FilePath);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.WorkValueBox);
            this.Controls.Add(this.VorkValue);
            this.Controls.Add(this.KPI);
            this.Controls.Add(this.EfficiencyFactor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cycle);
            this.Controls.Add(this.WorkingDays);
            this.Controls.Add(this.CycleTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.EnteredName);
            this.Controls.Add(this.EnterName);
            this.Controls.Add(this.UploadButton);
            this.Name = "EquipmentCalculatorAPPWF";
            this.Text = "Калькулятор количества оборудования";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UploadButton;
        private System.Windows.Forms.Label EnterName;
        private System.Windows.Forms.TextBox EnteredName;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CycleTime;
        private System.Windows.Forms.TextBox WorkingDays;
        private System.Windows.Forms.Label Cycle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EfficiencyFactor;
        private System.Windows.Forms.Label KPI;
        private System.Windows.Forms.Label VorkValue;
        private System.Windows.Forms.TextBox WorkValueBox;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.TextBox FilePath;
    }
}

