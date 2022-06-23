namespace CryptographyTool
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonEncryptFile = new System.Windows.Forms.Button();
            this.buttonCreateAsmKeys = new System.Windows.Forms.Button();
            this.buttonGetPrivateKey = new System.Windows.Forms.Button();
            this.buttonExportPublicKey = new System.Windows.Forms.Button();
            this.buttonImportPublicKey = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._encryptOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this._decryptOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.buttonDecryptFile = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEncryptFile
            // 
            this.buttonEncryptFile.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonEncryptFile.Location = new System.Drawing.Point(11, 14);
            this.buttonEncryptFile.Name = "buttonEncryptFile";
            this.buttonEncryptFile.Size = new System.Drawing.Size(80, 37);
            this.buttonEncryptFile.TabIndex = 0;
            this.buttonEncryptFile.Text = "Encrypt File";
            this.buttonEncryptFile.UseVisualStyleBackColor = true;
            this.buttonEncryptFile.Click += new System.EventHandler(this.buttonEncryptFile_Click);
            // 
            // buttonCreateAsmKeys
            // 
            this.buttonCreateAsmKeys.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonCreateAsmKeys.Location = new System.Drawing.Point(11, 57);
            this.buttonCreateAsmKeys.Name = "buttonCreateAsmKeys";
            this.buttonCreateAsmKeys.Size = new System.Drawing.Size(80, 37);
            this.buttonCreateAsmKeys.TabIndex = 2;
            this.buttonCreateAsmKeys.Text = "Create Keys";
            this.buttonCreateAsmKeys.UseVisualStyleBackColor = true;
            this.buttonCreateAsmKeys.Click += new System.EventHandler(this.buttonCreateAsmKeys_Click);
            // 
            // buttonGetPrivateKey
            // 
            this.buttonGetPrivateKey.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonGetPrivateKey.Location = new System.Drawing.Point(189, 57);
            this.buttonGetPrivateKey.Name = "buttonGetPrivateKey";
            this.buttonGetPrivateKey.Size = new System.Drawing.Size(80, 37);
            this.buttonGetPrivateKey.TabIndex = 3;
            this.buttonGetPrivateKey.Text = "Get Private Key";
            this.buttonGetPrivateKey.UseVisualStyleBackColor = true;
            this.buttonGetPrivateKey.Click += new System.EventHandler(this.buttonGetPrivateKey_Click);
            // 
            // buttonExportPublicKey
            // 
            this.buttonExportPublicKey.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonExportPublicKey.Location = new System.Drawing.Point(11, 100);
            this.buttonExportPublicKey.Name = "buttonExportPublicKey";
            this.buttonExportPublicKey.Size = new System.Drawing.Size(80, 37);
            this.buttonExportPublicKey.TabIndex = 4;
            this.buttonExportPublicKey.Text = "Export Public Key";
            this.buttonExportPublicKey.UseVisualStyleBackColor = true;
            this.buttonExportPublicKey.Click += new System.EventHandler(this.buttonExportPublicKey_Click);
            // 
            // buttonImportPublicKey
            // 
            this.buttonImportPublicKey.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonImportPublicKey.Location = new System.Drawing.Point(189, 100);
            this.buttonImportPublicKey.Name = "buttonImportPublicKey";
            this.buttonImportPublicKey.Size = new System.Drawing.Size(80, 37);
            this.buttonImportPublicKey.TabIndex = 5;
            this.buttonImportPublicKey.Text = "Import Public Key";
            this.buttonImportPublicKey.UseVisualStyleBackColor = true;
            this.buttonImportPublicKey.Click += new System.EventHandler(this.buttonImportPublicKey_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 6;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // _encryptOpenFileDialog
            // 
            this._encryptOpenFileDialog.FileName = "_encryptOpenFileDialog";
            this._encryptOpenFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this._encryptOpenFileDialog_FileOk);
            // 
            // _decryptOpenFileDialog
            // 
            this._decryptOpenFileDialog.FileName = "_decryptOpenFileDialog";
            // 
            // buttonDecryptFile
            // 
            this.buttonDecryptFile.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonDecryptFile.Location = new System.Drawing.Point(189, 14);
            this.buttonDecryptFile.Name = "buttonDecryptFile";
            this.buttonDecryptFile.Size = new System.Drawing.Size(80, 37);
            this.buttonDecryptFile.TabIndex = 1;
            this.buttonDecryptFile.Text = "Decrypt File";
            this.buttonDecryptFile.UseVisualStyleBackColor = true;
            this.buttonDecryptFile.Click += new System.EventHandler(this.buttonDecryptFile_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(92, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 155);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonImportPublicKey);
            this.Controls.Add(this.buttonExportPublicKey);
            this.Controls.Add(this.buttonGetPrivateKey);
            this.Controls.Add(this.buttonCreateAsmKeys);
            this.Controls.Add(this.buttonDecryptFile);
            this.Controls.Add(this.buttonEncryptFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "CryptographyTool";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEncryptFile;
        private System.Windows.Forms.Button buttonCreateAsmKeys;
        private System.Windows.Forms.Button buttonGetPrivateKey;
        private System.Windows.Forms.Button buttonExportPublicKey;
        private System.Windows.Forms.Button buttonImportPublicKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog _encryptOpenFileDialog;
        private System.Windows.Forms.OpenFileDialog _decryptOpenFileDialog;
        private System.Windows.Forms.Button buttonDecryptFile;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

