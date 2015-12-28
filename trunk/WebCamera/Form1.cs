using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace WebCamera
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Panel panelPreview;
        private System.Windows.Forms.Button b_play;
        private System.Windows.Forms.Button b_stop;

        WebCamera wc;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            b_play.Enabled = false;
            b_stop.Enabled = true;
            panelPreview.Size = new Size(330, 330);
            wc = new WebCamera(panelPreview.Handle, panelPreview.Width, panelPreview.Height);
            wc.StartWebCam();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            b_play.Enabled = false;
            b_stop.Enabled = true;
            panelPreview.Size = new Size(330, 330);
            wc = new WebCamera(panelPreview.Handle, panelPreview.Width, panelPreview.Height);
            wc.StartWebCam();
        }

        private void b_stop_Click(object sender, System.EventArgs e)
        {
            b_play.Enabled = true;
            b_stop.Enabled = false;
            wc.CloseWebcam();
        }

    }
}