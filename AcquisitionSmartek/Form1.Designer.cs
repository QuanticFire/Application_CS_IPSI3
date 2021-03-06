namespace AcquisitionSmartek
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlImage = new System.Windows.Forms.Panel();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.boutInit = new System.Windows.Forms.Button();
            this.boutAcquisition = new System.Windows.Forms.Button();
            this.boutQuit = new System.Windows.Forms.Button();
            this.timAcq = new System.Windows.Forms.Timer(this.components);
            this.lblConnection = new System.Windows.Forms.Label();
            this.gbCamera = new System.Windows.Forms.GroupBox();
            this.lblNomCamera = new System.Windows.Forms.Label();
            this.lblAdrIP = new System.Windows.Forms.Label();
            this.boutStop = new System.Windows.Forms.Button();
            this.portUsb = new System.IO.Ports.SerialPort(this.components);
            this.pbTraitement = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.boutTraitement = new System.Windows.Forms.Button();
            this.pnlImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.gbCamera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTraitement)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlImage
            // 
            this.pnlImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlImage.AutoScroll = true;
            this.pnlImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlImage.Controls.Add(this.pbImage);
            this.pnlImage.Location = new System.Drawing.Point(315, 13);
            this.pnlImage.Name = "pnlImage";
            this.pnlImage.Size = new System.Drawing.Size(484, 443);
            this.pnlImage.TabIndex = 0;
            // 
            // pbImage
            // 
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbImage.Location = new System.Drawing.Point(0, 0);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(482, 441);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // boutInit
            // 
            this.boutInit.Location = new System.Drawing.Point(12, 13);
            this.boutInit.Name = "boutInit";
            this.boutInit.Size = new System.Drawing.Size(75, 23);
            this.boutInit.TabIndex = 1;
            this.boutInit.Text = "Init";
            this.boutInit.UseVisualStyleBackColor = true;
            this.boutInit.Click += new System.EventHandler(this.boutInit_Click);
            // 
            // boutAcquisition
            // 
            this.boutAcquisition.Location = new System.Drawing.Point(12, 181);
            this.boutAcquisition.Name = "boutAcquisition";
            this.boutAcquisition.Size = new System.Drawing.Size(75, 23);
            this.boutAcquisition.TabIndex = 2;
            this.boutAcquisition.Text = "Acquisition";
            this.boutAcquisition.UseVisualStyleBackColor = true;
            this.boutAcquisition.Click += new System.EventHandler(this.boutAcquisition_Click);
            // 
            // boutQuit
            // 
            this.boutQuit.Location = new System.Drawing.Point(12, 322);
            this.boutQuit.Name = "boutQuit";
            this.boutQuit.Size = new System.Drawing.Size(75, 23);
            this.boutQuit.TabIndex = 3;
            this.boutQuit.Text = "Fermer";
            this.boutQuit.UseVisualStyleBackColor = true;
            this.boutQuit.Click += new System.EventHandler(this.boutQuit_Click);
            // 
            // timAcq
            // 
            this.timAcq.Interval = 20;
            this.timAcq.Tick += new System.EventHandler(this.timAcq_Tick);
            // 
            // lblConnection
            // 
            this.lblConnection.AutoSize = true;
            this.lblConnection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblConnection.Location = new System.Drawing.Point(11, 21);
            this.lblConnection.Name = "lblConnection";
            this.lblConnection.Size = new System.Drawing.Size(114, 13);
            this.lblConnection.TabIndex = 4;
            this.lblConnection.Text = "Connection en cours...";
            // 
            // gbCamera
            // 
            this.gbCamera.Controls.Add(this.lblNomCamera);
            this.gbCamera.Controls.Add(this.lblAdrIP);
            this.gbCamera.Controls.Add(this.lblConnection);
            this.gbCamera.Location = new System.Drawing.Point(12, 53);
            this.gbCamera.Name = "gbCamera";
            this.gbCamera.Size = new System.Drawing.Size(280, 108);
            this.gbCamera.TabIndex = 5;
            this.gbCamera.TabStop = false;
            this.gbCamera.Text = "Caméra ";
            // 
            // lblNomCamera
            // 
            this.lblNomCamera.AutoSize = true;
            this.lblNomCamera.BackColor = System.Drawing.SystemColors.Control;
            this.lblNomCamera.Location = new System.Drawing.Point(11, 73);
            this.lblNomCamera.Name = "lblNomCamera";
            this.lblNomCamera.Size = new System.Drawing.Size(43, 13);
            this.lblNomCamera.TabIndex = 7;
            this.lblNomCamera.Text = "Camera";
            // 
            // lblAdrIP
            // 
            this.lblAdrIP.AutoSize = true;
            this.lblAdrIP.BackColor = System.Drawing.SystemColors.Control;
            this.lblAdrIP.Location = new System.Drawing.Point(11, 47);
            this.lblAdrIP.Name = "lblAdrIP";
            this.lblAdrIP.Size = new System.Drawing.Size(100, 13);
            this.lblAdrIP.TabIndex = 6;
            this.lblAdrIP.Text = "Adresse IP : 0.0.0.0";
            // 
            // boutStop
            // 
            this.boutStop.Location = new System.Drawing.Point(110, 181);
            this.boutStop.Name = "boutStop";
            this.boutStop.Size = new System.Drawing.Size(75, 23);
            this.boutStop.TabIndex = 6;
            this.boutStop.Text = "Arret";
            this.boutStop.UseVisualStyleBackColor = true;
            this.boutStop.Click += new System.EventHandler(this.boutStop_Click);
            // 
            // portUsb
            // 
            this.portUsb.PortName = "COM3";
            this.portUsb.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.portUsb_DataReceived);
            // 
            // pbTraitement
            // 
            this.pbTraitement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbTraitement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbTraitement.Location = new System.Drawing.Point(0, 0);
            this.pbTraitement.Name = "pbTraitement";
            this.pbTraitement.Size = new System.Drawing.Size(482, 441);
            this.pbTraitement.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTraitement.TabIndex = 0;
            this.pbTraitement.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pbTraitement);
            this.panel1.Location = new System.Drawing.Point(928, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 443);
            this.panel1.TabIndex = 1;
            // 
            // boutTraitement
            // 
            this.boutTraitement.Location = new System.Drawing.Point(805, 211);
            this.boutTraitement.Name = "boutTraitement";
            this.boutTraitement.Size = new System.Drawing.Size(117, 28);
            this.boutTraitement.TabIndex = 8;
            this.boutTraitement.Text = "Traitement";
            this.boutTraitement.UseVisualStyleBackColor = true;
            this.boutTraitement.Click += new System.EventHandler(this.boutTraitement_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1453, 638);
            this.ControlBox = false;
            this.Controls.Add(this.boutTraitement);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.boutStop);
            this.Controls.Add(this.gbCamera);
            this.Controls.Add(this.boutQuit);
            this.Controls.Add(this.boutAcquisition);
            this.Controls.Add(this.boutInit);
            this.Controls.Add(this.pnlImage);
            this.Name = "Form1";
            this.Text = "Acquisition SMARTEK";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.gbCamera.ResumeLayout(false);
            this.gbCamera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTraitement)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlImage;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button boutInit;
        private System.Windows.Forms.Button boutAcquisition;
        private System.Windows.Forms.Button boutQuit;
        private System.Windows.Forms.Timer timAcq;
        private System.Windows.Forms.Label lblConnection;
        private System.Windows.Forms.GroupBox gbCamera;
        private System.Windows.Forms.Label lblNomCamera;
        private System.Windows.Forms.Label lblAdrIP;
        private System.Windows.Forms.Button boutStop;
        private System.IO.Ports.SerialPort portUsb;
        private System.Windows.Forms.PictureBox pbTraitement;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button boutTraitement;
    }
}

