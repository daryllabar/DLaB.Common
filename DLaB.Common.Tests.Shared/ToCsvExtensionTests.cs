#nullable enable
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace DLaB.Common.Tests.Shared
{
    [TestClass]
    public class ToCsvExtensionsTests
    {
        [TestMethod]
        public void ToCsv_WithOptions_SkipNullAndEmpty()
        {
            var values = new List<string?> { "One", null, "", "Two" };

            var csv = values.ToCsv();

            Assert.AreEqual("One, Two", csv);
        }

        [TestMethod]
        public void ToCsv_WithOptions_DefaultValueWhenNoValuesRemain()
        {
            var values = new List<string?> { null, "" };

            var csv = values.ToCsv(new ToCsvOptions
            {
                DefaultValue = "None"
            });

            Assert.AreEqual("None", csv);
        }

        [TestMethod]
        public void ToCsv_WithOptions_SkipEmptyOnly_DoesNotSkipNull()
        {
            var values = new List<string?> { "One", null, "", "Two" };

            var csv = values.ToCsv(new ToCsvOptions
            {
                SkipNullValues = false
            });

            Assert.AreEqual("One, , Two", csv);
        }

        [TestMethod]
        public void ToCsv_WithOptions_EmptyStringWhenNoValuesAndNoDefault()
        {
            var values = new List<string?> { null, "" };

            var csv = values.ToCsv();

            Assert.AreEqual(string.Empty, csv);
        }
    }
}
