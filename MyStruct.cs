namespace C_Fundamentals
{
    //MyStruct.cs-Demonstrates struct concepts in C#
    public struct MyStruct
    {
        public string Name;
        public int Age;

        public MyStruct(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"MyStruct - Name: {Name}, Age: {Age}");
        }

        public void UpdateAge(int newAge)
        {
            Age = newAge;
        }
    }
    //Example of a struct implementing an interface
    public struct AgeUpdatableStruct
    {
        public int Age;

        public AgeUpdatableStruct(int age)
        {
            Age = age;
        }

        public void UpdateAge(int newAge)
        {
            Age = newAge;
            Console.WriteLine($"AgeUpdatableStruct - Updated Age: {Age}");
        }
    }
}
