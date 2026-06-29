using Core;

Container<string> box = new Container<string>();
box.Store("Hello");
box.Store("World");
Console.WriteLine(box.GetItem());

Container<int> numberBox = new Container<int>();
numberBox.Store(42);
Console.WriteLine(numberBox.GetItem());
