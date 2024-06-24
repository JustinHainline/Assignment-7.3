using BinaryTree;

namespace Assignment_7._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var binaryTree = new BinaryTree<int>();

            binaryTree.Add(10);
            binaryTree.Add(25);
            binaryTree.Add(3);
            binaryTree.Add(48);
            binaryTree.Add(15);
            binaryTree.Add(16);
            binaryTree.Add(76);
            binaryTree.Add(18);

            binaryTree.PrintAsTree();

            Console.WriteLine(binaryTree.Contains(12));
            
            
        }
  

       
    }
}
