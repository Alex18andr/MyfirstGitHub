using System;
namespace intro_to_vscode
{
    public class Human
    {
        public int Age {get; set;}
        public string Name {get; set;}
        public string Sex {get; set;}
        public double Again {get; set;}


        public void HumanSay()
        {
            Console.WriteLine("Здарова, бандиты!");
        }

        public Human()
        {

        }
        public Human(string name)
        {
            Name = name;
        }

        public Human(string name, int age) : this(name)
        {
            Age = age;
        }

        public Human(string name, int age, string sex) : this (name, age)
        {
            Sex = sex;
        }
    }
}