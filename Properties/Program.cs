using System;

namespace Properties
{
    class Person
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person myObj = new Person();
            myObj.Name = "Ram";
            Console.WriteLine(myObj.Name);
        }
    }
}
