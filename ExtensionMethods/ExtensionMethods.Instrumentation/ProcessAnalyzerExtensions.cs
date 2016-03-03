using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ExtensionMethods.Instrumentation
{
    public static class ProcessAnalyzerExtensions
    {
        private static Dictionary<Guid, Stopwatch> _Stopwatches = new Dictionary<Guid, Stopwatch>();

        public static double GetPreciseElapsedTime(this ProcessAnalyzer analyzer)
        {
            var startedAt = analyzer.GetPrivateVariableFromObject<ProcessAnalyzer, DateTime>("_startedAt");
            return new TimeSpan(DateTime.Now.Ticks - startedAt.Ticks).TotalSeconds;
        }

        public static void StartWithPrecision(this ProcessAnalyzer analyzer)
        {
            _Stopwatches[analyzer.Id] = Stopwatch.StartNew();
        }

        public static long GetReallyPreciseElapsedTime(this ProcessAnalyzer analyzer)
        {
            return _Stopwatches[analyzer.Id].ElapsedMilliseconds;
        }
    }
}
