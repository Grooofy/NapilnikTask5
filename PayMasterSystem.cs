using System.Security.Cryptography;

namespace NapilnikTask5
{
    public class PayMasterSystem : IPaymentSystem
    {
        private const string LinkLine = "order.system2.ru/pay?hash=";
        private Encoder _encoderMD5;
        private MD5 _md5;
        
        public PayMasterSystem() 
        {
            _encoderMD5 = new Encoder();
            _md5 = MD5.Create();
        }

        public string GetPayingLink(Order order)
        {
            string code = _encoderMD5.Encode(_md5, order.Amount + order.Id);
            return LinkLine + code;
        }
    }
}