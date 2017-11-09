using System.Linq;

namespace NameSorter
{
    /// <summary>
    /// The sort algorithm of NameSorter.
    /// </summary>
    public class Sorter:ISorter
    {
        /// <summary>
        /// Sort a name list in alphabet order.
        /// </summary>
        /// <param name="NameList">The unsorted name list.</param>
        /// <returns>The sorted name list.</returns>
        public string[] NameSort(string[] nameList)
        {
            return nameList.OrderBy(x => x.Split(' ').Last()).ThenBy(x => x).ToArray();
        }
    }

    public class DescendingSorter : ISorter
    {
        public string[] NameSort(string[] nameList)
        {
            return nameList.OrderByDescending(x => x.Split(' ').Last()).ThenBy(x => x).ToArray();
        }
    }
}
