
namespace lab_ex7._4
{
    [Serializable]
    internal class AmountException : Exception
    {
        public AmountException()
        {
        }

        public AmountException(string? message) : base(message)
        {
        }

        public AmountException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}