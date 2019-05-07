using System;

namespace AddressExample
{
    public class PrivateKey
    {
        private readonly string _value;

        public PrivateKey(string value)
        {
            // Validation
            // "b4eb8e8b343e2cce46db4e7571ec1d9654693cca200bc41cc20148355ca62ad9"
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException(nameof(value));
            }

            if (value.Length != 64)
            {
                throw new ArgumentOutOfRangeException(nameof(value), "", "private key is not 64 hex character");
            }

            _value = value;
        }

        public PrivateKey(byte[] bytes)
        {
            // Validation
            _value = ToHex(bytes);
        }

        private string ToHex(byte[] bytes)
        {
            throw new NotImplementedException();
        }

        public string Unwrap()
        {
            return _value;
        }
    }
}