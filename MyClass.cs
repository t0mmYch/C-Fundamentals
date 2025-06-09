//MyClass.cs - Demonstrates class concepts in C#
namespace C_Fundamentals
{
    //This is a basic class with two properties
    public class MyClass
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public MyClass(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"MyClass - Name: {Name}, Age: {Age}");
        }

        public void UpdateAge(int newAge)
        {
            Age = newAge;
        }
    }
    //Derived class to show inheritance
    public class DerivedClass : MyClass
    {
        public string JobTitle { get; set; }

        public DerivedClass(string name, int age, string jobTitle) : base(name, age)
        {
            JobTitle = jobTitle;
        }
     //Overriding The DisplayInfo method to include additional information
        public new void DisplayInfo()
        {
            Console.WriteLine($"DerivedClass - Name: {Name}, Age: {Age}, Job Title: {JobTitle}");
        }
    }
}
