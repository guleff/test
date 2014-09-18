using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Person
    {

        private string email;

        
        public string Email
        {
            get { return email; }
            set {
                if (!String.IsNullOrEmpty(this.email))
                {
                    throw new ArgumentException("nqma email");
                }
                
                
                email = value; }
        }

        public Person(int age,string name,string email=null){
            this.Age = age;
            this.Name = name;
            this.Email = email;
            
    }

        public string Name { get; set; }
        public int Age { get; set; }

        static void Main(string[] args)
        {

            Person test = new Person(2,"fdsfsdf","jfksdjfk@jfkdsjf.com");
            Console.WriteLine(test.Email);
            

        }
    }
}
