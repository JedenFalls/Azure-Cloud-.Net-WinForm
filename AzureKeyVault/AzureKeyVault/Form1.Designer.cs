namespace AzureKeyVault
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
            this.txb_kvName = new System.Windows.Forms.TextBox();
            this.txb_kvSecretName = new System.Windows.Forms.TextBox();
            this.btn_getKvSecret = new System.Windows.Forms.Button();
            this.lbl_kvSecretValue = new System.Windows.Forms.Label();
            this.txb_kvSecretValue = new System.Windows.Forms.TextBox();
            this.btn_kvAllSecrets = new System.Windows.Forms.Button();
            this.txb_kvSecrets = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txb_kvName
            // 
            this.txb_kvName.Location = new System.Drawing.Point(22, 25);
            this.txb_kvName.Name = "txb_kvName";
            this.txb_kvName.Size = new System.Drawing.Size(100, 20);
            this.txb_kvName.TabIndex = 0;
            this.txb_kvName.Text = "Key Vault Name";
            this.txb_kvName.TextChanged += new System.EventHandler(this.txb_kvName_TextChanged);
            // 
            // txb_kvSecretName
            // 
            this.txb_kvSecretName.Location = new System.Drawing.Point(22, 62);
            this.txb_kvSecretName.Name = "txb_kvSecretName";
            this.txb_kvSecretName.Size = new System.Drawing.Size(100, 20);
            this.txb_kvSecretName.TabIndex = 1;
            this.txb_kvSecretName.Text = "Secret Name";
            this.txb_kvSecretName.TextChanged += new System.EventHandler(this.txb_kvSecretName_TextChanged);
            // 
            // btn_getKvSecret
            // 
            this.btn_getKvSecret.Location = new System.Drawing.Point(22, 144);
            this.btn_getKvSecret.Name = "btn_getKvSecret";
            this.btn_getKvSecret.Size = new System.Drawing.Size(151, 23);
            this.btn_getKvSecret.TabIndex = 3;
            this.btn_getKvSecret.Text = "Get Key Vault Secret Value";
            this.btn_getKvSecret.UseVisualStyleBackColor = true;
            this.btn_getKvSecret.Click += new System.EventHandler(this.btn_getKvSecret_Click);
            // 
            // lbl_kvSecretValue
            // 
            this.lbl_kvSecretValue.AutoSize = true;
            this.lbl_kvSecretValue.Location = new System.Drawing.Point(19, 194);
            this.lbl_kvSecretValue.Name = "lbl_kvSecretValue";
            this.lbl_kvSecretValue.Size = new System.Drawing.Size(68, 13);
            this.lbl_kvSecretValue.TabIndex = 4;
            this.lbl_kvSecretValue.Text = "Secret Value";
            // 
            // txb_kvSecretValue
            // 
            this.txb_kvSecretValue.Location = new System.Drawing.Point(22, 219);
            this.txb_kvSecretValue.Name = "txb_kvSecretValue";
            this.txb_kvSecretValue.Size = new System.Drawing.Size(100, 20);
            this.txb_kvSecretValue.TabIndex = 5;
            // 
            // btn_kvAllSecrets
            // 
            this.btn_kvAllSecrets.Location = new System.Drawing.Point(22, 102);
            this.btn_kvAllSecrets.Name = "btn_kvAllSecrets";
            this.btn_kvAllSecrets.Size = new System.Drawing.Size(151, 23);
            this.btn_kvAllSecrets.TabIndex = 7;
            this.btn_kvAllSecrets.Text = "Get Key Vault Secrets";
            this.btn_kvAllSecrets.UseVisualStyleBackColor = true;
            this.btn_kvAllSecrets.Click += new System.EventHandler(this.btn_kvAllSecrets_Click);
            // 
            // txb_kvSecrets
            // 
            this.txb_kvSecrets.Location = new System.Drawing.Point(312, 25);
            this.txb_kvSecrets.Multiline = true;
            this.txb_kvSecrets.Name = "txb_kvSecrets";
            this.txb_kvSecrets.Size = new System.Drawing.Size(100, 20);
            this.txb_kvSecrets.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 291);
            this.Controls.Add(this.txb_kvSecrets);
            this.Controls.Add(this.txb_kvSecretValue);
            this.Controls.Add(this.lbl_kvSecretValue);
            this.Controls.Add(this.btn_kvAllSecrets);
            this.Controls.Add(this.btn_getKvSecret);
            this.Controls.Add(this.txb_kvSecretName);
            this.Controls.Add(this.txb_kvName);
            this.Name = "Form1";
            this.Text = "8/7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_kvName;
        private System.Windows.Forms.TextBox txb_kvSecretName;
        private System.Windows.Forms.Button btn_getKvSecret;
        private System.Windows.Forms.Label lbl_kvSecretValue;
        private System.Windows.Forms.TextBox txb_kvSecretValue;
        private System.Windows.Forms.Button btn_kvAllSecrets;
        private System.Windows.Forms.TextBox txb_kvSecrets;
    }
}

