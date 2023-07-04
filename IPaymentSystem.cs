namespace NapilnikTask5
{
    public interface IPaymentSystem
    {
        string GetPayingLink(Order order);
    }
}