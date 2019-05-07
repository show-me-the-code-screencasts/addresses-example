namespace AddressExample
{
    public class Address
    {
        private readonly string _value;

        public Address(string value)
        {
            // Validation
            _value = value;
        }

        public string Unwrap()
        {
            return _value;
        }
    }
}