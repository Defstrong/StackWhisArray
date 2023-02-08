using StackWhisArray.StackWhisArray;

var stack = new CustomStack<int>();


stack.Push(1);
stack.Push(2);
stack.Push(3);

stack.Pop();

foreach(var ii in stack)
    Console.WriteLine(ii);