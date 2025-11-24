using System;

public class Program
{
    static void Main(string[] args)
    {
        // This project is here for you to use as a "Sandbox" to play around
        // with any code or ideas you have that do not directly apply to
        // one of your projects.

        //Console.WriteLine("Hello Sandbox World!");

        LinkedList<string> myList = new LinkedList<string>();
        myList.AddLast("Minnie");
        myList.AddLast("Minnky");
        myList.AddLast("Mindy");
        myList.AddLast("Mouse");

        myList.AddFirst("Selly");
        myList.AddFirst("Sam");

        LinkedListNode<string> node = myList.Find("Mindy");
        myList.AddAfter(node, "Mindy-2");

        myList.RemoveFirst();

        Counsole.WriteLine(myList.Count());

        foreach(var x in myList)
        Console.WriteLine(x);




    }
}