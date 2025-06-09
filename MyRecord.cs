namespace C_Fundamentals
{
    //MyRecord.cs-Demonstrates record concepts in C#
    public record MyRecord(string Name, int Age)
    {
        public void DisplayInfo()
        {
            Console.WriteLine($"MyRecord - Name: {Name}, Age: {Age}");
        }
    }
    //Records can inherit from other records
    public record DerivedRecord(string Name, int Age, string Role) : MyRecord(Name, Age)
    {
        public void DisplayInfo()
        {
            Console.WriteLine($"DerivedRecord - Name: {Name}, Age: {Age}, Role: {Role}");
        }
    }
}
