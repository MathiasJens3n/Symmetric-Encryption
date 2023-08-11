using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Symmetric_Encryption
{
    public partial class Form1 : Form
    {
        readonly EncryptionManager encryptionManager;
        readonly DesEncryption des;
        readonly TDESEncryption tDES;
        readonly Stopwatch encryptionSw;
        readonly Stopwatch decryptionSw;

        string algorithm;
        string encryptionMessage;
        string decryptMessage;

        public Form1()
        {
            InitializeComponent();
            encryptionManager = new EncryptionManager();
            des = new DesEncryption();
            tDES = new TDESEncryption();
            encryptionSw = new Stopwatch();
            decryptionSw = new Stopwatch();
        }
        private void GenerateButton_Click(object sender, EventArgs e)
        {
            ReadInput();

            switch (algorithm)
            {
                case "DES":
                    encryptionManager.GenerateIV(des);
                    encryptionManager.GenerateKey(des);
                    break;
                case "TDES":
                    encryptionManager.GenerateIV(tDES);
                    encryptionManager.GenerateKey(tDES);
                    break;
                default:
                    encryptionManager.GenerateIV(tDES);
                    encryptionManager.GenerateKey(tDES);
                    break;
            }

            KeyASCIITextBox.Text = Convert.ToBase64String(encryptionManager.Key);
            KeyHexTextBox.Text = Convert.ToHexString(encryptionManager.Key);
            IVASCIITextBox.Text = Convert.ToBase64String(encryptionManager.IV);
            IVHexTextBox.Text = Convert.ToHexString(encryptionManager.IV);
        }
        private void EncryptButton_Click(object sender, EventArgs e)
        {

            try
            {
                encryptionSw.Restart();

                ReadInput();

                switch (algorithm)
                {
                    case "DES":
                        encryptionManager.Encrypt(Encoding.UTF8.GetBytes(encryptionMessage), des);
                        break;
                    case "TDES":
                        encryptionManager.Encrypt(Encoding.UTF8.GetBytes(encryptionMessage), tDES);
                        break;
                    default:
                        encryptionManager.Encrypt(Encoding.UTF8.GetBytes(encryptionMessage), tDES);
                        break;
                }


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

                switch (algorithm)
                {
                    case "DES":
                        encryptionManager.Decrypt(Convert.FromBase64String(decryptMessage), des);
                        break;
                    case "TDES":
                        encryptionManager.Decrypt(Convert.FromBase64String(decryptMessage), tDES);
                        break;
                    default:
                        encryptionManager.Decrypt(Convert.FromBase64String(decryptMessage), tDES);
                        break;
                }

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