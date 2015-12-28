using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace PhotoDigest
{
    partial class PortraitBitmap
    {
        public void DrawLineList(Point[] pPointArr)
        {
            if (pPointArr.Length < 2)
                return;
            for (int i = 0; i < pPointArr.Length - 1; i++)
            {
                DrawLine(pPointArr[i], pPointArr[i + 1]);
            }
        }
        //Bresenham
        public void DrawLine(int x_ori, int y_ori, int x_dest, int y_dest)
        {
            Point pPix = new Point();
            int l = x_dest - x_ori;
            if( l < 2)
                return ;
            for (int x = x_ori; x < x_dest; x++)
            {
                int dX = x - x_ori;
                pPix.X = x;
                pPix.Y = ((l - dX) * y_ori + dX * y_dest) / l;
                m_oBitmap.SetPixel(pPix.X, pPix.Y, Color.White);
            }
        }
        public void DrawLine(Point pSrc, Point pDst)
        {
            DrawLine(pSrc.X, pSrc.Y, pDst.X, pDst.Y);
        }
        //     ---------|
        //      |       |
        //      |       |
        //      | --------
        public void DrawRect(int x, int y, int width, int height, int pixel)
        {
            //upper
            for (int i = x; i < x + width; i++)
                for (int j = 0; j < pixel; j++)
                    m_oBitmap.SetPixel(i, y + j, Color.White);
            //down
            for (int i = x + pixel; i < x + width + pixel; i++)
                for (int j = 0; j < pixel; j++)
                    m_oBitmap.SetPixel(i, y + height + j, Color.White);
            //left
            for (int i = y + pixel; i < y + height + pixel; i++)
                for (int j = 0; j < pixel; j++)
                    m_oBitmap.SetPixel(x + j, i, Color.White);
            //right
            for (int i = y; i < y + height; i++)
                for (int j = 0; j < pixel; j++)
                    m_oBitmap.SetPixel(x + width + j, i, Color.White);
        }

        //Bresenham
        //8 devide circle
        public void DrawCircle(int x, int y, int radius)
        {
            int cycle = (int)(radius * 0.7071);
            Point[] pPointArr = new Point[cycle * 8];
            pPointArr[0] = new Point(0, radius);
            for (int i = 1; i < cycle; i++)
            {
                pPointArr[i] = new Point(pPointArr[i - 1].X, pPointArr[i - 1].Y);
                pPointArr[i].X += 1;
                if (pPointArr[i].X * pPointArr[i].X + pPointArr[i].Y * pPointArr[i].Y
                    > radius * radius)
                {
                    pPointArr[i].Y -= 1;
                }
                pPointArr[i + cycle * 1] = new Point(pPointArr[i].Y, pPointArr[i].X);
                pPointArr[i + cycle * 2] = new Point(-pPointArr[i].Y, pPointArr[i].X);
                pPointArr[i + cycle * 3] = new Point(-pPointArr[i].X, pPointArr[i].Y);

                pPointArr[i + cycle * 4] = new Point(pPointArr[i].X, -pPointArr[i].Y);
                pPointArr[i + cycle * 5] = new Point(pPointArr[i].Y, -pPointArr[i].X);
                pPointArr[i + cycle * 6] = new Point(-pPointArr[i].Y, -pPointArr[i].X);
                pPointArr[i + cycle * 7] = new Point(-pPointArr[i].X, -pPointArr[i].Y);
            }
            for (int i = 0; i < cycle * 8; i++)
            {
                m_oBitmap.SetPixel(pPointArr[i].X + x, pPointArr[i].Y + y, Color.White);
            }
        }
    }
}