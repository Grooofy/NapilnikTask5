using System.Security.Cryptography;

namespace NapilnikTask5
{
    public class Encoder : IEncoder
    {
        public string Encode(HashAlgorithm algorithm, int number)
        {
            byte[] hash = algorithm.ComputeHash(BitConverter.GetBytes(number));
            string code = Convert.ToBase64String(hash);
            return code;
        }
    }
}