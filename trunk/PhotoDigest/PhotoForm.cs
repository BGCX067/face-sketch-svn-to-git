using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PhotoDigest
{
    public partial class PhotoForm : Form
    {
        PortraitBitmap m_oOriBmp;
        PortraitBitmap m_oDigBmp;
        public PhotoForm()
        {
            InitializeComponent();

            m_oOriBmp = new PortraitBitmap("..\\..\\media\\HuCore.jpg");
            m_oDigBmp = new PortraitBitmap(m_oOriBmp);
            pictureBoxOri.Image = m_oOriBmp.GetBitmap();
            pictureBoxDig.Image = m_oDigBmp.GetBitmap();

            Point[] pPointArr = new Point[10];
            for (int i = 0; i < 10; i++)
            {
                pPointArr[i] = new Point(i * 10, (i * i + 10 * i));
            }
            m_oDigBmp.DrawLineList(pPointArr);
        }
    }
}