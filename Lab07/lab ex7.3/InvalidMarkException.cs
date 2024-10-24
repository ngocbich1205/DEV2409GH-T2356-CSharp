
namespace lab_ex7._3
{
    [Serializable]
    internal class InvalidMarkException : Exception
    {
        public InvalidMarkException()
        {
        }

        public InvalidMarkException(string? message) : base(message)
        {
        }

        public InvalidMarkException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}