namespace Problem5
{
    using System;

    public class TestingBitArray64
    {
        public static void TestImplementations()
        {
            BitArray64 firstArray = new BitArray64(65765756);
            BitArray64 secondArray = new BitArray64(65765756);
            BitArray64 thirdArray = new BitArray64(4534);

            // Testing GetHashCode()
            Console.WriteLine("Hash code: " + firstArray.GetHashCode());
            Separator();

            // Testing Equals()
            Console.WriteLine("The first array is equal to the second? " + firstArray.Equals(secondArray));
            Separator();

            // Testing Indexer
            Console.WriteLine("Second index of array: " + firstArray[2]);
            Separator();

            Console.WriteLine("FirstArray is different from secondArray?");
            Console.WriteLine(firstArray != secondArray);
            Separator();

            Console.WriteLine("FirstArray is equal to thrirdArray?");
            Console.WriteLine(firstArray == thirdArray);

        }

        public static void Separator()
        {
            Console.WriteLine(new string('-', 60));
        }
    }
}
