namespace MMPlayer
{
    partial class MainView
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
            this.MainAction = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Volme = new System.Windows.Forms.TrackBar();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Volme)).BeginInit();
            this.SuspendLayout();
            // 
            // MainAction
            // 
            this.MainAction.AccessibleName = "MainAction";
            this.MainAction.Location = new System.Drawing.Point(302, 223);
            this.MainAction.Name = "MainAction";
            this.MainAction.Size = new System.Drawing.Size(75, 23);
            this.MainAction.TabIndex = 0;
            this.MainAction.Text = "Play/Pause";
            this.MainAction.UseVisualStyleBackColor = true;
            this.MainAction.Click += new System.EventHandler(this.PlayPause_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(302, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Open";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // Volme
            // 
            this.Volme.Location = new System.Drawing.Point(233, 252);
            this.Volme.Maximum = 100;
            this.Volme.Name = "Volme";
            this.Volme.Size = new System.Drawing.Size(225, 45);
            this.Volme.TabIndex = 2;
            this.Volme.Scroll += new System.EventHandler(this.onVolumeChange);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(383, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Skip";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Skip_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(221, 223);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Revert";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Revert_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 435);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Volme);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.MainAction);
            this.Name = "MainView";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Volme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MainAction;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TrackBar Volme;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}

