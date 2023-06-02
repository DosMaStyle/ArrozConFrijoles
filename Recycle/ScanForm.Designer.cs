using System.Runtime.CompilerServices;

namespace Recycle
{
    partial class ScanForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        public static bool DetermPosition(Double UserLatitude, Double UserLongitude, bool position)
        {
            if (position)
            {
                return true;
            }
                return false;
        }

        public static bool LoadPhoto(String Photo, bool loading)
        {
            if (loading)
            {
                return true;
            }
                return false;
            
        }

        public static int FindRecycle(String Photo, int sign)
        {
            return sign;
        }

        public static bool CheckNet(bool netStatus)
        {
            if (netStatus)
            {
                return true;
            }
            return false;
        }

        public static int CheckCamera(int camera)
        {
            return camera;
        }

        public static String ScanPhoto(Double UserLatitude, Double UserLongitude, String Photo, bool position, bool loading, int camera, bool netStatus, int sign)
        {
            if (!DetermPosition(UserLatitude, UserLongitude, position))
            {
                return "Failed to determine position";
            }
            if (!LoadPhoto(Photo, loading))
            {
                return "Failed to load photo";
            }
            if (FindRecycle(Photo, sign) == 0)
            {
                return "Recycle not found";
            }
            if (FindRecycle(Photo, sign) == 1)
            {
                return "Scanning timed out";
            }
            if (!CheckNet(netStatus))
            {
                return "Lost Internet connection";
            }
            if (CheckCamera(camera) == 0)
            {
                return "Camera is unaviable";
            }
            if (CheckCamera(camera) == 1)
            {
                return "Camera is used by another app";
            }

            return "Success";
        }
        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // ScanForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "ScanForm";
            Text = "ScanForm";
            Load += ScanForm_Load;
            ResumeLayout(false);
        }

        #endregion
    }
}