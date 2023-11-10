
using System.Security.Cryptography.X509Certificates;
using LinkedListEx;

public class LinkedList
{
    public Element FirstElement { get; set; }
    public Element LastElement { get; set; }
    
    public LinkedList()
    {
        FirstElement = null;
        LastElement = null;
    }

    public void InsertFirst(Object obj)
    {
        Element newElement = new Element(obj);
        
        if (FirstElement == null)
        {
            FirstElement = newElement;
            LastElement = newElement;
        }
        else
        {
            newElement.SetNext(FirstElement);
            FirstElement = newElement;
        }
    }

    public void InsertLast(Object obj)
    {
        Element newElement = new Element(obj);
        
        if (LastElement == null)
        {
            LastElement = newElement;
        }
        else
        {
            LastElement.SetNext(newElement);
            LastElement = newElement;
        }
    }

    public void Print()
    {
        bool bol = true;
        Element here = FirstElement;
        while (bol)
        {
            if (here != null)
            {
                Console.WriteLine($"{here.GetObject()}");
                here = here.GetNext();
            }
            else
            {
                bol = false;
            }
        }
    }

    public bool IsEmpty()
    {
        return FirstElement == null;
    }

    public void Remove(Object obj)
    {
        Element here = FirstElement;
        Element before = null;

        while (here != null)
        {
            if (here.GetObject().Equals(obj))
            {
                if (before==null)
                {
                    if (FirstElement == null)
                    {
                        LastElement = null;
                    }
                }
                else
                {
                    before.SetNext(here.GetNext());
                    if (here.GetNext()==null)
                    {
                        LastElement = before;
                    }
                }
                break;
            }
            before = here;
            here = here.GetNext();
        }
    }

    public Object GetFirstObject()
    {
        if (FirstElement != null)
        {
            return FirstElement.GetObject();
        }
        return null;
    }

    public Object GetLastObject()
    {
        if (LastElement != null)
        {
            return LastElement.GetObject();
        }
        return null;
    }

    public Object GetObjectAtPosition(int i)
    {
        Element here = FirstElement;
        int count = 0;
        int len = 0;
        if (i < 0)
        {
            throw new Exception("IndexOutOfBounds");
        }
        while (here != null)
        {
            if (count == i)
            {
                return here.GetObject();
            }

            count++;
            len++;
            here = here.GetNext();
        }
        if (i > len)
        {
            throw new Exception("IndexOutOfBounds");
        }
        return null;
    }
}