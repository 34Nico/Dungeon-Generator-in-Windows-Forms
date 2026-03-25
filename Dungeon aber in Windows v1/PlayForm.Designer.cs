namespace Dungeon_aber_in_Windows_v1
{
    partial class PlayForm
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
            this.panelStats = new System.Windows.Forms.Panel();
            this.panelGame = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelStats
            // 
            this.panelStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStats.Location = new System.Drawing.Point(0, 0);
            this.panelStats.Name = "panelStats";
            this.panelStats.Size = new System.Drawing.Size(784, 100);
            this.panelStats.TabIndex = 0;
            // 
            // panelGame
            // 
            this.panelGame.AutoScroll = true;
            this.panelGame.CausesValidation = false;
            this.panelGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGame.Location = new System.Drawing.Point(0, 100);
            this.panelGame.Name = "panelGame";
            this.panelGame.Size = new System.Drawing.Size(784, 661);
            this.panelGame.TabIndex = 1;
            // 
            // PlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.panelGame);
            this.Controls.Add(this.panelStats);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PlayForm";
            this.Text = "Spiel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.PlayForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelStats;
        private System.Windows.Forms.Panel panelGame;
    }
}