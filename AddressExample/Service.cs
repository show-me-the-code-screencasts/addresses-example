namespace AddressExample
{
    public class Service
    {
        private readonly ITransactionSender _transactionSender;

        public void BetterFoo(string targetPrivateKey)
        {
            PrivateKey target = new PrivateKey(targetPrivateKey);
            PublicKey publicKey = target.ToPublicKey();
            Address targetAddress = publicKey.ToAddress();

            _transactionSender.Send(target, new RawTransaction
            {
                Amount = "1",
                ToAddress = targetAddress
            });
        }
    }
}