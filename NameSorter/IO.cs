using System.IO;

namespace NameSorter
{
    /// <summary>
    /// Management of file reading and writing.
    /// </summary>
    class IO
    {
        /// <summary>
        /// inputPath discribes the path of input file and outputPath discribes the path of output file.
        /// </summary>
        private string inputPath;
        private string outputPath;

        /// <summary>
        /// Constructor of IO class.
        /// </summary>
        /// <param name="inputPath">The path of input file.</param>
        /// <param name="outputFileName">The name of output file.</param>
        public IO(string inputPath, string outputFileName)
        {
            FileInfo fileInfo = new FileInfo(inputPath);
            this.inputPath = inputPath;
            this.outputPath = fileInfo.DirectoryName + "/" + outputFileName;
        }

        /// <summary>
        /// Read a file; throw an exception when the file does not exist.
        /// </summary>
        /// <returns>Return the content of file as string.</returns>
        public string ReadFile()
        {
            using (FileStream fileStream = new FileStream(this.inputPath, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                using (StreamReader fileReader = new StreamReader(fileStream))
                {
                    string content = fileReader.ReadToEnd();
                    return content;
                }
            }
        }

        /// <summary>
        /// Write to a file; create the file if not exist.
        /// </summary>
        /// <param name="content">The content need write to the file, in string format.</param>
        public void WriteFile(string content)
        {
            using (FileStream fileStream = new FileStream(this.outputPath, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                using (StreamWriter fileWriter = new StreamWriter(fileStream))
                {
                    fileWriter.Write(content);
                }
            }   
        }
    }
}
