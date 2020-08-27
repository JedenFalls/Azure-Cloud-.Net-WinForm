using System;
using System.Collections.Generic;
using System.Drawing;
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
            Size size = TextRenderer.MeasureText(txb_kvSecretValue.Text, txb_kvSecretValue.Font);
            txb_kvSecretValue.Width = size.Width;
            txb_kvSecretValue.Height = size.Height;
        }

        private void btn_kvAllSecrets_Click(object sender, EventArgs e)
        {
            String resultString = "";
            List<string> allSecrets = kvSecret.AllSecrets;
            foreach(string secret in allSecrets)
            {
                resultString += $"{secret}\n";
            }

            txb_kvSecrets.Text = resultString;
            Size size = TextRenderer.MeasureText(txb_kvSecrets.Text, txb_kvSecrets.Font);
            txb_kvSecrets.Width = size.Width;
            txb_kvSecrets.Height = size.Height;
        }
    }
}
