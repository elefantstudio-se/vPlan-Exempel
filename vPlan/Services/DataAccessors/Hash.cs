using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PCLCrypto;

namespace vPlan.Services.DataAccessors
{

    /// <summary>
    /// 
    /// </summary>
    class Hash
    {

        byte[] cryptoRandomBuffer = new byte[15];

        /// <summary>
        /// Creates a salted PBKDF2 hash of the password.
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        private static string GenerateHash(string input, string key)
        {
            var mac = WinRTCrypto.MacAlgorithmProvider.OpenAlgorithm(MacAlgorithm.HmacSha1);
            var keyMaterial = WinRTCrypto.CryptographicBuffer.ConvertStringToBinary(key, Encoding.UTF8);
            var cryptoKey = mac.CreateKey(keyMaterial);
            var hash = WinRTCrypto.CryptographicEngine.Sign(cryptoKey, WinRTCrypto.CryptographicBuffer.ConvertStringToBinary(input, Encoding.UTF8));
            return WinRTCrypto.CryptographicBuffer.EncodeToBase64String(hash);
        }

    }
}