using System;
using System.Collections.Generic;
using System.Text;

namespace WebCamera
{
    class WebCamera
    {
        // Constructur
        public WebCamera(IntPtr handle, int width, int height)
        {
            mControlPtr = handle;
            mWidth = width;
            mHeight = height;
        }

        // delegate for frame callback
        public delegate void RecievedFrameEventHandler(byte[] data);
        public event RecievedFrameEventHandler RecievedFrame;

        private IntPtr lwndC; // Holds the unmanaged handle of the control
        private IntPtr mControlPtr; // Holds the managed pointer of the control
        private int mWidth;
        private int mHeight;

        private showVideo.FrameEventHandler mFrameEventHandler; // Delegate instance for the frame callback - must keep alive! gc should NOT collect it

        // Close the web camera
        public void CloseWebcam()
        {
            this.capDriverDisconnect(this.lwndC);
        }

        // start the web camera
        public void StartWebCam()
        {
            byte[] lpszName = new byte[100];
            byte[] lpszVer = new byte[100];

            showVideo.capGetDriverDescriptionA(0, lpszName, 100, lpszVer, 100);
            this.lwndC = showVideo.capCreateCaptureWindowA(lpszName, showVideo.WS_VISIBLE + showVideo.WS_CHILD, 0, 0, mWidth, mHeight, mControlPtr, 0);

            if (this.capDriverConnect(this.lwndC, 0))
            {
                this.capPreviewRate(this.lwndC, 66);
                this.capPreview(this.lwndC, true);
                showVideo.BITMAPINFO bitmapinfo = new showVideo.BITMAPINFO();
                bitmapinfo.bmiHeader.biSize = showVideo.SizeOf(bitmapinfo.bmiHeader);
                bitmapinfo.bmiHeader.biWidth = 352;
                bitmapinfo.bmiHeader.biHeight = 288;
                bitmapinfo.bmiHeader.biPlanes = 1;
                bitmapinfo.bmiHeader.biBitCount = 24;
                this.capSetVideoFormat(this.lwndC, ref bitmapinfo, showVideo.SizeOf(bitmapinfo));
                this.mFrameEventHandler = new showVideo.FrameEventHandler(FrameCallBack);
                this.capSetCallbackOnFrame(this.lwndC, this.mFrameEventHandler);
                showVideo.SetWindowPos(this.lwndC, 0, 0, 0, mWidth, mHeight, 6);
            }
        }

        // private functions
        private bool capDriverConnect(IntPtr lwnd, short i)
        {
            return showVideo.SendMessage(lwnd, showVideo.WM_CAP_DRIVER_CONNECT, i, 0);
        }

        private bool capDriverDisconnect(IntPtr lwnd)
        {
            return showVideo.SendMessage(lwnd, showVideo.WM_CAP_DRIVER_DISCONNECT, 0, 0);
        }

        private bool capPreview(IntPtr lwnd, bool f)
        {
            return showVideo.SendMessage(lwnd, showVideo.WM_CAP_SET_PREVIEW, f, 0);
        }

        private bool capPreviewRate(IntPtr lwnd, short wMS)
        {
            return showVideo.SendMessage(lwnd, showVideo.WM_CAP_SET_PREVIEWRATE, wMS, 0);
        }

        private bool capSetCallbackOnFrame(IntPtr lwnd, showVideo.FrameEventHandler lpProc)
        {
            return showVideo.SendMessage(lwnd, showVideo.WM_CAP_SET_CALLBACK_FRAME, 0, lpProc);
        }

        private bool capSetVideoFormat(IntPtr hCapWnd, ref showVideo.BITMAPINFO BmpFormat, int CapFormatSize)
        {
            return showVideo.SendMessage(hCapWnd, showVideo.WM_CAP_SET_VIDEOFORMAT, CapFormatSize, ref BmpFormat);
        }

        private void FrameCallBack(IntPtr lwnd, IntPtr lpVHdr)
        {
            showVideo.VIDEOHDR videoHeader = new showVideo.VIDEOHDR();
            byte[] VideoData;
            videoHeader = (showVideo.VIDEOHDR)showVideo.GetStructure(lpVHdr, videoHeader);
            VideoData = new byte[videoHeader.dwBytesUsed];
            showVideo.Copy(videoHeader.lpData, VideoData);
            if (this.RecievedFrame != null)
                this.RecievedFrame(VideoData);
        }

    }
}
