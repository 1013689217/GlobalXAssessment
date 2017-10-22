using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    /// <summary>
    /// The unit test of IO class.
    /// </summary>
    [TestClass]
    public class IOTest
    {
        /// <summary>
        /// Test the correctness of reading a file.
        /// </summary>
        [TestMethod]
        public void ReadFileTest()
        {
            string result = "abcd\nefgh\n";
            NameSorter.IO currentIO = new NameSorter.IO("read.txt","");
            Assert.AreEqual(result, currentIO.ReadFile());
        }

        /// <summary>
        /// Test the correctness of writing a file.
        /// </summary>
        [TestMethod]
        public void WriteFileTest()
        {
            string result = "abcd\nefgh\n";
            NameSorter.IO currentIO = new NameSorter.IO("write.txt", "write.txt");
            currentIO.WriteFile(result);
            Assert.AreEqual(result, currentIO.ReadFile());
        }

        /// <summary>
        /// Test the exception throwing when input file path is null.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NullInputPathTest()
        {
            NameSorter.IO currentIO = new NameSorter.IO(null, "write.txt");
        }

        /// <summary>
        /// Test the exception throwing when input file path is empty.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EmptyInputPathTest()
        {
            NameSorter.IO currentIO = new NameSorter.IO(string.Empty, "write.txt");
        }

        /// <summary>
        /// Test the exception throwing when there is no input file.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(FileNotFoundException))]
        public void InvalidInputPathTest()
        {
            NameSorter.IO currentIO = new NameSorter.IO("nothing.txt", "write.txt");
            currentIO.ReadFile();
        }

        /// <summary>
        /// Test the exception throwing when output file name is null.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(DirectoryNotFoundException))]
        public void NullOutputPathTest()
        {
            NameSorter.IO currentIO = new NameSorter.IO("read.txt", null);
            currentIO.WriteFile("");
        }

        /// <summary>
        /// Test the exception throwing when output file name is empty.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(DirectoryNotFoundException))]
        public void EmptyOutputPathTest()
        {
            NameSorter.IO currentIO = new NameSorter.IO("read.txt", string.Empty);
            currentIO.WriteFile("");
        }
    }
}
