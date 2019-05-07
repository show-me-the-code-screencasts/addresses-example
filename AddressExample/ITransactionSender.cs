namespace AddressExample
{
    public interface ITransactionSender
    {
        string Send(PrivateKey privateKey, RawTransaction transaction);
    }

    public class RawTransaction
    {
        public Address ToAddress { get; set; }
        public string Amount { get; set; }
    }
}