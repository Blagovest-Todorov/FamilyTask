using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //string name = "Pesho";
            //int age = 24;

            //Person pesho = new Person("Pesho", 24);
            // Console.WriteLine($"{pesho.Name} - {pesho.Age}");
            //var noName = new Person();
            //Console.WriteLine($"NoNameGuy{noName.Name} - {noName.Age}");

            //var george = new Person(24);
            //Console.WriteLine($"GeorgeYears: {george.Name} - {george.Age}");

            //var ivan = new Person("Ivan", 27);
            //Console.WriteLine($"Ivan: {ivan.Name} - {ivan.Age}");

            int n = int.Parse(Console.ReadLine());
            var family = new Family();

            for (int i = 0; i < n; i++)
            {
                var cmdArgs = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = cmdArgs[0];
                int age = int.Parse(cmdArgs[1]);
                var person = new Person(name, age);
                family.AddMember(person);
            }

            HashSet<Person> filteredPersonAbove30 = family.GetPeopleAbove30();
            Console.WriteLine(string.Join(Environment.NewLine, filteredPersonAbove30));
        }
    }
}
