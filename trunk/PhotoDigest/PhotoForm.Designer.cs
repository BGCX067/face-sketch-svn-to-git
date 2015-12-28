namespace PhotoDigest
{
    partial class PhotoForm
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
            this.pictureBoxOri = new System.Windows.Forms.PictureBox();
            this.pictureBoxDig = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDig)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxOri
            // 
            this.pictureBoxOri.Location = new System.Drawing.Point(12, 37);
            this.pictureBoxOri.Name = "pictureBoxOri";
            this.pictureBoxOri.Size = new System.Drawing.Size(240, 240);
            this.pictureBoxOri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOri.TabIndex = 0;
            this.pictureBoxOri.TabStop = false;
            // 
            // pictureBoxDig
            // 
            this.pictureBoxDig.Location = new System.Drawing.Point(403, 37);
            this.pictureBoxDig.Name = "pictureBoxDig";
            this.pictureBoxDig.Size = new System.Drawing.Size(240, 240);
            this.pictureBoxDig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxDig.TabIndex = 1;
            this.pictureBoxDig.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Original Img:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(401, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Digested Img:";
            // 
            // PhotoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 289);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxDig);
            this.Controls.Add(this.pictureBoxOri);
            this.Name = "PhotoForm";
            this.Text = "Photo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDig)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxOri;
        private System.Windows.Forms.PictureBox pictureBoxDig;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

