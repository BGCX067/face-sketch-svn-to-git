using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace PhotoDigest
{
    public partial class PortraitBitmap
    {
        private Bitmap m_oBitmap;
        public PortraitBitmap(string path) 
        {
            m_oBitmap = new Bitmap(path);
        }

        public PortraitBitmap(PortraitBitmap portraitMap)
        {
            m_oBitmap = (Bitmap)portraitMap.GetBitmap().Clone();
        }

        public Bitmap GetBitmap()
        {
            return m_oBitmap;
        }

    }
}
