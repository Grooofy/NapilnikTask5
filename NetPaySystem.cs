using System.Security.Cryptography;

namespace NapilnikTask5
{
    public class NetPaySystem : IPaymentSystem
    {
        private const string LinkLine = "pay.system1.ru/order?amount=";
        private const string HashLine = "&hash=";
        
        private Encoder _encoderMD5;
        private MD5 _md5;

        public NetPaySystem()
        {
            _encoderMD5 = new Encoder();
            _md5 = MD5.Create();
        }

        public string GetPayingLink(Order order)
        {
            string code = _encoderMD5.Encode(_md5, order.Id);
            return LinkLine + order.Amount + HashLine + code;
        }
    }
}