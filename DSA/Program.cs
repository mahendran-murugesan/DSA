// See https://aka.ms/new-console-template for more information

using DSA;
using DSA.Search;
using DSA.Strings;
using DSA.Trees;

Console.WriteLine("Hello, World!");

// var bst = new BST(10);
// bst.Insert(5);
// bst.Insert(15);
// bst.Insert(2);
// bst.Insert(5);
// bst.Insert(13);
// bst.Insert(22);
// bst.Insert(1);
// bst.Insert(14);
//
// var result = ClosesetValueinBST.FindClosestValueInBst(bst, 12);

// int R = 4;
// int C = 4;
//  
// int[][] A = new int[][] { new int[] { 0, 1, 1, 0 },
//         new int[] { 1, 1, 1, 1 },
//         new int[] { 1, 1, 1, 1 },
//         new int[] { 1, 1, 0, 0 } };
// Console.Write("Area of maximum rectangle is "
//               + MaximumRectangle.maxRectangle(R, C, A));

var result = ThreeLargestNumbers.FindThreeLargestNumbers(new int[] { 141, 1, 17, -7, -17, -27, 18, 541, 8, 7, 7});


Console.ReadKey();