namespace LinkedListEx;

public class Execute
{
    public static void Main()
    {
        LinkedList list = new LinkedList();
        Coche coche = new Coche(4, "Negro");
        Coche coche2 = new Coche(4, "Azul");
        Coche coche3 = new Coche(4, "Rojo");
        Coche coche4 = new Coche(4, "Verde");

        list.InsertFirst(coche);
        list.InsertFirst(coche2);
        list.InsertFirst(coche3);
        list.InsertLast(coche4);
        list.Remove(coche);
        list.Print();
        
        Console.WriteLine(list.IsEmpty());
        
        Console.WriteLine(list.GetFirstObject());
        Console.WriteLine(list.GetLastObject());
        Console.WriteLine(list.GetObjectAtPosition(7));

        
        
        

    }
}