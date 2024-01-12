using System;

namespace Forest_PRO
{
    class Program
    {
        public static void Main(string[] args)
        {
            // V = 1/3 pi *(r*r)v
            try
            {
                Tree tree = new Tree();
                tree.radius = 2;
                tree.height = 2;
                tree.Growing();

                LeafTree leaf_tree = new LeafTree();
                leaf_tree.radius = 2;
                leaf_tree.height = 2;
                leaf_tree.Growing();

                PineTree pine_tree = new PineTree();
                pine_tree.radius = 2;
                pine_tree.height = 2;
            }
            catch (Exception e)
            { 
                Console.WriteLine(e.Message); 
            }
        }
    }
}
