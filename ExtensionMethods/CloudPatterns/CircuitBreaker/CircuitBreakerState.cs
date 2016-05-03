namespace CloudPatterns.CircuitBreaker
{
    /// <summary> Represents the state of the circuit breaker.</summary>
    public enum CircuitBreakerState
    {
        Closed,
        Open,
        HalfOpen,
        None
    }
}
