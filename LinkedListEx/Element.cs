using System.Security.Cryptography.X509Certificates;

namespace LinkedListEx;

public class Element
{
    public Object Obj;
    public Element Next;
    
    public Element(Object newObject)
    {
        Obj = newObject;
        Next = null;
    }

    public void SetNext(Element newNext)
    {
        Next = newNext;
    }

    public Element GetNext()
    {
        return Next;
    }

    public Object GetObject()
    {
        return Obj;
    }

    public void SetObject(Object newObject)
    {
        Obj = newObject;
    }

    public void Delete()
    {
        Obj = null;
        Next = null;
    }
}