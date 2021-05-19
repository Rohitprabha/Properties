using System;

namespace WriteOnly_Property
{
    class Person
    {
        private string name;
        public string Name
        {
            set { name = value; }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Person myObj = new Person();
            myObj.Name = "Ram";
            //Console.WriteLine(myObj.Name);  //error 'Person.Name' cannot be used in this context because it lacks the get accessor
        }
    }
}
