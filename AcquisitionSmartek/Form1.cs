using System;
using System.Drawing;
using System.Drawing.Imaging;

using System.Windows.Forms;
using System.Threading;

namespace AcquisitionSmartek
{
    public partial class Form1 : Form
    {
        smcs.IDevice m_device;
        Rectangle m_rect;
        PixelFormat m_pixelFormat;
        UInt32 m_pixelType;
        bool bout_state_n_precedent = false;

        private int m_seuil;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                portUsb.Open();
            }
            catch
            {
                MessageBox.Show("Warning : USB Port Open failed, arduino is not connected ?");
            }
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                portUsb.Close();
            }
            catch
            {
                MessageBox.Show("Warning : USB Port Close failed, arduino is not connected ?");
            }
        }

        private void boutInit_Click(object sender, EventArgs e)
        {
            bool cameraConnected = false;

            // initialize GigEVision API
            smcs.CameraSuite.InitCameraAPI();
            smcs.ICameraAPI smcsVisionApi = smcs.CameraSuite.GetCameraAPI();

            if (!smcsVisionApi.IsUsingKernelDriver())
            {
                MessageBox.Show("Warning: Smartek Filter Driver not loaded.");
            }

            // discover all devices on network
            smcsVisionApi.FindAllDevices(3.0);
            smcs.IDevice[] devices = smcsVisionApi.GetAllDevices();
            //MessageBox.Show(devices.Length.ToString());
            if (devices.Length > 0)
            {
                // take first device in list
                m_device = devices[0];

                // uncomment to use specific model
                //for (int i = 0; i < devices.Length; i++)
                //{
                //    if (devices[i].GetModelName() == "GC652M")
                //    {
                //        m_device = devices[i];
                //    }
                //}

                // to change number of images in image buffer from default 10 images 
                // call SetImageBufferFrameCount() method before Connect() method
                //m_device.SetImageBufferFrameCount(20);

                if (m_device != null && m_device.Connect())
                {
                    this.lblConnection.BackColor = Color.LimeGreen;
                    this.lblConnection.Text = "Connection établie";
                    this.lblAdrIP.BackColor = Color.LimeGreen;
                    this.lblAdrIP.Text = "Adresse IP : " + Common.IpAddrToString(m_device.GetIpAddress());
                    this.lblNomCamera.Text = m_device.GetManufacturerName() + " : " + m_device.GetModelName();

                    // disable trigger mode
                    bool status = m_device.SetStringNodeValue("TriggerMode", "Off");
                    // set continuous acquisition mode
                    status = m_device.SetStringNodeValue("AcquisitionMode", "Continuous");
                    // start acquisition
                    status = m_device.SetIntegerNodeValue("TLParamsLocked", 1);
                    status = m_device.CommandNodeExecute("AcquisitionStart");
                    cameraConnected = true;
                }
            }

            if (!cameraConnected)
            {
                this.lblAdrIP.BackColor = Color.Red;
                this.lblAdrIP.Text = "Erreur de connection!";
            }
        }

        private void boutAcquisition_Click(object sender, EventArgs e)
        {
            timAcq.Start();
        }

        private void boutStop_Click(object sender, EventArgs e)
        {
            timAcq.Stop();
        }

        private void timAcq_Tick(object sender, EventArgs e)
        {
            if (m_device != null && m_device.IsConnected())
            {
                if (!m_device.IsBufferEmpty())
                {
                    smcs.IImageInfo imageInfo = null;
                    m_device.GetImageInfo(ref imageInfo);
                    if (imageInfo != null)
                    {
                        Bitmap bitmap = (Bitmap)this.pbImage.Image;
                        BitmapData bd = null;

                        ImageUtils.CopyToBitmap(imageInfo, ref bitmap, ref bd, ref m_pixelFormat, ref m_rect, ref m_pixelType);
                        //-------------------------------------------------------------------
                        //if (m_pixelFormat == PixelFormat.Format8bppIndexed)
                        //{
                        //    // set palette
                        //    ColorPalette palette = bitmap.Palette;
                        //    for (int i = 0; i < 256; i++)
                        //    {
                        //        palette.Entries[i] = Color.FromArgb(255 - i, 255 - i, 255 - i);
                        //    }
                        //    bitmap.Palette = palette;
                        //}
                        //-------------------------------------------------------------------
                        if (bitmap != null)
                        {
                            //this.pbImage.Height = bitmap.Height;
                            //this.pbImage.Width = bitmap.Width;
                            this.pbImage.Image = bitmap;
                        }

                        // display image
                        if (bd != null)
                            bitmap.UnlockBits(bd);

                        this.pbImage.Invalidate();
                    }
                    // remove (pop) image from image buffer
                    m_device.PopImage(imageInfo);
                    // empty buffer
                    m_device.ClearImageBuffer();
                }
            }
        }

        private void boutQuit_Click(object sender, EventArgs e)
        {
            timAcq.Stop();
            if (m_device != null && m_device.IsConnected())
            {
                m_device.CommandNodeExecute("AcquisitionStop");
                m_device.SetIntegerNodeValue("TLParamsLocked", 0);
                m_device.Disconnect();
            }

            smcs.CameraSuite.ExitCameraAPI();

            this.Close();
        }

        private void portUsb_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            
            string s = portUsb.ReadLine();

            bool bout_state = false;
            if (s == "0\r")
            {
                bout_state = false;
            }
            else if (s == "1\r")
            {
                bout_state = true;
            }
            
            if (bout_state == true && bout_state_n_precedent == false)
            {
                try
                {
                    Bitmap bitmap_pbimage = (Bitmap)this.pbImage.Image;
                    pbTraitement.Image = bitmap_pbimage;
                }
                catch
                {

                }
                
            }
            bout_state_n_precedent = bout_state;


        }

        private void boutTraitement_Click(object sender, EventArgs e)
        {
            Bitmap bitmap_pbimage = (Bitmap)this.pbImage.Image;

            


            pbTraitement.Image = bitmap_pbimage;
        }


    }
}
