using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BitcoinQrCodeGenrator
{
    public partial class frmImage : Form
    {
        private string Input = "";
        public frmImage(Image qrcode, string input)
        {
            InitializeComponent();

            this.Input = input;
            pbQrCode.Image = qrcode;
            this.Text = $"Width: {qrcode.Width}   Height: {qrcode.Height}";
        }

        private void frmImage_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "Image file (*.png)|*.png";
                    sfd.FileName = "Qrcode_" + Input;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        pbQrCode.Image.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Png);
                        MessageBox.Show(sfd.FileName,"Saved");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
