using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp14
{
    class Program
    {
        static void Main()
        {
           

            Cat cat1 = new Cat() { Alias = "Iris" };
            cat1.ShowInfo();
            Dog dog1 = new Dog();
            dog1.ShowInfo();
            Console.ReadKey();
        }
    }

    public abstract class Animal
    {
        public string Genus { get; set; }
        public Animal() 
            {
                Genus = "Name";
            }
        public abstract void Say();
        public void ShowInfo()
        {
            Console.Write("Genus {0}, ", Genus);
            Say();
        }
    }

    public class Cat : Animal
    {
        public string Alias { get; set; }
        public Cat()
        {
            Genus = "Cat";
            Alias = "NickNameCat unknown";
        }
        public override void Say()
        {
            
            Console.WriteLine("Alias {0} say: meow ", Alias);
        }
    }

    public class Dog : Animal
    {
        public string Alias { get; set; }
        public Dog()
        {
            Genus = "Dog";
            Alias = "NickNameDog unknown";
        }
        public override void Say()
        {

            Console.WriteLine("Alias {0} say: woof ", Alias);
        }
    }

}
