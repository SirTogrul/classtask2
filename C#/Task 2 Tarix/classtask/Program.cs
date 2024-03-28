using System.Diagnostics;
using System.Xml.Linq;
using static System.Reflection.Metadata.BlobBuilder;

namespace classtask
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Book book = new Book("book",15.50,2,"fantasy",1);
            book.showInfo();
        }
    }
}class Product
{
    private double _price;
    private int _count;
   public int No { get; }
    public string Name { get; }

    public Product(double price, int count, int no, string name)
    {
        _price = price;
        _count = count;
        No = no;
        Name = name;
       
    }

        public double Price
    {
        get
        {
            return _price;
        }
        set
        {
            if (value > 0)
            {
                _price = value;
            }
            else
            {
                Console.WriteLine("qiymet daxil edin!");
            }
            
        }
      
    } 
    public int Count
    {
        get
        {
            return _count;
        }
        set
        {
         if (value > 0)
         {
                _count = value;
         }
            else
            {
                Console.WriteLine("kitab sayi daxil edin");
            }
        }
    }
   

}
class Book:Product
{
    string Genre;

    public Book(string Name, double Price, int Count, string Genre, int No): base(Price, Count, No, Name)
    {
        this.Genre = Genre;
    }
    public void showInfo()
    {
        Console.WriteLine("Name: {0}", Name);
        Console.WriteLine("No: {0}", No);
        Console.WriteLine("Price: {0}", Price);
        Console.WriteLine("Count: {0}", Count);
        Console.WriteLine("Genre: {0}", Genre);
    }
}
