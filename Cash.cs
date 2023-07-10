namespace NapilnikTask5
{
    public class Cash
    {
        public void ShowLink(IPaymentSystem iPaymentSystem, Order order)
        {
            Console.WriteLine(iPaymentSystem.GetPayingLink(order));
        }
    }
}