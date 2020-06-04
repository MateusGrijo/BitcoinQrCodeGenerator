using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ZXing.Common;
using ZXing;
using ZXing.QrCode.Internal;
using ZXing.Rendering;
using ZXing.QrCode;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Web;

namespace BitcoinQrCodeGenrator
{
    public partial class frmMain : Form
    {

        enum CryptoCurrency
        {
            Bitcoin, Litecoin, Ethereum
        }

        Bitmap Footer = null;
        private CryptoCurrency currency = CryptoCurrency.Bitcoin;

        public frmMain()
        {
            InitializeComponent();
        }

   

        private void btnGenerate_Click(object sender, EventArgs e)
        {
        
            txtInput.Text = txtInput.Text.Trim();

            if (String.IsNullOrEmpty(txtInput.Text))
            {
                MessageBox.Show("Input field is empty!", "Error");
                return;
            }

            if (rbText.Checked)
            {
                Bitmap result = GetQrCode(txtInput.Text);
                if (result != null)
                {
                    new frmImage(result, txtInput.Text).ShowDialog();
                }
                return;
            }


            if (IsCryptoAddress(txtInput.Text, currency))
            {
                Bitmap result = GetQrCodeAddress(txtInput.Text,txtAmount.Text, txtLabel.Text, txtMessage.Text);
                if (result != null)
                {
                    new frmImage(result, txtInput.Text).ShowDialog();
                }

                return;
            }
            else
            {
                MessageBox.Show("Incorrect address!", "Error");
                return;
            }




        }

        private Bitmap GetQrCodeAddress(string address, string amount , string label, string msg)
        {
            Bitmap bmp = null;
            try
            {
             

               
                if (currency == CryptoCurrency.Bitcoin && cbURI.Checked)
                    address = $"bitcoin:{address}";
                else if (currency == CryptoCurrency.Litecoin && cbURI.Checked)
                    address = "litecoin:" + address;
                else if (currency == CryptoCurrency.Ethereum && cbURI.Checked)
                    address = "ethereum:" + address;


                if (cbURI.Checked)
                {
                    string request =  $"?amount={amount}&label={label}&message={msg}";
                    request = Uri.EscapeUriString(request);
                    address += request;
                }

                var result = GetQrCode(address);

                bmp = result;

            }
            catch { }
            return bmp;


        }

        private Bitmap GetQrCode(string input)
        {
            Bitmap output = null;

            try
            {

                var bw = new ZXing.BarcodeWriter();

                ZXing.Common.EncodingOptions encOptions = new ZXing.Common.EncodingOptions
                {
                    Width = int.Parse(txtWidth.Text),
                    Height = int.Parse(txtHeight.Text),
                    Margin = int.Parse(txtMargin.Text),
                    PureBarcode = false
                };

                encOptions.Hints.Add(EncodeHintType.ERROR_CORRECTION, ErrorCorrectionLevel.H);

                bw.Renderer = new BitmapRenderer();
                bw.Options = encOptions;
                bw.Format = ZXing.BarcodeFormat.QR_CODE;

                Bitmap bmp = bw.Write(input);

                if (cbCustomFooter.Checked && Footer != null)
                {
                    bmp = AppendImageFooter(bmp, Footer);
                }

                if (CheckQR(bmp, input))
                {
                    output = bmp;
                }
                else if (cbCustomFooter.Checked)
                {
                    MessageBox.Show("Try again with a lower opacity logo!", "Error");
                }



            }
            catch { }

            return output;

        }

      
        public Bitmap AppendImageFooter(Bitmap bmp, Bitmap footer)
        {
            Bitmap output = null;
            try
            {
                Bitmap newImage = new Bitmap(bmp.Width, bmp.Height + footer.Height);

                Graphics g = Graphics.FromImage(newImage);
                g.DrawImage(bmp, new Point(0, 0));
                g.DrawImage(footer, new Point(0, bmp.Height));
                g.Dispose();

                output = newImage;

            }
            catch { }

            return output;

   
        }

   


        public bool CheckQR(Bitmap QrCode, string input)
        {
            bool output = false;
            try
            {
                var reader = new BarcodeReader();
                var result = reader.Decode(QrCode);
                if (result != null && result.Text == input)
                {
                    output = true;
                }

            }
            catch { }

            return output;
        }

        private static bool IsCryptoAddress(string input, CryptoCurrency cryptoCurrency)
        {
            bool output = false;
            try
            {
                string pattern = "";

                if (cryptoCurrency == CryptoCurrency.Bitcoin)
                    pattern = @"\b(([13][1-9A-HJ-NP-Za-km-z]{25,34})|(bc1[a-z0-9]{39,59}))\b";
                else if (cryptoCurrency == CryptoCurrency.Litecoin)
                    pattern = @"\b((L[1-9A-HJ-NP-Za-km-z]{33})|(M[1-9A-HJ-NP-Za-km-z]{33})|(ltc1[a-z0-9]{14,74}))\b";
                else if (cryptoCurrency == CryptoCurrency.Ethereum)
                    pattern = @"\b0x[0-9A-Fa-f]{40}\b";

                if (pattern != "")
                {
                    output = Regex.IsMatch(input, pattern);
                }

            }
            catch { }

            return output;
        }

        private void rbBtc_CheckedChanged(object sender, EventArgs e)
        {
            currency = CryptoCurrency.Bitcoin;
   
        }

        private void rbLitecoin_CheckedChanged(object sender, EventArgs e)
        {
            currency = CryptoCurrency.Litecoin;
      
        }

        private void rbEth_CheckedChanged(object sender, EventArgs e)
        {
            currency = CryptoCurrency.Ethereum;
         
        }

  

        private void cbLogo_CheckedChanged(object sender, EventArgs e)
        {
        
            if (cbCustomFooter.Checked)
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                  
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        Footer = new Bitmap(ofd.FileName);
                    }
                    else
                    {
                        Footer = null;
                    }

                }


            }
            else
            {
                Footer = null;
            }
        }

      

        private void rbOther_CheckedChanged(object sender, EventArgs e)
        {
            cbUriPaymentRequest.Checked = false;
            cbUriPaymentRequest.Enabled = !rbText.Checked;

            cbURI.Checked = false;
            cbURI.Enabled = !rbText.Checked;

        }

   
        private void cbUriPaymentRequest_CheckedChanged(object sender, EventArgs e)
        {
            cbURI.Checked = true;

            txtAmount.Enabled = cbUriPaymentRequest.Checked;
            txtLabel.Enabled = cbUriPaymentRequest.Checked;
            txtMessage.Enabled = cbUriPaymentRequest.Checked;
        }

      
    }
}
