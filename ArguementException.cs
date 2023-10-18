using System.Runtime.Serialization;

namespace CurrencyConverterPort
{
    [Serializable]
    internal class ArguementException : Exception
    {
        public ArguementException()
        {
        }

        public ArguementException(string? message) : base(message)
        {
        }

        public ArguementException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected ArguementException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}