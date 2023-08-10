using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Symmetric_Encryption
{
    internal class EncryptionManager
    {
        readonly DesEncryption des;
        readonly TDESEncryption tDES;

        public byte[] Key { get; private set; }
        public byte[] IV { get; private set; }
        public byte[] EncryptedMessage { get; private set; }
        public byte[] DecryptedMessage { get; private set; }
        public EncryptionManager()
        {
            des = new DesEncryption();
            tDES = new TDESEncryption();
        }
        /// <summary>
        /// Generates a for the chosen algorithm
        /// </summary>
        public void GenerateKey(string algorithm)
        {
            switch (algorithm)
            {
                case "DES":
                    using (DES des = DES.Create()) { Key = des.Key; }
                    break;
                case "TDES":
                    using (TripleDES tDES = TripleDES.Create()) { Key = tDES.Key; }
                    break;
                default:
                    using (TripleDES tDES = TripleDES.Create()) { Key = tDES.Key; }
                    break;
            }
        }
        /// <summary>
        /// Generates a vector for the chosen algorithm
        /// </summary>
        public void GenerateIV(string algorithm)
        {
            switch (algorithm)
            {
                case "DES":
                    using (DES des = DES.Create()) { IV = des.IV; }
                    break;
                case "TDES":
                    using (TripleDES tDES = TripleDES.Create()) { IV = tDES.IV; }
                    break;
                default:
                    using (TripleDES tDES = TripleDES.Create()) { IV = tDES.IV; }
                    break;
            }
        }
        /// <summary>
        /// Handles the encryption process based on which encryption the user chose
        /// </summary>
        /// <param name="algorithm">Name of the encryption algorithm</param>
        /// <param name="decryptMessage">The message to encrypt</param>
        public void Encrypt(string algorithm,string encryptMessage)
        {
            switch (algorithm)
            {
                case "DES":
                    EncryptedMessage = des.Encrypt(Encoding.UTF8.GetBytes(encryptMessage),Key,IV);
                    break;
                case "TDES":
                    EncryptedMessage = tDES.Encrypt(Encoding.UTF8.GetBytes(encryptMessage), Key, IV);
                    break;
                default:
                    EncryptedMessage = tDES.Encrypt(Encoding.UTF8.GetBytes(encryptMessage), Key, IV);
                    break;
            }
        }
        /// <summary>
        /// Handles the decryption process based on which encryption the user chose
        /// </summary>
        /// <param name="algorithm">Name of the decryption algorithm</param>
        /// <param name="decryptMessage">The message to decrypt</param>
        public void Decrypt(string algorithm,string decryptMessage)
        {
            switch (algorithm)
            {
                case "DES":
                    DecryptedMessage = des.Decrypt(Convert.FromBase64String(decryptMessage), Key, IV);
                    break;
                case "TDES":
                    DecryptedMessage = tDES.Decrypt(Convert.FromBase64String(decryptMessage), Key, IV);
                    break;
                default:
                    DecryptedMessage = tDES.Decrypt(Convert.FromBase64String(decryptMessage), Key, IV);
                    break;
            }
        }
    }
}
