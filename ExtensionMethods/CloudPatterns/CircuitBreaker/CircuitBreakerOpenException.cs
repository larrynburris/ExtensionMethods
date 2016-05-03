using System;

namespace CloudPatterns.CircuitBreaker
{
    public class CircuitBreakerOpenException : Exception
    {
        public CircuitBreakerOpenException() { }

        public CircuitBreakerOpenException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
