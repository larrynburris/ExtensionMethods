using ExtensionMethods.Instrumentation;
using NUnit.Framework;
using System;
using System.Diagnostics;
using System.Threading;

namespace ExtensionMethods.Tests
{
    [TestFixture]
    class InstrumentationTests
    {
        [Test]
        public void Test_GetTotalSeconds_ToShowNotPrecise()
        {
            var analyzer = new ProcessAnalyzer();
            analyzer.Start();
            Thread.Sleep(750);
            Assert.AreEqual(1, analyzer.GetElapsedTime());
        }

        [Test]
        public void Test_GetPrivateVariableFromObject()
        {
            var analyzer = new ProcessAnalyzer();
            analyzer.Start();
            Thread.Sleep(750);
            var startedtime = analyzer.GetPrivateVariableFromObject<ProcessAnalyzer, DateTime>("_startedAt");
            Debug.WriteLine(startedtime.ToJsonString());
        }

        [Test]
        public void Test_GetPreciseElapsedTime()
        {
            var analyzer = new ProcessAnalyzer();
            analyzer.Start();
            Thread.Sleep(750);
            var elapsed = analyzer.GetPreciseElapsedTime();
            Assert.IsTrue(elapsed >= 0.75 && elapsed < 0.78);
            //Reflection has a time cost.
        }

        [Test]
        public void Test_GetReallyPreciseElapsedTime()
        {
            var analyzer = new ProcessAnalyzer();
            analyzer.StartWithPrecision();
            Thread.Sleep(750);
            Assert.AreEqual(750, analyzer.GetReallyPreciseElapsedTime());
        }
    }
}
