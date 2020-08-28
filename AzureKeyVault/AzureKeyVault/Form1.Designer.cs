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
            this.btn_cleanSecrets = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_hideSecretValue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txb_kvName
            // 
            this.txb_kvName.Location = new System.Drawing.Point(22, 44);
            this.txb_kvName.Name = "txb_kvName";
            this.txb_kvName.Size = new System.Drawing.Size(100, 20);
            this.txb_kvName.TabIndex = 0;
            this.txb_kvName.TextChanged += new System.EventHandler(this.txb_kvName_TextChanged);
            // 
            // txb_kvSecretName
            // 
            this.txb_kvSecretName.Location = new System.Drawing.Point(22, 130);
            this.txb_kvSecretName.Name = "txb_kvSecretName";
            this.txb_kvSecretName.Size = new System.Drawing.Size(100, 20);
            this.txb_kvSecretName.TabIndex = 1;
            this.txb_kvSecretName.TextChanged += new System.EventHandler(this.txb_kvSecretName_TextChanged);
            // 
            // btn_getKvSecret
            // 
            this.btn_getKvSecret.Location = new System.Drawing.Point(22, 156);
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
            this.lbl_kvSecretValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_kvSecretValue.Location = new System.Drawing.Point(19, 224);
            this.lbl_kvSecretValue.Name = "lbl_kvSecretValue";
            this.lbl_kvSecretValue.Size = new System.Drawing.Size(89, 17);
            this.lbl_kvSecretValue.TabIndex = 4;
            this.lbl_kvSecretValue.Text = "Secret Value";
            // 
            // txb_kvSecretValue
            // 
            this.txb_kvSecretValue.Location = new System.Drawing.Point(22, 244);
            this.txb_kvSecretValue.Name = "txb_kvSecretValue";
            this.txb_kvSecretValue.Size = new System.Drawing.Size(233, 20);
            this.txb_kvSecretValue.TabIndex = 5;
            this.txb_kvSecretValue.Text = "No Input here!";
            // 
            // btn_kvAllSecrets
            // 
            this.btn_kvAllSecrets.Location = new System.Drawing.Point(22, 70);
            this.btn_kvAllSecrets.Name = "btn_kvAllSecrets";
            this.btn_kvAllSecrets.Size = new System.Drawing.Size(151, 23);
            this.btn_kvAllSecrets.TabIndex = 7;
            this.btn_kvAllSecrets.Text = "Get Key Vault Secrets";
            this.btn_kvAllSecrets.UseVisualStyleBackColor = true;
            this.btn_kvAllSecrets.Click += new System.EventHandler(this.btn_kvAllSecrets_Click);
            // 
            // txb_kvSecrets
            // 
            this.txb_kvSecrets.Location = new System.Drawing.Point(361, 25);
            this.txb_kvSecrets.Multiline = true;
            this.txb_kvSecrets.Name = "txb_kvSecrets";
            this.txb_kvSecrets.Size = new System.Drawing.Size(100, 20);
            this.txb_kvSecrets.TabIndex = 8;
            this.txb_kvSecrets.Text = "All Secrets";
            // 
            // btn_cleanSecrets
            // 
            this.btn_cleanSecrets.Location = new System.Drawing.Point(259, 23);
            this.btn_cleanSecrets.Name = "btn_cleanSecrets";
            this.btn_cleanSecrets.Size = new System.Drawing.Size(96, 23);
            this.btn_cleanSecrets.TabIndex = 9;
            this.btn_cleanSecrets.Text = "Hide Secrets";
            this.btn_cleanSecrets.UseVisualStyleBackColor = true;
            this.btn_cleanSecrets.Click += new System.EventHandler(this.btn_cleanSecrets_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(19, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Key Vault Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(19, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Secret Name";
            // 
            // btn_hideSecretValue
            // 
            this.btn_hideSecretValue.Location = new System.Drawing.Point(20, 198);
            this.btn_hideSecretValue.Name = "btn_hideSecretValue";
            this.btn_hideSecretValue.Size = new System.Drawing.Size(124, 23);
            this.btn_hideSecretValue.TabIndex = 12;
            this.btn_hideSecretValue.Text = "Hide Secret Value";
            this.btn_hideSecretValue.UseVisualStyleBackColor = true;
            this.btn_hideSecretValue.Click += new System.EventHandler(this.btn_hideSecretValue_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 383);
            this.Controls.Add(this.btn_hideSecretValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cleanSecrets);
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
        private System.Windows.Forms.Button btn_cleanSecrets;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_hideSecretValue;
    }
}

