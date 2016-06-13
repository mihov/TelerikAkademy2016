namespace GenericList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class StartUp
    {
        static void Main()
        {
            var genList = new GenericList<int>(2);
            genList.Add(11);
            genList.Add(22);
            genList.Add(33);
            genList.Add(44);
            genList.Add(55);
            genList.Add(66);

            Console.Write("List: ");
            Console.WriteLine(genList);
            Console.WriteLine($"Number of elements: {genList.Count}");
            Console.WriteLine($"Index of 33 is at : {genList.IndexOf(33)}");
           
            Console.WriteLine($"\nElement at index 4 is: {genList[4]}");
            genList.Remove(4);
            Console.WriteLine($"Element at index 4 is removed: { genList}");

            genList.Insirt(3, 444);
            Console.WriteLine($"\n444 is inserted at index: {genList}");

            Console.WriteLine($"Max value is: {genList.Max()}");
            Console.WriteLine($"Min value is: {genList.Min()}");

            genList.Clear();
            Console.Write("List: ");
            Console.WriteLine(genList);
        }
    }
}
