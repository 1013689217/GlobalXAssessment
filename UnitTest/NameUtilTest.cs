using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    /// <summary>
    /// The unit test of NameUtil class.
    /// </summary>
    [TestClass]
    public class NameUtilTest
    {
        /// <summary>
        /// Test the correctness of spliting raw name stream.
        /// </summary>
        [TestMethod]
        public void NameSplitTest()
        {
            string input = "a\rb\nc\r\n\r\n";
            string[] output = {"a","b","c"};
            string[] result = NameSorter.NameUtil.NameSplit(input);
            Assert.AreEqual(output.Length, result.Length);
            for (int i=0; i<output.Length; i++)
            {
                Assert.AreEqual(output[i], result[i]);
            }
        }

        /// <summary>
        /// Test the correctness of combining name array into name stream.
        /// </summary>
        [TestMethod]
        public void NameCombineTest()
        {
            string[] input = {"a","b","c"};
            string output = "a\r\nb\r\nc\r\n";
            Assert.AreEqual(output, NameSorter.NameUtil.NameCombine(input));
        }
    }
}
