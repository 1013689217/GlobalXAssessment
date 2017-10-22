using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    /// <summary>
    /// The unit test of sorter class.
    /// </summary>
    [TestClass]
    public class SorterTest
    {
        /// <summary>
        /// Test the correctness of sort algorithm.
        /// </summary>
        [TestMethod]
        public void NameSortTest()
        {
            string[] input = { "Janet Parsons", "Vaughn Lewis", "Adonis Julius Archer", "Shelby Nathan Yoder",
                "Marin Alvarez","London Lindsey","Beau Tristan Bentley","Leo Gardner","Hunter Uriah Mathew Clarke",
                "Mikayla Lopez","Frankie Conner Ritter"};
            string[] output = { "Marin Alvarez", "Adonis Julius Archer", "Beau Tristan Bentley",
                "Hunter Uriah Mathew Clarke","Leo Gardner","Vaughn Lewis","London Lindsey","Mikayla Lopez",
                "Janet Parsons","Frankie Conner Ritter","Shelby Nathan Yoder"};
            string[] result = NameSorter.Sorter.NameSort(input);
            Assert.AreEqual(output.Length, result.Length);
            for (int i=0; i<output.Length; i++)
            {
                Assert.AreEqual(output[i], result[i]);
            }
        }
    }
}
