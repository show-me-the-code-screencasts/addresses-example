using System;

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

    }
}