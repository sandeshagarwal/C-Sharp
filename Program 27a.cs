using System;



//namespace Practice

//{
    class Student
    {
        private int _id;
        private string _Name;
        private int _PassMarks = 35;

        public int Id // Property
        {
        set //set accessor
        {

            if (value <= 0) // value is a inbuilt keyword for value passed in Id,Name,etc.
            {
                throw new Exception("Id can't be negative or zero");
            }
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
            if (string.IsNullOrEmpty(value))  // we can also use if(Name.Equals(null) || Name.Equals(""))
            {
                throw new Exception("The name cannot be Empty");
            }
            this._Name = value;
        }
        get
        {
            // We can use a Ternary Operator here for the if else part
            return string.IsNullOrEmpty(this._Name) ? ("No Name") : this._Name;
            //if(string.IsNullOrEmpty(this._Name))
            //{
            //    return ("No Name");
            //}
            //else
            //{
            //    return this._Name;
            //}
        }
        }
        

        public int PassMarks
        {
        get
        {
            return this._PassMarks;
        }
        }

    }

    
    class Program

    {
        
        public static void Main(string[] args)

        {
            Student st = new Student();
            st.Id = 120;
            Console.WriteLine(st.Id);
            st.Name = "Hello";
            Console.WriteLine(st.Name);
            Console.WriteLine(st.PassMarks);
            Console.ReadLine();

        }

    }

//}
