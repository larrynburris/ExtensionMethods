using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace ExtensionMethods.Tests
{
    [TestFixture]
    public class ExceptionExtensionsTests
    {
        [Test]
        public void DivideBy0()
        {
            try
            {
                Divide(10, 0);
                Assert.Fail("Should throw exception");
            }
            catch(Exception ex)
            {
                //Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.FullMessage());
                Assert.IsInstanceOf<ApplicationException>(ex);
            }
        }

        private double Divide(int v1, int v2)
        {
            try
            {
                return v1 / v2;
            }
            catch(Exception ex)
            {
                var invalidOpEx = new InvalidOperationException("Invalid operation", ex);
                var message = string.Format("Divide failed - amount {0}, by {1}", v1, v2);
                throw new ApplicationException(message, invalidOpEx);
            }
        }
    }
}
