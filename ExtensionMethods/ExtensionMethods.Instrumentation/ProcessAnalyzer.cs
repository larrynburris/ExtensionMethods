using System;

namespace ExtensionMethods.Instrumentation
{
    public sealed class ProcessAnalyzer
    {
        public Guid Id { get; set; }

        private DateTime _startedAt;

        public string ProcessName { get; set; }

        public ProcessAnalyzer()
        {
            Id = Guid.NewGuid();
        }

        public void Start()
        {
            _startedAt = DateTime.Now;
        }

        public int GetElapsedTime()
        {
            return (int)Math.Round(new TimeSpan(DateTime.Now.Ticks - _startedAt.Ticks).TotalSeconds, 0);
        }
    }
}
