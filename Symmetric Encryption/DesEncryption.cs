using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Symmetric_Encryption
{
    //Class that handles DES Encryption
    internal class DesEncryption : IEncrypter
    {
        /// <summary>
        /// Generates a DES Key
        /// </summary>
        /// <returns>DES key as byte array</returns>
        public byte[] GenerateKey()
        {
            using (DES DES = DES.Create()) { return DES.Key; }
        }
        /// <summary>
        /// Generates a DES vector
        /// </summary>
        /// <returns>DES vector as byte array</returns>
        public byte[] GenerateIV()
        {
            using (DES DES = DES.Create()) { return DES.IV; }
        }
        /// <summary>
        /// Encrypts message with DES
        /// </summary>
        /// <param name="encryptMessage">Message to be encrypted</param>
        /// <param name="key">Encryption key</param>
        /// <param name="iv">Vector</param>
        /// <returns>Encrypted message as a byte array</returns>
        public byte[] Encrypt(byte[] encryptMessage, byte[] key, byte[] iv)
        {
            try
            {
                //Encrypts data in memory using MemoryStream
                using (MemoryStream mStream = new MemoryStream())
                {
                    using (DES des = DES.Create())

                    using (ICryptoTransform encryptor = des.CreateEncryptor(key, iv))

                    using (var cStream = new CryptoStream(mStream, encryptor, CryptoStreamMode.Write))
                    {
                        cStream.Write(encryptMessage, 0, encryptMessage.Length);
                    }

                    // Get an array of bytes from the MemoryStream that holds the encrypted data.
                    byte[] ret = mStream.ToArray();

                    return ret;
                }
            }
            catch (CryptographicException)
            {
                throw;
            }
        }
        /// <summary>
        /// Decrypts messages that a encrypted with DES
        /// </summary>
        /// <param name="decryptMessage">Message to decrypt </param>
        /// <param name="key">Key that message is encrypteed with</param>
        /// <param name="iv">Vector message is encrypted with</param>
        /// <returns>Decrypted message</returns>
        public byte[] Decrypt(byte[] decryptMessage, byte[] key, byte[] iv)
        {
            //Decrypts data in memory using MemoryStream
            try
            {
                byte[] decrypted = new byte[decryptMessage.Length];
                int offset = 0;

                using (MemoryStream mStream = new MemoryStream(decryptMessage))
                {
                    using (DES des = DES.Create())

                    using (ICryptoTransform decryptor = des.CreateDecryptor(key, iv))


                    using (var cStream = new CryptoStream(mStream, decryptor, CryptoStreamMode.Read))
                    {
                        //Keep reading from the cryptostream until it finishes and return 0
                        int read = 1;

                        while (read > 0)
                        {
                            read = cStream.Read(decrypted, offset, decrypted.Length - offset);
                            offset += read;
                        }
                    }
                }
                return decrypted;
            }
            catch (CryptographicException e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }
    }
}
