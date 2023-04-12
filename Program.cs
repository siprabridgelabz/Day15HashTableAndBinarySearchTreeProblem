namespace BinarySearchTreeProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("*****Welcome to the Hash Table and Binary Search Tree  problem*****");

            BinarySearchTree<int> binarySearch = new BinarySearchTree<int>(56);
            binarySearch.Add(30);
            binarySearch.Add(70);
            binarySearch.Display();

        }
    }
}