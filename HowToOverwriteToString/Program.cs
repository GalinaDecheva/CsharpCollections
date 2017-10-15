using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main(string[] args)
    {
        Human h = new Human("Pesho",12);
        Console.WriteLine(h);
    }

}

class Human
{
    public string Name { get; set;}
    public int Age { get; set; }    
    
    public Human(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public override string ToString()
    {
        return this.Name + " " + this.Age;
    }
}


