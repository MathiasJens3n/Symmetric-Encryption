using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

namespace Symmetric_Encryption
{
    public partial class Form1 : Form
    {
        readonly EncryptionManager encryptionManager;
        readonly Stopwatch encryptionSw;
        readonly Stopwatch decryptionSw;

        string algorithm;
        string encryptionMessage;
        string decryptMessage;

        public Form1()
        {
            InitializeComponent();
            encryptionManager = new EncryptionManager();
            encryptionSw = new Stopwatch();
            decryptionSw = new Stopwatch();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            ReadInput();

            encryptionManager.GenerateKey(algorithm);
            encryptionManager.GenerateIV(algorithm);

            KeyASCIITextBox.Text = Convert.ToBase64String(encryptionManager.Key);
            KeyHexTextBox.Text = Convert.ToHexString(encryptionManager.Key);
            IVASCIITextBox.Text = Convert.ToBase64String(encryptionManager.IV);
            IVHexTextBox.Text = Convert.ToHexString(encryptionManager.IV);
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {

            try
            {
                encryptionSw.Reset();

                encryptionSw.Start();

                ReadInput();

                encryptionManager.Encrypt(algorithm, encryptionMessage);

                cipherASCIITextBox.Text = Convert.ToBase64String(encryptionManager.EncryptedMessage);
                cipherHexTextBox.Text = Convert.ToHexString(encryptionManager.EncryptedMessage);

                encryptionSw.Stop();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Encryption error, make sure you have generated a key and entered a text to encrypt");
            }
            finally
            {

            }
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {

            try
            {
                decryptionSw.Restart();

                ReadInput();

                encryptionManager.Decrypt(algorithm, decryptMessage);

                plainASCIITextBox.Text = Encoding.UTF8.GetString(encryptionManager.DecryptedMessage);
                plainHexTextBox.Text = Convert.ToHexString(encryptionManager.DecryptedMessage);

                decryptionSw.Stop();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Decryption error");
            }
            finally
            {

            }
        }

        private void EncryptTimeButton_Click(object sender, EventArgs e)
        {
            EncryptionTimeTextlabel.Text = $"{encryptionSw.Elapsed.Milliseconds} ms";
        }
        private void DecryptTimeButton_Click(object sender, EventArgs e)
        {
            DecryptionTimeTextlabel.Text = $"{decryptionSw.Elapsed.Milliseconds} ms";
        }
        private void ReadInput()
        {
            try
            {
                algorithm = algorithmComboBox.Text;
                encryptionMessage = plainASCIITextBox.Text;
                decryptMessage = cipherASCIITextBox.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Fejl prøv igen");
            }
        }
    }
}