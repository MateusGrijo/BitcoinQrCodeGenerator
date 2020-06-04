namespace BitcoinQrCodeGenrator
{
    partial class frmMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtInput = new System.Windows.Forms.TextBox();
            this.rbBtc = new System.Windows.Forms.RadioButton();
            this.rbEth = new System.Windows.Forms.RadioButton();
            this.rbLitecoin = new System.Windows.Forms.RadioButton();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.cbURI = new System.Windows.Forms.CheckBox();
            this.cbCustomFooter = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbText = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbUriPaymentRequest = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMargin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLabel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(6, 20);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(529, 29);
            this.txtInput.TabIndex = 1;
            this.txtInput.Text = "1HyHr1ninPKiDYKJvFYrz3sps77nVSJ3mb";
            this.txtInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rbBtc
            // 
            this.rbBtc.AutoSize = true;
            this.rbBtc.Checked = true;
            this.rbBtc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBtc.Location = new System.Drawing.Point(12, 24);
            this.rbBtc.Name = "rbBtc";
            this.rbBtc.Size = new System.Drawing.Size(66, 20);
            this.rbBtc.TabIndex = 3;
            this.rbBtc.TabStop = true;
            this.rbBtc.Text = "Bitcoin";
            this.rbBtc.UseVisualStyleBackColor = true;
            this.rbBtc.CheckedChanged += new System.EventHandler(this.rbBtc_CheckedChanged);
            // 
            // rbEth
            // 
            this.rbEth.AutoSize = true;
            this.rbEth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEth.Location = new System.Drawing.Point(177, 24);
            this.rbEth.Name = "rbEth";
            this.rbEth.Size = new System.Drawing.Size(83, 20);
            this.rbEth.TabIndex = 4;
            this.rbEth.Text = "Ethereum";
            this.rbEth.UseVisualStyleBackColor = true;
            this.rbEth.CheckedChanged += new System.EventHandler(this.rbEth_CheckedChanged);
            // 
            // rbLitecoin
            // 
            this.rbLitecoin.AutoSize = true;
            this.rbLitecoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLitecoin.Location = new System.Drawing.Point(93, 24);
            this.rbLitecoin.Name = "rbLitecoin";
            this.rbLitecoin.Size = new System.Drawing.Size(72, 20);
            this.rbLitecoin.TabIndex = 5;
            this.rbLitecoin.Text = "Litecoin";
            this.rbLitecoin.UseVisualStyleBackColor = true;
            this.rbLitecoin.CheckedChanged += new System.EventHandler(this.rbLitecoin_CheckedChanged);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(27, 332);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(541, 41);
            this.btnGenerate.TabIndex = 6;
            this.btnGenerate.Text = "Generate QR Code";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // cbURI
            // 
            this.cbURI.AutoSize = true;
            this.cbURI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbURI.Location = new System.Drawing.Point(137, 24);
            this.cbURI.Name = "cbURI";
            this.cbURI.Size = new System.Drawing.Size(86, 20);
            this.cbURI.TabIndex = 7;
            this.cbURI.Text = "URI Prefix";
            this.cbURI.UseVisualStyleBackColor = true;
            // 
            // cbCustomFooter
            // 
            this.cbCustomFooter.AutoSize = true;
            this.cbCustomFooter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbCustomFooter.Location = new System.Drawing.Point(12, 24);
            this.cbCustomFooter.Name = "cbCustomFooter";
            this.cbCustomFooter.Size = new System.Drawing.Size(114, 20);
            this.cbCustomFooter.TabIndex = 8;
            this.cbCustomFooter.Text = "Custom Footer";
            this.cbCustomFooter.UseVisualStyleBackColor = true;
            this.cbCustomFooter.CheckedChanged += new System.EventHandler(this.cbLogo_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbText);
            this.groupBox1.Controls.Add(this.rbBtc);
            this.groupBox1.Controls.Add(this.rbEth);
            this.groupBox1.Controls.Add(this.rbLitecoin);
            this.groupBox1.Location = new System.Drawing.Point(27, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(541, 58);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // rbText
            // 
            this.rbText.AutoSize = true;
            this.rbText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbText.Location = new System.Drawing.Point(266, 24);
            this.rbText.Name = "rbText";
            this.rbText.Size = new System.Drawing.Size(52, 20);
            this.rbText.TabIndex = 12;
            this.rbText.Text = "Text";
            this.rbText.UseVisualStyleBackColor = true;
            this.rbText.CheckedChanged += new System.EventHandler(this.rbOther_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbUriPaymentRequest);
            this.groupBox2.Controls.Add(this.cbURI);
            this.groupBox2.Controls.Add(this.cbCustomFooter);
            this.groupBox2.Location = new System.Drawing.Point(27, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(541, 58);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // cbUriPaymentRequest
            // 
            this.cbUriPaymentRequest.AutoSize = true;
            this.cbUriPaymentRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbUriPaymentRequest.Location = new System.Drawing.Point(234, 24);
            this.cbUriPaymentRequest.Name = "cbUriPaymentRequest";
            this.cbUriPaymentRequest.Size = new System.Drawing.Size(160, 20);
            this.cbUriPaymentRequest.TabIndex = 9;
            this.cbUriPaymentRequest.Text = "URI Payment Request";
            this.cbUriPaymentRequest.UseVisualStyleBackColor = true;
            this.cbUriPaymentRequest.CheckedChanged += new System.EventHandler(this.cbUriPaymentRequest_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtMargin);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtHeight);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtWidth);
            this.groupBox3.Location = new System.Drawing.Point(27, 204);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(541, 58);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Image Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(278, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Margin";
            // 
            // txtMargin
            // 
            this.txtMargin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMargin.Location = new System.Drawing.Point(331, 24);
            this.txtMargin.Name = "txtMargin";
            this.txtMargin.Size = new System.Drawing.Size(78, 22);
            this.txtMargin.TabIndex = 16;
            this.txtMargin.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(141, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Height";
            // 
            // txtHeight
            // 
            this.txtHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeight.Location = new System.Drawing.Point(194, 24);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(78, 22);
            this.txtHeight.TabIndex = 14;
            this.txtHeight.Text = "256";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Width";
            // 
            // txtWidth
            // 
            this.txtWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWidth.Location = new System.Drawing.Point(55, 24);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(78, 22);
            this.txtWidth.TabIndex = 12;
            this.txtWidth.Text = "256";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Amount";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtAmount);
            this.groupBox4.Controls.Add(this.txtMessage);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txtLabel);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(27, 140);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(541, 58);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "URI Payment Request";
            // 
            // txtMessage
            // 
            this.txtMessage.Enabled = false;
            this.txtMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.Location = new System.Drawing.Point(394, 23);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(141, 22);
            this.txtMessage.TabIndex = 23;
            this.txtMessage.Text = "QrCode Generator";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(324, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Message";
            // 
            // txtLabel
            // 
            this.txtLabel.Enabled = false;
            this.txtLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLabel.Location = new System.Drawing.Point(198, 23);
            this.txtLabel.Name = "txtLabel";
            this.txtLabel.Size = new System.Drawing.Size(120, 22);
            this.txtLabel.TabIndex = 21;
            this.txtLabel.Text = "Matheus Grijó";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(150, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Label";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtInput);
            this.groupBox5.Location = new System.Drawing.Point(27, 268);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(541, 58);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            // 
            // txtAmount
            // 
            this.txtAmount.Enabled = false;
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(67, 23);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(77, 22);
            this.txtAmount.TabIndex = 24;
            this.txtAmount.Text = "0.01";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 393);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGenerate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  QR Code Generator - Cafe e SHA-256 ";
        
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.RadioButton rbBtc;
        private System.Windows.Forms.RadioButton rbEth;
        private System.Windows.Forms.RadioButton rbLitecoin;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.CheckBox cbURI;
        private System.Windows.Forms.CheckBox cbCustomFooter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMargin;
        private System.Windows.Forms.RadioButton rbText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox cbUriPaymentRequest;
        private System.Windows.Forms.TextBox txtAmount;
    }
}

