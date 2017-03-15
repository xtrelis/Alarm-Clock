namespace AlarmClock
{
    partial class frmWMP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWMP));
            this.myWMPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnSnooze = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.myWMPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // myWMPlayer
            // 
            this.myWMPlayer.Enabled = true;
            this.myWMPlayer.Location = new System.Drawing.Point(28, 11);
            this.myWMPlayer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.myWMPlayer.Name = "myWMPlayer";
            this.myWMPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("myWMPlayer.OcxState")));
            this.myWMPlayer.Size = new System.Drawing.Size(408, 351);
            this.myWMPlayer.TabIndex = 0;
            // 
            // btnSnooze
            // 
            this.btnSnooze.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnSnooze.Location = new System.Drawing.Point(183, 370);
            this.btnSnooze.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSnooze.Name = "btnSnooze";
            this.btnSnooze.Size = new System.Drawing.Size(100, 30);
            this.btnSnooze.TabIndex = 1;
            this.btnSnooze.Text = "Snooze";
            this.btnSnooze.UseVisualStyleBackColor = true;
            this.btnSnooze.Click += new System.EventHandler(this.btnSnooze_Click);
            // 
            // frmWMP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 411);
            this.Controls.Add(this.btnSnooze);
            this.Controls.Add(this.myWMPlayer);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmWMP";
            this.Text = "WMP";
            this.Shown += new System.EventHandler(this.frmWMP_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.myWMPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer myWMPlayer;
        private System.Windows.Forms.Button btnSnooze;
    }
}