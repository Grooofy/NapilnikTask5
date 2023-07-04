namespace NapilnikTask5
{
    public interface IPaymentSystem
    {
        public string GetPayingLink(Order order);
    }
}