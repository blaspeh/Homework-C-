using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfacesDemo.ClassesAndInterfaces;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            IPredator shark = new Fish() { AttackSpeed = 30, Name = "Shark" };
            IPray pinguin = new Fish() { FleeSpeed = 25, Name = "Pinguin" };
            IPray herring = new Fish() { FleeSpeed = 35, Name = "Herring" };
            IPray pastrmka = new Fish() { FleeSpeed = 50, Name = "Pastrmka" };
            IPray pastrmka1 = new Fish() { FleeSpeed = 10, Name = "Pastrmka1" };


            Console.WriteLine("-------------------------------------");
            Console.WriteLine(shark.Attack(pinguin));
            Console.WriteLine(shark.Attack(herring));
            Console.WriteLine(shark.Attack(pastrmka));
            Console.WriteLine(shark.Attack(pastrmka1));
            Console.WriteLine("-------------------------------------");


            IPredator gepard = new Cat() { AttackSpeed = 60, Name = "Gepard" };
            IPray gazella = new Gazella() { FleeSpeed = 55, Name = "Gazella" };

            Console.WriteLine(gepard.Attack(gazella));
            Console.WriteLine("-------------------------------------");

            IPredator lion = new Cat { AttackSpeed = 35, Name = "Lion" };
            Console.WriteLine(lion.Attack(gazella));
            Console.WriteLine("-------------------------------------");

            Console.ReadLine();

        }
    }
}
