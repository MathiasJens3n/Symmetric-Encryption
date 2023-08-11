using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Symmetric_Encryption
{
    internal interface IEncrypter
    {
        public byte[] Encrypt(byte[] encryptMessage, byte[] key, byte[] iv);
        public byte[] Decrypt(byte[] decryptMessage, byte[] key, byte[] iv);
        public byte[] GenerateKey();
        public byte[] GenerateIV();
    }
}
