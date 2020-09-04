using System;
using System.Collections.Generic;
using Azure.Identity;
using Azure.Security.KeyVault.Secrets;

namespace AzureKeyVault
{
    class AzKeyVaultSecret
    {
        public string KeyVaultName { get; set; }
        public string KeyVaultSecretName { get; set; }

        public string SecretValue { 
            get
            {
                var client = GetSecretClient();
                KeyVaultSecret secret = client.GetSecret(KeyVaultSecretName);
                return secret.Value;
            }
        }

        public List<string> AllSecrets
        {
            get
            {
                var client = GetSecretClient();
                var allSecrets = client.GetPropertiesOfSecrets();
                var secrets = new List<string>();

                foreach (SecretProperties secretProperties in allSecrets)
                {
                    secrets.Add(secretProperties.Name);
                }

                return secrets;
            }
        }

        private SecretClient GetSecretClient()
        {
            var credential = new DefaultAzureCredential(includeInteractiveCredentials: true);
            var kvUri = "https://" + KeyVaultName + ".vault.azure.net";

            SecretClient client = new SecretClient(new Uri(kvUri), credential);
            return client;
        }
    }
}
