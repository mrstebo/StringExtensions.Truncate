using NUnit.Framework;

namespace StringExtensions.Truncate.Tests
{
    [TestFixture]
    [Parallelizable]
    public class TruncateExtensionTests
    {
        [Test]
        public void Truncate_With_NullValue_ShouldReturn_Null()
        {
            const string value = null;

            var result = value.Truncate(5);

            Assert.IsNull(result);
        }

        [Test]
        public void Truncate_With_ValueLengthLessThanMaxLength_ShouldReturn_Value()
        {
            const string value = "Hello";

            var result = value.Truncate(10);

            Assert.AreEqual("Hello", result);
        }

        [Test]
        public void Truncate_With_ValueMoreThanMaxLength_ShouldReturn_TruncatedValue()
        {
            const string value = "Hello";

            var result = value.Truncate(2);

            Assert.AreEqual("He", result);
        }

        [Test]
        public void Truncate_With_ValueMoreThanMaxValue_And_Suffix_ShouldReturn_SuffixedTruncatedValue()
        {
            const string value = "Hello";

            var result = value.Truncate(2, "...");

            Assert.AreEqual("He...", result);
        }
    }
}
