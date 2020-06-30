using System;



//namespace Practice

//{
struct Customer
{
    private int _id;
    private string _name;


    public int Id // Property
    {
        set //set accessor
        {
            this._id = value;
        }
        get
        {
            return this._id;
        }
    }
    public string Name
    {
        set
        {

            this._name = value;
        }
        get
        {
            return this._name;
        }
    }
    public Customer(int Id, string Name)
    {
        _id = Id;
        _name = Name;
    }
    public void PrintDetails()
    {
        Console.WriteLine("The Name = {0} and Id = {1}", this._name, _id);
    }

}
    
    class Program

    {

        public static void Main(string[] args)

        {
            Customer ct = new Customer(120, "John");
            ct.PrintDetails();
            // We can also initialize the Id by calling the Id property

            Customer c2 = new Customer(); // calling the default constructor
            c2.Id = 121;
            c2.Name = "Harvey";
            c2.PrintDetails();

            // we can also Initialize the objects using the object Initializer
            Customer c3 = new Customer
            {
                Id = 103,
            Name = "Mark"
           };
            c3.PrintDetails();
        Console.ReadLine();

        }

    }

//}
