using System;

namespace NameSorter
{
    class NameSorter
    {
        /// <summary>
        /// The Entry of whole program.
        /// </summary>
        /// <param name="args">Only one and at least one parameter needed, indicating the path of input file.
        /// Output file will be put into the same directory and named "sorted-names-list".</param>
        static void Main(string[] args)
        {
            try
            {
                if (args != null && !string.IsNullOrEmpty(args[0]))
                {
                    IO currentIO = new IO(args[0], "sorted-names-list.txt");
                    string rawNameList = currentIO.ReadFile();
                    ISorter sorter = new Sorter();
                    ISorter descendingSorter = new DescendingSorter();
                    if (!string.IsNullOrEmpty(args[1]) && args[1].Equals("d"))
                    {
                        string sortedNameList = NameUtil.NameCombine(descendingSorter.NameSort(NameUtil.NameSplit(rawNameList)));
                        currentIO.WriteFile(sortedNameList);
                        Console.WriteLine(sortedNameList);
                    }
                    else
                    {
                        string sortedNameList = NameUtil.NameCombine(sorter.NameSort(NameUtil.NameSplit(rawNameList)));
                        currentIO.WriteFile(sortedNameList);
                        Console.WriteLine(sortedNameList);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Argument");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Press Any Key to Continue...");
                Console.ReadKey();
            }
        }
    }
}
