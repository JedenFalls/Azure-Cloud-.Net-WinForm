using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AzureKeyVault
{
    public partial class Form1 : Form
    {
        AzKeyVaultSecret kvSecret;
        public Form1()
        {
            InitializeComponent();
            kvSecret = new AzKeyVaultSecret();
        }

        private void txb_kvName_TextChanged(object sender, EventArgs e)
        {
            kvSecret.KeyVaultName = txb_kvName.Text;
        }

        private void txb_kvSecretName_TextChanged(object sender, EventArgs e)
        {
            kvSecret.KeyVaultSecretName = txb_kvSecretName.Text;
        }

        private void btn_getKvSecret_Click(object sender, EventArgs e)
        {
            txb_kvSecretValue.Text = kvSecret.SecretValue;
            //size size = textrenderer.measuretext(txb_kvsecretvalue.text, txb_kvsecretvalue.font);
            //txb_kvsecretvalue.width = size.width;
            //txb_kvsecretvalue.height = size.height;
       }

        private void btn_kvAllSecrets_Click(object sender, EventArgs e)
        {

            StringBuilder resultString = new StringBuilder();
            List<string> allSecrets = kvSecret.AllSecrets;

            foreach(string secret in allSecrets)
            {
                resultString.AppendLine(secret);
            }

            txb_kvSecrets.Text = resultString.ToString();
            Size size = TextRenderer.MeasureText(txb_kvSecrets.Text, txb_kvSecrets.Font);
            txb_kvSecrets.Width = size.Width;
            txb_kvSecrets.Height = size.Height;
        }

        private void btn_cleanSecrets_Click(object sender, EventArgs e)
        {
            txb_kvSecrets.Text = "All Secrets";
            txb_kvSecrets.Width = 100;
            txb_kvSecrets.Height = 20;
        }

        private void btn_hideSecretValue_Click(object sender, EventArgs e)
        {
            txb_kvSecretValue.Text = "No Input here!";
            txb_kvSecretValue.Width = 100;
            txb_kvSecretValue.Height = 20;
        }
    }
}
