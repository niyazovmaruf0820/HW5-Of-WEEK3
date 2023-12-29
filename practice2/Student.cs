
class Student : Person
{
    public void Study()
    {
        Console.WriteLine($"{Name} is studing");
    }
    public Student(string name) : base(name) { }

}