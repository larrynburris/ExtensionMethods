using System.Collections.Concurrent;

namespace CloudPatterns.CircuitBreaker
{
    public class CircuitBreakerStateStoreFactory
    {
        private static ConcurrentDictionary<string, ICircuitBreakerStateStore> _stateStores =
            new ConcurrentDictionary<string, ICircuitBreakerStateStore>();

        internal static ICircuitBreakerStateStore GetCircuitBreakerStateStore(string key)
        {
            // There is only one type of ICircuitBreakerStateStore to return...
            // The ConcurrentDictionary keeps track of ICircuitBreakerStateStore objects (across threads)
            // For example, a store for a db connection, web service client, and NAS storage could exist

            if (!_stateStores.ContainsKey(key))
            {
                _stateStores.TryAdd(key, new CircuitBreakerStateStore(key));
            }

            return _stateStores[key];
        }
    }
}
