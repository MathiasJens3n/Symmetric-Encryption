using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Symmetric_Encryption
{
    internal class TDESEncryption : IEncrypter
    {
        /// <summary>
        /// Generates a Triple DES Key
        /// </summary>
        /// <returns>Triple DES key as byte array</returns>
        public byte[] GenerateKey()
        {
            using (TripleDES tDES = TripleDES.Create()) { return tDES.Key; }
        }
        /// <summary>
        /// Generates a Triple DES Vector
        /// </summary>
        /// <returns>Triple DES vector as byte array</returns>
        public byte[] GenerateIV()
        {
            using (TripleDES tDES = TripleDES.Create()) { return tDES.IV; }
        }
        /// <summary>
        /// Encrypts message with TripleDES
        /// </summary>
        /// <param name="encryptMessage">Message to be encrypted</param>
        /// <param name="key">Encryption key</param>
        /// <param name="iv">Vector</param>
        /// <returns>Encrypted message as a byte array</returns>
        public byte[] Encrypt(byte[] encryptMessage, byte[] key, byte[] iv)
        {
            //Encrypts data in memory using MemoryStream
            using (MemoryStream mStream = new MemoryStream())
            {
                using (TripleDES des = TripleDES.Create())

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
        /// <summary>
        /// Encrypts message with Triple DES
        /// </summary>
        /// <param name="encryptMessage">Message to be encrypted</param>
        /// <param name="key">Encryption key</param>
        /// <param name="iv">Vector</param>
        /// <returns>Encrypted message as a byte array</returns>
        public byte[] Decrypt(byte[] decryptMessage, byte[] key, byte[] iv)
        {
            //Decrypts data in memory using MemoryStream
            try
            {
                byte[] decrypted = new byte[decryptMessage.Length];
                int offset = 0;

                using (MemoryStream mStream = new MemoryStream(decryptMessage))
                {
                    using (TripleDES des = TripleDES.Create())

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
