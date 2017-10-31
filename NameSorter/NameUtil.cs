using System;

namespace NameSorter
{


    /// <summary>
    /// Formalizing the raw input.
    /// </summary>
    public static class NameUtil
    {
        /// <summary>
        /// Split the name stream into seprate names.
        /// </summary>
        /// <param name="nameStream">The raw input of name list.</param>
        /// <returns>An array of names.</returns>
        public static string[] NameSplit(string nameStream)
        {
            return nameStream.Split(new string[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
        }

        /// <summary>
        /// Combining the names into name stream.
        /// </summary>
        /// <param name="nameList">An array of names.</param>
        /// <returns>The combined name stream.</returns>
        public static string NameCombine(string[] nameList)
        {
            string nameStream = string.Empty;
            foreach (string name in nameList)
            {
                nameStream += name + "\r\n";
            }
            return nameStream;
        }
    }
}
