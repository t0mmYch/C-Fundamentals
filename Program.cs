///All using statements go at the very top
using System;
using Newtonsoft.Json;

namespace C_Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Example usage of Newtonsoft.Json
            string json = JsonConvert.SerializeObject(new { Name = "Tommy", Role = "Tester" });
            Console.WriteLine(json); //Output: {"Name":"Tommy","Role":"Tester"}

            ///CLASS demonstration
            Console.WriteLine("\n=== Class Demonstration ===");
            MyClass myClass = new MyClass("John", 25);
            myClass.DisplayInfo();
            myClass.UpdateAge(26);
            myClass.DisplayInfo();

            ///INHERITANCE with class
            DerivedClass derivedClass = new DerivedClass("Alice", 30, "Software Engineer");
            derivedClass.DisplayInfo();
            derivedClass.UpdateAge(31);

            ///RECORD demonstration
            Console.WriteLine("\n=== Record Demonstration ===");
            MyRecord myRecord = new MyRecord("Bob", 35);
            myRecord.DisplayInfo();

            ///INHERITANCE with record
            DerivedRecord derivedRecord = new DerivedRecord("Carol", 40, "Data Scientist");
            derivedRecord.DisplayInfo();

            ///STRUCT demonstration
            Console.WriteLine("\n=== Struct Demonstration ===");
            MyStruct myStruct = new MyStruct("Dave", 45);
            myStruct.DisplayInfo();
            myStruct.UpdateAge(46); //Updating value inside struct
            myStruct.DisplayInfo();

            ///STRUCT implementing behavior
            AgeUpdatableStruct ageStruct = new AgeUpdatableStruct(50);
            ageStruct.UpdateAge(51);

            ///VALUE vs REFERENCE type
            Console.WriteLine("\n=== Value Type vs Reference Type ===");
            MyStruct struct1 = new MyStruct("Struct1", 1);
            MyStruct struct2 = struct1;
            struct2.Name = "Struct2"; //struct1 is not changed because structs are copied by value
            Console.WriteLine($"struct1.Name: {struct1.Name}");

            MyClass class1 = new MyClass("Class1", 1);
            MyClass class2 = class1;
            class2.Name = "Class2"; //class1 is changed too because it's reference type
            Console.WriteLine($"class1.Name: {class1.Name}");

            ///RECORDS: Value-based equality
            Console.WriteLine("\n=== Record Value-based Equality ===");
            MyRecord record1 = new MyRecord("Record1", 1);
            MyRecord record2 = new MyRecord("Record1", 1);
            Console.WriteLine($"record1 == record2: {record1 == record2}"); //True because records use value-based equality
        }
    }
}
    

