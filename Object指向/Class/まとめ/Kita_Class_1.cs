using System;

namespace Kita_Class_1_1
{
    class Kita_Class_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("犬種");
            Dog a = new Dog("チワワ");
            Dog b = new Dog("ダックスフント");
            
            a.Name="John";
            a.Age = 2;
            a.ShowProfile();

            b.Name = "Tom";
            b.Age = 3;
            b.ShowProfile();
        }
    }
    class Dog
    {
        private string name;
        private int age;
        private string sort;
        public Dog(string sort)
        {
            this.sort = sort;
        }
        public string Name//()はいらない
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public void ShowProfile()
        {
            Console.WriteLine(sort);
            Console.WriteLine(Name);
            Console.WriteLine(Age);
            Console.WriteLine();
        }
        
    }
}
