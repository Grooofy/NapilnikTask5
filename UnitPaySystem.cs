using System.Security.Cryptography;

namespace NapilnikTask5
{
    public class UnitPaySystem : IPaymentSystem
    {
        private const string LinkLine = "system3.com/pay?amount=";
        private const string HashLine ="&curency=RUB&hash=";
        private const int SecretCode = 101;

        private Encoder _encoderSHA1;
        private SHA1 _sha1;

        public UnitPaySystem()
        {
            _encoderSHA1 = new Encoder();
            _sha1 = SHA1.Create();
        }

        public string GetPayingLink(Order order)
        {
            string code = _encoderSHA1.Encode(_sha1, SecretCode +  order.Id + order.Amount);
            return LinkLine + order.Amount + HashLine + code;
        }
    }
}