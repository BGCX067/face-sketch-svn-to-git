namespace WebCamera
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
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
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
            this.b_play = new System.Windows.Forms.Button();
            this.panelPreview = new System.Windows.Forms.Panel();
            this.b_stop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b_play
            // 
            this.b_play.Location = new System.Drawing.Point(280, 368);
            this.b_play.Name = "b_play";
            this.b_play.TabIndex = 0;
            this.b_play.Text = "&Play";
            this.b_play.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelPreview
            // 
            this.panelPreview.Location = new System.Drawing.Point(8, 8);
            this.panelPreview.Name = "panelPreview";
            this.panelPreview.Size = new System.Drawing.Size(344, 272);
            this.panelPreview.TabIndex = 1;
            // 
            // b_stop
            // 
            this.b_stop.Enabled = false;
            this.b_stop.Location = new System.Drawing.Point(360, 368);
            this.b_stop.Name = "b_stop";
            this.b_stop.TabIndex = 2;
            this.b_stop.Text = "&Stop";
            this.b_stop.Click += new System.EventHandler(this.b_stop_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(464, 413);
            this.Controls.Add(this.b_stop);
            this.Controls.Add(this.panelPreview);
            this.Controls.Add(this.b_play);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "GoodView test Web Camera";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
    }
}

