// See https://aka.ms/new-console-template for more information

class CustomCollection<T>
{
    private List<T> _items = new List<T>();
    private Random _random = new Random();
    
    public void Add(T item)
    {
        if (_random.NextSingle() > 0.5) {
            _items.Add(item);
        } else {
            _items.Insert(0, item);
        }
    }

    public T Get(int index)
    {
        if (index < 0 || index >= _items.Count) {
            throw new ArgumentOutOfRangeException("Out of bounds in Get method");
        }
        return _items[_random.Next(index+1)];
    }

    public bool IsEmpty()
    {
        return _items.Count == 0;
    }
    
    public int Size()
    {
        return _items.Count;
    }
}

internal class Program
{
    delegate bool IsLeapYear(int year);
    private static void Main(string[] args)
    {
        IsLeapYear isLeapYearM = (year) => year % 100 == 0 ? year % 400 == 0 : year % 4 == 0;
        
        Console.WriteLine(isLeapYearM(2018)); // false
        Console.WriteLine(isLeapYearM(2008)); // true
        Console.WriteLine(isLeapYearM(1900)); // false
        Console.WriteLine(isLeapYearM(2000)); // true
        
        var col = new CustomCollection<int>();
        col.Add(1);
        col.Add(2);
        col.Add(3);
        col.Add(4);

        for (int i = 0; i < col.Size(); i++)
        {
            Console.WriteLine(col.Get(i));
        }
        
        Console.WriteLine(col.IsEmpty());
    }
}