namespace AlarmClock
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            timerClock = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            lblClockHours = new Label();
            lblMintues = new Label();
            clockTimer = new System.Windows.Forms.Timer(components);
            lblSeconds = new Label();
            alarmHours = new TextBox();
            label3 = new Label();
            alarmMinutes = new TextBox();
            alarmBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 120F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(273, 26);
            label1.Name = "label1";
            label1.Size = new Size(100, 238);
            label1.TabIndex = 2;
            label1.Text = ":";
            // 
            // timerClock
            // 
            timerClock.Enabled = true;
            timerClock.Interval = 1000;
            timerClock.Tick += timerClock_Tick;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 120F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(640, 26);
            label2.Name = "label2";
            label2.Size = new Size(111, 238);
            label2.TabIndex = 7;
            label2.Text = ":";
            // 
            // lblClockHours
            // 
            lblClockHours.AutoSize = true;
            lblClockHours.BackColor = Color.Transparent;
            lblClockHours.Font = new Font("Segoe UI", 130F, FontStyle.Bold);
            lblClockHours.ForeColor = Color.CornflowerBlue;
            lblClockHours.Location = new Point(10, 26);
            lblClockHours.Name = "lblClockHours";
            lblClockHours.Size = new Size(297, 230);
            lblClockHours.TabIndex = 9;
            lblClockHours.Text = "00";
            // 
            // lblMintues
            // 
            lblMintues.AutoSize = true;
            lblMintues.BackColor = Color.Transparent;
            lblMintues.Font = new Font("Segoe UI", 130F, FontStyle.Bold);
            lblMintues.ForeColor = Color.CornflowerBlue;
            lblMintues.Location = new Point(367, 34);
            lblMintues.Name = "lblMintues";
            lblMintues.Size = new Size(297, 230);
            lblMintues.TabIndex = 11;
            lblMintues.Text = "00";
            // 
            // lblSeconds
            // 
            lblSeconds.AutoSize = true;
            lblSeconds.BackColor = Color.Transparent;
            lblSeconds.Font = new Font("Segoe UI", 130F, FontStyle.Bold);
            lblSeconds.ForeColor = Color.CornflowerBlue;
            lblSeconds.Location = new Point(738, 26);
            lblSeconds.Name = "lblSeconds";
            lblSeconds.Size = new Size(297, 230);
            lblSeconds.TabIndex = 12;
            lblSeconds.Text = "00";
            // 
            // alarmHours
            // 
            alarmHours.Font = new Font("Segoe UI", 50F, FontStyle.Bold);
            alarmHours.ForeColor = Color.CornflowerBlue;
            alarmHours.Location = new Point(367, 304);
            alarmHours.Name = "alarmHours";
            alarmHours.Size = new Size(100, 96);
            alarmHours.TabIndex = 13;
            alarmHours.Text = "00";
            alarmHours.TextChanged += alarmHours_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 50F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ActiveCaption;
            label3.Location = new Point(463, 304);
            label3.Name = "label3";
            label3.Size = new Size(56, 89);
            label3.TabIndex = 15;
            label3.Text = ":";
            // 
            // alarmMinutes
            // 
            alarmMinutes.Font = new Font("Segoe UI", 50F, FontStyle.Bold);
            alarmMinutes.ForeColor = Color.CornflowerBlue;
            alarmMinutes.Location = new Point(516, 304);
            alarmMinutes.Name = "alarmMinutes";
            alarmMinutes.Size = new Size(100, 96);
            alarmMinutes.TabIndex = 16;
            alarmMinutes.Text = "00";
            alarmMinutes.TextChanged += alarmMinutes_TextChanged;
            // 
            // alarmBtn
            // 
            alarmBtn.BackColor = Color.Red;
            alarmBtn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            alarmBtn.Location = new Point(463, 438);
            alarmBtn.Name = "alarmBtn";
            alarmBtn.Size = new Size(91, 52);
            alarmBtn.TabIndex = 17;
            alarmBtn.Text = "OFF";
            alarmBtn.UseVisualStyleBackColor = false;
            alarmBtn.Click += button1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1324, 604);
            Controls.Add(alarmBtn);
            Controls.Add(alarmMinutes);
            Controls.Add(label3);
            Controls.Add(alarmHours);
            Controls.Add(lblSeconds);
            Controls.Add(lblMintues);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(lblClockHours);
            Name = "MainForm";
            Text = "Alarm Clock";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private System.Windows.Forms.Timer timerClock;
        private Label label2;
        private Label lblClockHours;
        private Label lblClockMinutes;
        private System.Windows.Forms.Timer clockTimer;
        private Label lblSeconds;
        private Label lblMintues;
        private Label lblClockSeconds;
        private TextBox alarmHours;
        private Label label3;
        private TextBox alarmMinutes;
        private Button alarmBtn;
    }
}