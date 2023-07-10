namespace NapilnikTask5
{
    class Program
    {
        static void Main(string[] args)
        {         
            Cash cash = new Cash();
            Order order = new Order(20, 50);
            
            NetPaySystem netPaySystem = new NetPaySystem();
            PayMasterSystem payMasterSystem = new PayMasterSystem();
            UnitPaySystem unitPaySystem = new UnitPaySystem();

            cash.ShowLink(netPaySystem, order);
            cash.ShowLink(payMasterSystem, order);
            cash.ShowLink(unitPaySystem, order);
        }
    }
}