using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo.ClassesAndInterfaces
{
    public interface IAnimal
    {
        string Name { get; set; }
       
    }

    public interface IPredator : IAnimal
    {
        int AttackSpeed { get; set; }
        string Attack(IPray pray);

    }

    public interface IPray : IAnimal
    {
        int FleeSpeed { get; set; }
    }

   
     class Fish : IPredator, IPray
    {
       
        public string Name { get; set; }
        public int AttackSpeed { get; set; }
        public int FleeSpeed { get; set; }


        public string Attack(IPray pray)
        {


            return AttackSpeed > pray.FleeSpeed ? $"{Name} catches {pray.Name}" : $"{pray.Name} escapes from {Name}";
        }


        public Fish(string name, int fleeSpeed)
        {
            Name = name;
            FleeSpeed = fleeSpeed;
    
        }

        public Fish( int attackSpeed, string name)
        {
            Name = name;
            AttackSpeed = attackSpeed;

        }

        public Fish()
        {
        }
    }

    //////////////////////////////////////////////////////////////////

    class Cat : IPredator, IPray
    {
        public string Name { get; set; }
        public int AttackSpeed { get; set; }
        public int FleeSpeed { get; set; }

        public string Attack(IPray pray)
        {
            return AttackSpeed > pray.FleeSpeed ? $"{Name} catches {pray.Name}" : $"{pray.Name} escapes from {Name}";
        }

        public Cat(string name, int fleeSpeed)
        {
            Name = name;
            FleeSpeed = fleeSpeed;
        }

        public Cat(int attackSpeed, string name)
        {
            Name = name;
            AttackSpeed = attackSpeed;
        }

        public Cat()
        {

        }

    }

    class Gazella : IPray
    {
        public string Name { get; set; }
        public int FleeSpeed { get; set; }

        public Gazella(string name, int fleeSpeed)
        {
            Name = name;
            FleeSpeed = fleeSpeed;
        }

        public Gazella()
        {
            
        }
    }

    

}
