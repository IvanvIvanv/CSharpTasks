namespace VinogradovIE_CatFramework
{
    public class CatException : ArgumentException
    {
        public CatException()
        {
        }

        public CatException(string? message) : base(message)
        {
        }

        public CatException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        public CatException(string? message, string? paramName) : base(message, paramName)
        {
        }

        public CatException(string? message, string? paramName, Exception? innerException) : base(message, paramName, innerException)
        {
        }
    }
}
