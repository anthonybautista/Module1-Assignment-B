using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;

namespace Module1_Assignment_B
{
    internal class Program
    {
        private static FileInput _fileInput = null;
        private static FileOutput _fileOutput = null;
        private static string _fileName = "animals.txt";
        
        public static void Main(string[] args)
        {
            List<ITalkable> zoo = new List<ITalkable>();

            bool addMore = true;

            while (addMore)
            {
                try
                {
                    AnimalBuilder animal = new AnimalBuilder();
                    if (animal != null)
                    {
                        zoo.Add(animal.GetAnimal());
                    }

                    Console.WriteLine("Add another animal? 1: Yes, 2: No");
                    int selection = Int32.Parse(Console.ReadLine());

                    switch (selection)
                    {
                        case 1:
                            addMore = true;
                            break;
                        case 2:
                            addMore = false;
                            break;
                        default:
                            throw new Exception("Invalid selection: " + selection);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid selection: " + e.Message);
                    Console.WriteLine("Continuing program execution...");
                    addMore = false;
                }
            }

            try
            {
                foreach (ITalkable thing in zoo)
                {
                    PrintOut(thing);
                }
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("Error: Zoo failed to build.");
                Console.WriteLine("Continuing program execution...");
            }
            
            _fileOutput.FileClose();

            _fileInput = new FileInput(_fileName);
            _fileInput.FileRead();
            _fileInput.FileClose();

            FileInput inData = new FileInput("animals.txt");
            string line = inData.FileReadLine();
            while (line != null)
            {
                Console.WriteLine(line);
                line = inData.FileReadLine();
            }
            inData.FileClose();
        }
        
        public static void PrintOut(ITalkable p)
        {
            if (_fileOutput == null)
            {
                _fileOutput = new FileOutput(Path.Combine(Environment.CurrentDirectory, _fileName));
            }
            Console.WriteLine(p.GetName() + " says=" + p.Talk());
            _fileOutput.FileWrite(p.GetName() + " | " + p.Talk());
        }
    }
}