using System;

namespace Readonly_Property
{
    class Person
    {
        private string name;
        public string Name
        {
            get { return name; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person myObj = new Person();
            //myObj.Name = "Ram";                   //error 'Person.Name' cannot be assigned to -- it is read only
            Console.WriteLine(myObj.Name);
        }
    }
}
