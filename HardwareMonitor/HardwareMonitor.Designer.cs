namespace HardwareMonitor
{
    partial class HardwareMonitor
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
            this.components = new System.ComponentModel.Container();
            this.CpuLabel = new System.Windows.Forms.Label();
            this.CpuNameLabel = new System.Windows.Forms.Label();
            this.CpuProgressBar = new System.Windows.Forms.ProgressBar();
            this.CpuLoadLabel = new System.Windows.Forms.Label();
            this.CpuCoresLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.RamLabel = new System.Windows.Forms.Label();
            this.RamProgressBar = new System.Windows.Forms.ProgressBar();
            this.RamAvailableLabel = new System.Windows.Forms.Label();
            this.RamFreeLabel = new System.Windows.Forms.Label();
            this.CpuPerformanceCounter = new System.Diagnostics.PerformanceCounter();
            this.RamRefreshButton = new System.Windows.Forms.Button();
            this.DiskLabel = new System.Windows.Forms.Label();
            this.DiskCountLabel = new System.Windows.Forms.Label();
            this.DiskDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GpuLabel = new System.Windows.Forms.Label();
            this.GpuNameLabel = new System.Windows.Forms.Label();
            this.GpuMemorylabel = new System.Windows.Forms.Label();
            this.GpuDriverVersionLabel = new System.Windows.Forms.Label();
            this.InternetCheckBox = new System.Windows.Forms.CheckBox();
            this.InternetRefreshButton = new System.Windows.Forms.Button();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.GpuResolutionLabel = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.OperatingSystemVersionLabel = new System.Windows.Forms.Label();
            this.OperatingSystemLabel = new System.Windows.Forms.Label();
            this.ComputernameLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CpuPerformanceCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiskDataGridView)).BeginInit();
            this.TabControl.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CpuLabel
            // 
            this.CpuLabel.AutoSize = true;
            this.CpuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CpuLabel.Location = new System.Drawing.Point(6, 6);
            this.CpuLabel.Name = "CpuLabel";
            this.CpuLabel.Size = new System.Drawing.Size(78, 36);
            this.CpuLabel.TabIndex = 1;
            this.CpuLabel.Text = "CPU";
            // 
            // CpuNameLabel
            // 
            this.CpuNameLabel.AutoSize = true;
            this.CpuNameLabel.Location = new System.Drawing.Point(189, 11);
            this.CpuNameLabel.Name = "CpuNameLabel";
            this.CpuNameLabel.Size = new System.Drawing.Size(63, 13);
            this.CpuNameLabel.TabIndex = 2;
            this.CpuNameLabel.Text = "Процессор";
            // 
            // CpuProgressBar
            // 
            this.CpuProgressBar.Location = new System.Drawing.Point(85, 13);
            this.CpuProgressBar.Name = "CpuProgressBar";
            this.CpuProgressBar.Size = new System.Drawing.Size(70, 23);
            this.CpuProgressBar.Step = 1;
            this.CpuProgressBar.TabIndex = 3;
            // 
            // CpuLoadLabel
            // 
            this.CpuLoadLabel.AutoSize = true;
            this.CpuLoadLabel.Location = new System.Drawing.Point(288, 26);
            this.CpuLoadLabel.Name = "CpuLoadLabel";
            this.CpuLoadLabel.Size = new System.Drawing.Size(30, 13);
            this.CpuLoadLabel.TabIndex = 4;
            this.CpuLoadLabel.Text = "50 %";
            // 
            // CpuCoresLabel
            // 
            this.CpuCoresLabel.AutoSize = true;
            this.CpuCoresLabel.Location = new System.Drawing.Point(189, 26);
            this.CpuCoresLabel.Name = "CpuCoresLabel";
            this.CpuCoresLabel.Size = new System.Drawing.Size(93, 13);
            this.CpuCoresLabel.TabIndex = 2;
            this.CpuCoresLabel.Text = "Количество ядер";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // RamLabel
            // 
            this.RamLabel.AutoSize = true;
            this.RamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RamLabel.Location = new System.Drawing.Point(6, 55);
            this.RamLabel.Name = "RamLabel";
            this.RamLabel.Size = new System.Drawing.Size(83, 36);
            this.RamLabel.TabIndex = 1;
            this.RamLabel.Text = "RAM";
            // 
            // RamProgressBar
            // 
            this.RamProgressBar.Location = new System.Drawing.Point(85, 62);
            this.RamProgressBar.Name = "RamProgressBar";
            this.RamProgressBar.Size = new System.Drawing.Size(70, 23);
            this.RamProgressBar.Step = 1;
            this.RamProgressBar.TabIndex = 3;
            // 
            // RamAvailableLabel
            // 
            this.RamAvailableLabel.AutoSize = true;
            this.RamAvailableLabel.Location = new System.Drawing.Point(189, 60);
            this.RamAvailableLabel.Name = "RamAvailableLabel";
            this.RamAvailableLabel.Size = new System.Drawing.Size(88, 13);
            this.RamAvailableLabel.TabIndex = 2;
            this.RamAvailableLabel.Text = "Память (общая)";
            // 
            // RamFreeLabel
            // 
            this.RamFreeLabel.AutoSize = true;
            this.RamFreeLabel.Location = new System.Drawing.Point(189, 73);
            this.RamFreeLabel.Name = "RamFreeLabel";
            this.RamFreeLabel.Size = new System.Drawing.Size(109, 13);
            this.RamFreeLabel.TabIndex = 2;
            this.RamFreeLabel.Text = "Память (свободная)";
            // 
            // CpuPerformanceCounter
            // 
            this.CpuPerformanceCounter.CategoryName = "Processor";
            this.CpuPerformanceCounter.CounterName = "% Processor time";
            this.CpuPerformanceCounter.InstanceName = "_Total";
            // 
            // RamRefreshButton
            // 
            this.RamRefreshButton.Location = new System.Drawing.Point(382, 62);
            this.RamRefreshButton.Name = "RamRefreshButton";
            this.RamRefreshButton.Size = new System.Drawing.Size(75, 23);
            this.RamRefreshButton.TabIndex = 5;
            this.RamRefreshButton.TabStop = false;
            this.RamRefreshButton.Text = "Обновить";
            this.RamRefreshButton.UseVisualStyleBackColor = true;
            this.RamRefreshButton.Click += new System.EventHandler(this.RamRefreshButton_Click);
            // 
            // DiskLabel
            // 
            this.DiskLabel.AutoSize = true;
            this.DiskLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiskLabel.Location = new System.Drawing.Point(6, 103);
            this.DiskLabel.Name = "DiskLabel";
            this.DiskLabel.Size = new System.Drawing.Size(104, 36);
            this.DiskLabel.TabIndex = 1;
            this.DiskLabel.Text = "DRAM";
            // 
            // DiskCountLabel
            // 
            this.DiskCountLabel.AutoSize = true;
            this.DiskCountLabel.Location = new System.Drawing.Point(12, 143);
            this.DiskCountLabel.Name = "DiskCountLabel";
            this.DiskCountLabel.Size = new System.Drawing.Size(82, 13);
            this.DiskCountLabel.TabIndex = 7;
            this.DiskCountLabel.Text = "Всего дисков: ";
            // 
            // DiskDataGridView
            // 
            this.DiskDataGridView.AllowUserToAddRows = false;
            this.DiskDataGridView.AllowUserToDeleteRows = false;
            this.DiskDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DiskDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DiskDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DiskDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DiskDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DiskDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.DiskDataGridView.Location = new System.Drawing.Point(116, 110);
            this.DiskDataGridView.Name = "DiskDataGridView";
            this.DiskDataGridView.Size = new System.Drawing.Size(341, 84);
            this.DiskDataGridView.TabIndex = 8;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.FillWeight = 60F;
            this.Column1.HeaderText = "Диск";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Всего, Гб";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Свободно, Гб";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column4.HeaderText = "%";
            this.Column4.MinimumWidth = 20;
            this.Column4.Name = "Column4";
            this.Column4.Width = 40;
            // 
            // GpuLabel
            // 
            this.GpuLabel.AutoSize = true;
            this.GpuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GpuLabel.Location = new System.Drawing.Point(6, 187);
            this.GpuLabel.Name = "GpuLabel";
            this.GpuLabel.Size = new System.Drawing.Size(80, 36);
            this.GpuLabel.TabIndex = 1;
            this.GpuLabel.Text = "GPU";
            // 
            // GpuNameLabel
            // 
            this.GpuNameLabel.AutoSize = true;
            this.GpuNameLabel.Location = new System.Drawing.Point(99, 193);
            this.GpuNameLabel.Name = "GpuNameLabel";
            this.GpuNameLabel.Size = new System.Drawing.Size(52, 13);
            this.GpuNameLabel.TabIndex = 9;
            this.GpuNameLabel.Text = "Модель: ";
            // 
            // GpuMemorylabel
            // 
            this.GpuMemorylabel.AutoSize = true;
            this.GpuMemorylabel.Location = new System.Drawing.Point(99, 210);
            this.GpuMemorylabel.Name = "GpuMemorylabel";
            this.GpuMemorylabel.Size = new System.Drawing.Size(118, 13);
            this.GpuMemorylabel.TabIndex = 9;
            this.GpuMemorylabel.Text = "Объем видеопамяти: ";
            // 
            // GpuDriverVersionLabel
            // 
            this.GpuDriverVersionLabel.AutoSize = true;
            this.GpuDriverVersionLabel.Location = new System.Drawing.Point(99, 227);
            this.GpuDriverVersionLabel.Name = "GpuDriverVersionLabel";
            this.GpuDriverVersionLabel.Size = new System.Drawing.Size(101, 13);
            this.GpuDriverVersionLabel.TabIndex = 9;
            this.GpuDriverVersionLabel.Text = "Версия драйвера: ";
            // 
            // InternetCheckBox
            // 
            this.InternetCheckBox.AutoCheck = false;
            this.InternetCheckBox.AutoSize = true;
            this.InternetCheckBox.Location = new System.Drawing.Point(291, 193);
            this.InternetCheckBox.Name = "InternetCheckBox";
            this.InternetCheckBox.Size = new System.Drawing.Size(146, 17);
            this.InternetCheckBox.TabIndex = 10;
            this.InternetCheckBox.TabStop = false;
            this.InternetCheckBox.Text = "Подключен к интернету";
            this.InternetCheckBox.UseVisualStyleBackColor = true;
            // 
            // InternetRefreshButton
            // 
            this.InternetRefreshButton.Location = new System.Drawing.Point(291, 216);
            this.InternetRefreshButton.Name = "InternetRefreshButton";
            this.InternetRefreshButton.Size = new System.Drawing.Size(75, 23);
            this.InternetRefreshButton.TabIndex = 11;
            this.InternetRefreshButton.Text = "Проверить";
            this.InternetRefreshButton.UseVisualStyleBackColor = true;
            this.InternetRefreshButton.Click += new System.EventHandler(this.InternetRefreshButton_Click);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabPage2);
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Location = new System.Drawing.Point(-1, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(489, 364);
            this.TabControl.TabIndex = 12;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.GpuResolutionLabel);
            this.tabPage2.Controls.Add(this.RamLabel);
            this.tabPage2.Controls.Add(this.InternetRefreshButton);
            this.tabPage2.Controls.Add(this.CpuLabel);
            this.tabPage2.Controls.Add(this.InternetCheckBox);
            this.tabPage2.Controls.Add(this.DiskLabel);
            this.tabPage2.Controls.Add(this.GpuDriverVersionLabel);
            this.tabPage2.Controls.Add(this.GpuLabel);
            this.tabPage2.Controls.Add(this.GpuMemorylabel);
            this.tabPage2.Controls.Add(this.CpuNameLabel);
            this.tabPage2.Controls.Add(this.GpuNameLabel);
            this.tabPage2.Controls.Add(this.RamAvailableLabel);
            this.tabPage2.Controls.Add(this.DiskDataGridView);
            this.tabPage2.Controls.Add(this.RamFreeLabel);
            this.tabPage2.Controls.Add(this.DiskCountLabel);
            this.tabPage2.Controls.Add(this.CpuCoresLabel);
            this.tabPage2.Controls.Add(this.RamRefreshButton);
            this.tabPage2.Controls.Add(this.CpuProgressBar);
            this.tabPage2.Controls.Add(this.CpuLoadLabel);
            this.tabPage2.Controls.Add(this.RamProgressBar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(481, 338);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ресурсы";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // GpuResolutionLabel
            // 
            this.GpuResolutionLabel.AutoSize = true;
            this.GpuResolutionLabel.Location = new System.Drawing.Point(99, 244);
            this.GpuResolutionLabel.Name = "GpuResolutionLabel";
            this.GpuResolutionLabel.Size = new System.Drawing.Size(76, 13);
            this.GpuResolutionLabel.TabIndex = 12;
            this.GpuResolutionLabel.Text = "Разрешение: ";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.OperatingSystemVersionLabel);
            this.tabPage1.Controls.Add(this.OperatingSystemLabel);
            this.tabPage1.Controls.Add(this.ComputernameLabel);
            this.tabPage1.Controls.Add(this.UsernameLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(481, 338);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Система";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // OperatingSystemVersionLabel
            // 
            this.OperatingSystemVersionLabel.AutoSize = true;
            this.OperatingSystemVersionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.OperatingSystemVersionLabel.Location = new System.Drawing.Point(18, 118);
            this.OperatingSystemVersionLabel.Name = "OperatingSystemVersionLabel";
            this.OperatingSystemVersionLabel.Size = new System.Drawing.Size(64, 17);
            this.OperatingSystemVersionLabel.TabIndex = 3;
            this.OperatingSystemVersionLabel.Text = "Сборка: ";
            // 
            // OperatingSystemLabel
            // 
            this.OperatingSystemLabel.AutoSize = true;
            this.OperatingSystemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.OperatingSystemLabel.Location = new System.Drawing.Point(18, 91);
            this.OperatingSystemLabel.Name = "OperatingSystemLabel";
            this.OperatingSystemLabel.Size = new System.Drawing.Size(173, 17);
            this.OperatingSystemLabel.TabIndex = 2;
            this.OperatingSystemLabel.Text = "Операционная система: ";
            // 
            // ComputernameLabel
            // 
            this.ComputernameLabel.AutoSize = true;
            this.ComputernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ComputernameLabel.Location = new System.Drawing.Point(18, 37);
            this.ComputernameLabel.Name = "ComputernameLabel";
            this.ComputernameLabel.Size = new System.Drawing.Size(90, 17);
            this.ComputernameLabel.TabIndex = 1;
            this.ComputernameLabel.Text = "Компьютер: ";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.UsernameLabel.Location = new System.Drawing.Point(18, 64);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(139, 17);
            this.UsernameLabel.TabIndex = 0;
            this.UsernameLabel.Text = "Имя пользователя: ";
            // 
            // HardwareMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.TabControl);
            this.Name = "HardwareMonitor";
            this.Text = "Hardware Monitor";
            ((System.ComponentModel.ISupportInitialize)(this.CpuPerformanceCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiskDataGridView)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label CpuLabel;
        private System.Windows.Forms.Label CpuNameLabel;
        private System.Windows.Forms.ProgressBar CpuProgressBar;
        private System.Windows.Forms.Label CpuLoadLabel;
        private System.Windows.Forms.Label CpuCoresLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label RamLabel;
        private System.Windows.Forms.ProgressBar RamProgressBar;
        private System.Windows.Forms.Label RamAvailableLabel;
        private System.Windows.Forms.Label RamFreeLabel;
        private System.Diagnostics.PerformanceCounter CpuPerformanceCounter;
        private System.Windows.Forms.Button RamRefreshButton;
        private System.Windows.Forms.Label DiskLabel;
        private System.Windows.Forms.Label DiskCountLabel;
        private System.Windows.Forms.DataGridView DiskDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label GpuLabel;
        private System.Windows.Forms.Label GpuNameLabel;
        private System.Windows.Forms.Label GpuMemorylabel;
        private System.Windows.Forms.Label GpuDriverVersionLabel;
        private System.Windows.Forms.CheckBox InternetCheckBox;
        private System.Windows.Forms.Button InternetRefreshButton;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label OperatingSystemLabel;
        private System.Windows.Forms.Label ComputernameLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label OperatingSystemVersionLabel;
        private System.Windows.Forms.Label GpuResolutionLabel;
    }
}

