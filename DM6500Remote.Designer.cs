namespace DM6500RemoteOld
{
    partial class DM6500Remote
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
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.FileName = new System.Windows.Forms.TextBox();
            this.DelayLable = new System.Windows.Forms.Label();
            this.AmounLabel = new System.Windows.Forms.Label();
            this.Delay = new System.Windows.Forms.TextBox();
            this.Amount = new System.Windows.Forms.TextBox();
            this.FolderPath = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.MeasurementPanel = new System.Windows.Forms.Panel();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.CurrentLabel = new System.Windows.Forms.Label();
            this.Voltage = new System.Windows.Forms.TextBox();
            this.Current = new System.Windows.Forms.TextBox();
            this.Stop = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.RefreshTimer = new System.Windows.Forms.Timer(this.components);
            this.SettingsPanel.SuspendLayout();
            this.MeasurementPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.Controls.Add(this.FileName);
            this.SettingsPanel.Controls.Add(this.DelayLable);
            this.SettingsPanel.Controls.Add(this.AmounLabel);
            this.SettingsPanel.Controls.Add(this.Delay);
            this.SettingsPanel.Controls.Add(this.Amount);
            this.SettingsPanel.Controls.Add(this.FolderPath);
            this.SettingsPanel.Controls.Add(this.Start);
            this.SettingsPanel.Location = new System.Drawing.Point(0, 0);
            this.SettingsPanel.Margin = new System.Windows.Forms.Padding(2);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(599, 176);
            this.SettingsPanel.TabIndex = 0;
            // 
            // FileName
            // 
            this.FileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FileName.Location = new System.Drawing.Point(430, 80);
            this.FileName.Margin = new System.Windows.Forms.Padding(2);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(150, 31);
            this.FileName.TabIndex = 7;
            this.FileName.Text = "File_Name";
            // 
            // DelayLable
            // 
            this.DelayLable.AutoSize = true;
            this.DelayLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DelayLable.Location = new System.Drawing.Point(20, 140);
            this.DelayLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DelayLable.Name = "DelayLable";
            this.DelayLable.Size = new System.Drawing.Size(266, 25);
            this.DelayLable.TabIndex = 5;
            this.DelayLable.Text = "Delay_between_measures";
            // 
            // AmounLabel
            // 
            this.AmounLabel.AutoSize = true;
            this.AmounLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmounLabel.Location = new System.Drawing.Point(20, 80);
            this.AmounLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AmounLabel.Name = "AmounLabel";
            this.AmounLabel.Size = new System.Drawing.Size(221, 25);
            this.AmounLabel.TabIndex = 4;
            this.AmounLabel.Text = "Amount_of_measures";
            // 
            // Delay
            // 
            this.Delay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delay.Location = new System.Drawing.Point(300, 140);
            this.Delay.Margin = new System.Windows.Forms.Padding(2);
            this.Delay.Name = "Delay";
            this.Delay.Size = new System.Drawing.Size(100, 31);
            this.Delay.TabIndex = 3;
            this.Delay.Text = "0,5";
            // 
            // Amount
            // 
            this.Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Amount.Location = new System.Drawing.Point(300, 80);
            this.Amount.Margin = new System.Windows.Forms.Padding(2);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(100, 31);
            this.Amount.TabIndex = 2;
            this.Amount.Text = "100";
            // 
            // FolderPath
            // 
            this.FolderPath.BackColor = System.Drawing.Color.PowderBlue;
            this.FolderPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FolderPath.Location = new System.Drawing.Point(20, 20);
            this.FolderPath.Margin = new System.Windows.Forms.Padding(0);
            this.FolderPath.Name = "FolderPath";
            this.FolderPath.Size = new System.Drawing.Size(559, 35);
            this.FolderPath.TabIndex = 1;
            this.FolderPath.Text = "Path";
            this.FolderPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FolderPath.UseVisualStyleBackColor = false;
            this.FolderPath.Click += new System.EventHandler(this.Path_Click);
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.LawnGreen;
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Start.Location = new System.Drawing.Point(480, 140);
            this.Start.Margin = new System.Windows.Forms.Padding(0);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(100, 35);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // MeasurementPanel
            // 
            this.MeasurementPanel.Controls.Add(this.ProgressBar);
            this.MeasurementPanel.Controls.Add(this.label4);
            this.MeasurementPanel.Controls.Add(this.CurrentLabel);
            this.MeasurementPanel.Controls.Add(this.Voltage);
            this.MeasurementPanel.Controls.Add(this.Current);
            this.MeasurementPanel.Controls.Add(this.Stop);
            this.MeasurementPanel.Enabled = false;
            this.MeasurementPanel.Location = new System.Drawing.Point(0, 180);
            this.MeasurementPanel.Margin = new System.Windows.Forms.Padding(2);
            this.MeasurementPanel.Name = "MeasurementPanel";
            this.MeasurementPanel.Size = new System.Drawing.Size(599, 125);
            this.MeasurementPanel.TabIndex = 1;
            // 
            // ProgressBar
            // 
            this.ProgressBar.BackColor = System.Drawing.Color.Tomato;
            this.ProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ProgressBar.Location = new System.Drawing.Point(330, 20);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(250, 30);
            this.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ProgressBar.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(20, 80);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Voltage";
            // 
            // CurrentLabel
            // 
            this.CurrentLabel.AutoSize = true;
            this.CurrentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentLabel.Location = new System.Drawing.Point(20, 20);
            this.CurrentLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CurrentLabel.Name = "CurrentLabel";
            this.CurrentLabel.Size = new System.Drawing.Size(83, 25);
            this.CurrentLabel.TabIndex = 6;
            this.CurrentLabel.Text = "Current";
            // 
            // Voltage
            // 
            this.Voltage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Voltage.Location = new System.Drawing.Point(140, 80);
            this.Voltage.Margin = new System.Windows.Forms.Padding(2);
            this.Voltage.Name = "Voltage";
            this.Voltage.Size = new System.Drawing.Size(150, 31);
            this.Voltage.TabIndex = 2;
            this.Voltage.Text = "0";
            // 
            // Current
            // 
            this.Current.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Current.Location = new System.Drawing.Point(140, 20);
            this.Current.Margin = new System.Windows.Forms.Padding(2);
            this.Current.Name = "Current";
            this.Current.Size = new System.Drawing.Size(150, 31);
            this.Current.TabIndex = 1;
            this.Current.Text = "0";
            // 
            // Stop
            // 
            this.Stop.BackColor = System.Drawing.Color.LightCoral;
            this.Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Stop.Location = new System.Drawing.Point(480, 80);
            this.Stop.Margin = new System.Windows.Forms.Padding(0);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(100, 35);
            this.Stop.TabIndex = 0;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = false;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.Location = new System.Drawing.Point(480, 320);
            this.Exit.Margin = new System.Windows.Forms.Padding(0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(100, 35);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // RefreshTimer
            // 
            this.RefreshTimer.Interval = 500;
            this.RefreshTimer.Tick += new System.EventHandler(this.RefreshTimer_Tick);
            // 
            // DM6500Remote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.MeasurementPanel);
            this.Controls.Add(this.SettingsPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DM6500Remote";
            this.Text = "DM6500Remote";
            this.Load += new System.EventHandler(this.DM6500Remote_Load);
            this.SettingsPanel.ResumeLayout(false);
            this.SettingsPanel.PerformLayout();
            this.MeasurementPanel.ResumeLayout(false);
            this.MeasurementPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SettingsPanel;
        private System.Windows.Forms.Label DelayLable;
        private System.Windows.Forms.Label AmounLabel;
        private System.Windows.Forms.TextBox Delay;
        private System.Windows.Forms.TextBox Amount;
        private System.Windows.Forms.Button FolderPath;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Panel MeasurementPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label CurrentLabel;
        private System.Windows.Forms.TextBox Voltage;
        private System.Windows.Forms.TextBox Current;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TextBox FileName;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Timer RefreshTimer;
    }
}

