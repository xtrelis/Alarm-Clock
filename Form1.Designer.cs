namespace AlarmClock
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.myLabel = new System.Windows.Forms.Label();
            this.chkOnOff = new System.Windows.Forms.CheckBox();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pickerDateTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // myLabel
            // 
            this.myLabel.AutoSize = true;
            this.myLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.myLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.myLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.myLabel.Location = new System.Drawing.Point(11, 9);
            this.myLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.myLabel.Name = "myLabel";
            this.myLabel.Size = new System.Drawing.Size(66, 29);
            this.myLabel.TabIndex = 0;
            this.myLabel.Text = "Ώρα";
            this.myLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkOnOff
            // 
            this.chkOnOff.AutoSize = true;
            this.chkOnOff.Location = new System.Drawing.Point(115, 102);
            this.chkOnOff.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkOnOff.Name = "chkOnOff";
            this.chkOnOff.Size = new System.Drawing.Size(59, 17);
            this.chkOnOff.TabIndex = 1;
            this.chkOnOff.Text = "On/Off";
            this.chkOnOff.UseVisualStyleBackColor = true;
            // 
            // btnAbout
            // 
            this.btnAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnAbout.Location = new System.Drawing.Point(11, 144);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(100, 30);
            this.btnAbout.TabIndex = 6;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnExit.Location = new System.Drawing.Point(183, 144);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 30);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pickerDateTime
            // 
            this.pickerDateTime.CustomFormat = "dd/MM/yyyy h:mm tt";
            this.pickerDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.pickerDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pickerDateTime.Location = new System.Drawing.Point(61, 53);
            this.pickerDateTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pickerDateTime.Name = "pickerDateTime";
            this.pickerDateTime.Size = new System.Drawing.Size(180, 24);
            this.pickerDateTime.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 211);
            this.Controls.Add(this.pickerDateTime);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.chkOnOff);
            this.Controls.Add(this.myLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Alarm Clock";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label myLabel;
        private System.Windows.Forms.CheckBox chkOnOff;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DateTimePicker pickerDateTime;
    }
}

