using PracticingDataStructures.Models;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

#region Arrays

int[] intArray = { 3, 5, 10, 7, 12 }; // Integer type element
string[] stringArray = { "Apple", "Banana", "Cherry", "strawberry", "Fig" }; // Sting type element

int[] definedSizeArray = new int[5] { 3, 5, 10, 7, 12 }; // Array with defined size
int[] dynamicSizeArray = new int[] { }; // Array with Dynamic size

int[] vector = new int[5]; // Creates an array with 5 integer elements
vector[0] = 1;
vector[1] = 2;
vector[2] = 3;
vector[3] = 4;
vector[4] = 5;

int[,] matrix = new int[3, 3]; // Creates a 3x3 matrix of integers
matrix[0, 0] = 1;
matrix[0, 1] = 2;
matrix[0, 2] = 3;
matrix[1, 0] = 4;
matrix[1, 1] = 5;
matrix[1, 2] = 6;
matrix[2, 0] = 7;
matrix[2, 1] = 8;
matrix[2, 2] = 9;

int[,,] cube = new int[3, 3, 3]; // Creates a 3x3x3 cube of integers
cube[0, 0, 0] = 1;
cube[0, 0, 1] = 2;
cube[0, 0, 2] = 3;
cube[0, 1, 0] = 4;
cube[0, 1, 1] = 5;
cube[0, 1, 2] = 6;
cube[0, 2, 0] = 7;
cube[0, 2, 1] = 8;
cube[0, 2, 2] = 9;
// And so on for the other layers of the cube

#endregion

#region Linked lists

//Singly linked list
MyLinkedList<int> myList = new MyLinkedList<int>();
myList.Add(1);
myList.Add(2);
myList.Add(3);

Console.WriteLine("Singly Linked List:");
myList.Display();
Console.WriteLine("");

//Doubly linked list
// Create a LinkedList of integers
LinkedList<int> myDoublyList = new LinkedList<int>();

// Add elements to the list
myDoublyList.AddLast(1);
myDoublyList.AddLast(2);
myDoublyList.AddLast(3);

// Display the elements in the list
Console.WriteLine("Doubly LinkedList:");
foreach (int item in myDoublyList)
{
    Console.Write(item + " <-> ");
}
Console.WriteLine("null");
Console.WriteLine("");
Console.WriteLine("");

// Circular Linked List
var circularLinkedList = new MyCircularLinkedList<int>();
circularLinkedList.Add(1);
circularLinkedList.Add(2);
circularLinkedList.Add(3);

Console.WriteLine("Circular Linked List:");
circularLinkedList.Display();
#endregion

#region Stack

Stack<int> stack = new Stack<int>();

// Pushing elements onto the stack
stack.Push(1);
stack.Push(2);
stack.Push(3);

// Peeking at the top element without removing it
int topElement = stack.Peek();
Console.WriteLine("Top element: " + topElement);

// Popping elements from the stack
int poppedElement1 = stack.Pop();
int poppedElement2 = stack.Pop();

Console.WriteLine("Popped element 1: " + poppedElement1);
Console.WriteLine("Popped element 2: " + poppedElement2);

// Peek again to see the new top element
topElement = stack.Peek();
Console.WriteLine("Top element after popping: " + topElement);

#endregion

#region Queue
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");

// Create a new queue of integers
Queue<int> myQueue = new Queue<int>();

// Enqueue elements to the queue
myQueue.Enqueue(1);
myQueue.Enqueue(2);
myQueue.Enqueue(3);
myQueue.Enqueue(4);
myQueue.Enqueue(5);

// Dequeue and process elements in FIFO order
while (myQueue.Count > 0)
{
    int item = myQueue.Dequeue();
    Console.WriteLine($"Dequeued: {item}");
}
Console.WriteLine("");
Console.WriteLine("");
#endregion

app.Run();
