namespace AddressExample
{
    public class PublicKey
    {
        private readonly string _value;

        public PublicKey(string value)
        {
            // Validation

            _value = value;
        }

        public string Unwrap()
        {
            return _value;
        }

        public Address ToAddress()
        {
            return new Address(AddressFromPublicKey(_value));
        }

        public static string AddressFromPublicKey(string pubKeyHex)
        {
            return null;
        }
    }
}