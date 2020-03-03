using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;

namespace Lemonway.WebService.Tests
{
    public class FibonacciAttribute : Attribute, ITestDataSource
    {
        public string GetDisplayName(MethodInfo methodInfo, object[] data)
        {
            if (data != null)
                return string.Format(CultureInfo.CurrentCulture, "{0} ({1})", methodInfo.Name, string.Join(",", data));

            return null;
        }

        IEnumerable<object[]> ITestDataSource.GetData(MethodInfo methodInfo)
        {
            yield return new object[] { 1, 1 };
            yield return new object[] { 2, 1 };
            yield return new object[] { 3, 2 };
            yield return new object[] { 4, 3 };
            yield return new object[] { 5, 5 };
            yield return new object[] { 6, 8 };
            yield return new object[] { -101, -1 };
            yield return new object[] { 1000, -1 };

        }
    }
}
