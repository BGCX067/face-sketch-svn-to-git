using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace PhotoDigest
{
    partial class PortraitBitmap
    {
        public bool IdentifyHead()
        {
            bool ret = false;
            
            return ret;
        }

        public bool IdentifyEye()
        {
            bool ret = false;
            if (!IdentifyHead())
                return ret;
            return ret;
        }

        public bool IdentifyMouse()
        {
            bool ret = false;
            if (!IdentifyHead())
                return ret;
            return ret;
        }

        public bool IdentifyNose()
        {
            bool ret = false;
            if (!IdentifyHead())
                return ret;
            return ret;
        }
    }
}