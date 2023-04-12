using System;

namespace Module1_Assignment_B
{
    public class AnimalBuilder
    {
        private readonly ITalkable _animal;

        public AnimalBuilder()
        {
            try
            {
                int animalType = GetSelection();

                switch (animalType)
                {
                    case 1:
                        _animal = BuildCat();
                        break;
                    case 2:
                        _animal = BuildDog();
                        break;
                    case 3:
                        _animal = BuildTeacher();
                        break;
                    default:
                        throw new Exception("Invalid selection." + animalType);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception AnimalBuilder: " + e.Message);
            }
        }

        public Cat BuildCat()
        {
            try
            {
                Console.WriteLine("Building a Cat!");
                Console.WriteLine("Enter Number of mice killed: ");
                int mousesKilled = Int32.Parse(Console.ReadLine());
                
                Console.WriteLine("Mice Killed: " + mousesKilled + "!");
                Console.WriteLine("Enter name: ");
                string name = Console.ReadLine();

                return new Cat(mousesKilled, name);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception BuildCat: " + e.Message);
                return null;
            }
        }
        
        public Dog BuildDog()
        {
            try
            {
                Console.WriteLine("Building a Dog!");
                Console.WriteLine("Is the dog friendly? 1: Yes, 2: No: ");
                bool friendly;

                int selection = Int32.Parse(Console.ReadLine());

                switch (selection)
                {
                    case 1:
                        friendly = true;
                        break;
                    case 2:
                        friendly = false;
                        break;
                    default:
                        throw new Exception("Invalid selection: " + selection);
                }
                
                Console.WriteLine(friendly ? "The dog is friendly!" : "The dog is not friendly!");
                Console.WriteLine("Enter name: ");
                string name = Console.ReadLine();

                return new Dog(friendly, name);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception BuildDog: " + e.Message);
                return null;
            }
        }
        
        public Teacher BuildTeacher()
        {
            try
            {
                Console.WriteLine("Building a Teacher!");
                Console.WriteLine("Enter teacher age: ");
                int age = Int32.Parse(Console.ReadLine());
                
                Console.WriteLine("Teacher Age: " + age + "!");
                Console.WriteLine("Enter name: ");
                string name = Console.ReadLine();

                return new Teacher(age, name);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception BuildTeacher: " + e.Message);
                return null;
            }
        }

        public ITalkable GetAnimal()
        {
            return _animal;
        }

        public int GetSelection()
        {
            Console.WriteLine("What type of animal would you like to create? (1: Cat, 2: Dog, 3: Teacher):");
            return Int32.Parse(Console.ReadLine());
        }
    }
}