//  Test out my stack 
using TryingToRememberDataStructures.BST;
using TryingToRememberDataStructures.Stack;

var letsMakeAStack = new MyStack("first item");

letsMakeAStack.InsertItem("second item in stack");
letsMakeAStack.InsertItem("third item in stack");
letsMakeAStack.InsertItem("fourth item in stack");

letsMakeAStack.PopTop();
letsMakeAStack.PopTop();
letsMakeAStack.PopTop();



var myTree = new BinarySearchTree(42);


myTree.InsertNode(24);
myTree.InsertNode(64);
myTree.InsertNode(74);
myTree.InsertNode(12);


myTree.InsertNode(26);
myTree.InsertNode(55);
myTree.InsertNode(5);
myTree.InsertNode(15);
myTree.InsertNode(27);



List<int> myList = new List<int>();

myList.Add(42);
myList.Add(24);
myList.Add(64);
myList.Add(74);
myList.Add(12);
myList.Add(26);
myList.Add(55);
myList.Add(5);
myList.Add(15);
myList.Add(27);



BinarySearchTree myTree2 = CreateTreeFromList(myList);




Console.WriteLine("stop");


 BinarySearchTree CreateTreeFromList(List<int> input)
{
    BinarySearchTree newTree = new BinarySearchTree(input[0]);

    for (var item = 1; item < input.Count; item++)
    {
        newTree.InsertNode(input[item]);
    }
    return newTree;
}