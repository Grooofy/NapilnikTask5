using System.Security.Cryptography;

namespace NapilnikTask5
{
    public interface IEncoder
    {
        string Encode(HashAlgorithm algorithm, int number);
    }
}