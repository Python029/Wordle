namespace Wordle
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.lblPlayed = new System.Windows.Forms.Label();
            this.lblPercent = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblStreak = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPlayed
            // 
            this.lblPlayed.AutoSize = true;
            this.lblPlayed.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayed.Font = new System.Drawing.Font("Comfortaa", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlayed.Location = new System.Drawing.Point(130, 51);
            this.lblPlayed.Name = "lblPlayed";
            this.lblPlayed.Size = new System.Drawing.Size(37, 45);
            this.lblPlayed.TabIndex = 0;
            this.lblPlayed.Text = "0";
            this.lblPlayed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.BackColor = System.Drawing.Color.Transparent;
            this.lblPercent.Font = new System.Drawing.Font("Comfortaa", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPercent.Location = new System.Drawing.Point(167, 51);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(90, 45);
            this.lblPercent.TabIndex = 1;
            this.lblPercent.Text = "100%";
            this.lblPercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.BackColor = System.Drawing.Color.Transparent;
            this.lblMax.Font = new System.Drawing.Font("Comfortaa", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMax.Location = new System.Drawing.Point(322, 51);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(37, 45);
            this.lblMax.TabIndex = 2;
            this.lblMax.Text = "0";
            this.lblMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStreak
            // 
            this.lblStreak.AutoSize = true;
            this.lblStreak.BackColor = System.Drawing.Color.Transparent;
            this.lblStreak.Font = new System.Drawing.Font("Comfortaa", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStreak.Location = new System.Drawing.Point(258, 51);
            this.lblStreak.Name = "lblStreak";
            this.lblStreak.Size = new System.Drawing.Size(37, 45);
            this.lblStreak.TabIndex = 3;
            this.lblStreak.Text = "0";
            this.lblStreak.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(453, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(22, 25);
            this.panel1.TabIndex = 4;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comfortaa", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(61, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 45);
            this.label1.TabIndex = 5;
            this.label1.Text = "Press Esc to reset stats";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Wordle.Properties.Resources.stats_back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(491, 232);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblStreak);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblPercent);
            this.Controls.Add(this.lblPlayed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stats";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form3_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblPlayed;
        private Label lblPercent;
        private Label lblMax;
        private Label lblStreak;
        private Panel panel1;
        private Label label1;
    }
}