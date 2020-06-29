using System;



namespace Practice

{
    class Student
    {
        private int _id;
        private string _Name;
        private int _PassMarks = 35;

        public void SetId(int Id)
        {
            if(Id <= 0)
            {
                throw new Exception("Id can't be negative or zero");
            }
            this._id = Id;
        }
        public int GetId()
        {
            return this._id;
        }

        public void SetName(string Name)
        {
            if(string.IsNullOrEmpty(Name))  // we can also use if(Name.Equals(null) || Name.Equals(""))
            {
                throw new Exception("The name cannot be Empty");
            }
            this._Name = Name;
        }
        public string GetName()
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

        public int GetPassMarks()
        {
            return this._PassMarks;
        }

    }

    
    class Program

    {
        
        public static void Main(string[] args)

        {
            Student st = new Student();
            st.SetId(20);
            Console.WriteLine(st.GetId());
            st.SetName("Hello");
            Console.WriteLine(st.GetName());
            Console.WriteLine(st.GetPassMarks());
            Console.ReadLine();

        }

    }

}
