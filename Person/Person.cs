using System;

class Person
{
    private string name;
    private int age;
    private string email;

    public Person(string name, int age, string email = null)
    {
        this.Name = name;
        this.Age = age;
        this.Email = email;
    }
    public Person(string name, int age)
        : this(name, age, null)
    {
    }


    public string Name
    {
        get { return this.name; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("The name cannot be empty");
            }
            this.name = value;
        }
    }

    public int Age
    {
        get { return this.age; }
        set
        {
            if (value < 1 || value > 100)
            {
                throw new ArgumentOutOfRangeException("invalid age");
            }

            this.age = value;
        }
    }

    public string Email
    {
        get { return this.email; }
        set
        {
            if ((!string.IsNullOrEmpty(value) && !value.Contains("@")) || (string.IsNullOrEmpty(value) && value != null))
            {
                throw new ArgumentException("The email cannot be empty string and must contain @");
            }

            this.email = value;
        }
    }
    public override string ToString()
    {
        string result = "Name: " + this.Name + "\nAge: " + this.Age;
        if (this.Email != null)
        {
            result += "\nEmail: " + this.Email;
        }
        return result;
    }


    static void Main(string[] args)
    {
        Person a = new Person("Jon Doe", 14, "John.Doe@com.com");
        Console.WriteLine(a);

    }
}

