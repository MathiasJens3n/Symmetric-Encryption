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

        public byte[] Key { get; private set; }
        public byte[] IV { get; private set; }
        public byte[] EncryptedMessage { get; private set; }
        public byte[] DecryptedMessage { get; private set; }
        /// <summary>
        /// Generates a for the chosen algorithm
        /// </summary>
        public void GenerateKey(IEncrypter encrypter)
        {
            Key = encrypter.GenerateKey();
        }
        /// <summary>
        /// Generates a vector for the chosen algorithm
        /// </summary>
        public void GenerateIV(IEncrypter encrypter)
        {
            IV = encrypter.GenerateIV();
        }
        /// <summary>
        /// Handles the encryption process based on which encryption the user chose
        /// </summary>
        /// <param name="algorithm">Name of the encryption algorithm</param>
        /// <param name="decryptMessage">The message to encrypt</param>
        public void Encrypt(byte[] encryptMessage, IEncrypter encrypter)
        {
            EncryptedMessage = encrypter.Encrypt(encryptMessage, Key, IV);
        }
        /// <summary>
        /// Handles the decryption process based on which encryption the user chose
        /// </summary>
        /// <param name="algorithm">Name of the decryption algorithm</param>
        /// <param name="decryptMessage">The message to decrypt</param>
        public void Decrypt(byte [] decryptMessage, IEncrypter encrypter)
        {
           DecryptedMessage = encrypter.Decrypt(decryptMessage,Key,IV);   
        }
    }
}
