using System.Linq;

namespace NameSorter
{
    /// <summary>
    /// The sort algorithm of NameSorter.
    /// </summary>
    public static class Sorter
    {
        /// <summary>
        /// Sort a name list in alphabet order.
        /// </summary>
        /// <param name="NameList">The unsorted name list.</param>
        /// <returns>The sorted name list.</returns>
        public static string[] NameSort(string[] NameList)
        {
            return NameList.OrderBy(x => x.Split(' ').Last()).ThenBy(x => x).ToArray();
        }
    }
}
