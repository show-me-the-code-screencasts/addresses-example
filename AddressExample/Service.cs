namespace AddressExample
{
    public class Service
    {
        private readonly ITransactionSender _transactionSender;

        public void BetterFoo(string targetPrivateKey)
        {
            PrivateKey target = new PrivateKey(targetPrivateKey);
            Address targetAddress = target.ToPublicKey().ToAddress();

            _transactionSender.Send(target, new RawTransaction
            {
                Amount = "1",
                ToAddress = targetAddress
            });
        }
    }
}