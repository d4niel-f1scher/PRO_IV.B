using System;

namespace Forest_PRO
{
    class Program
    {
        public static void Main(string[] args)
        {
            // V = 1/3 pi *(r*r)v
            Baobab baobab = new Baobab();
            baobab.radius = 2;
            baobab.height = 2;
            Console.WriteLine(baobab.Volume);
            
            Leaf_Tree leaf_tree = new Leaf_Tree();
            leaf_tree.radius = 2;
            leaf_tree.height = 2;
            Console.WriteLine(leaf_tree.Volume);

            Pine_Tree pine_tree = new Pine_Tree();
            pine_tree.radius = 2;
            pine_tree.height = 2;
            Console.WriteLine(pine_tree.Volume);

        }
    }
}
