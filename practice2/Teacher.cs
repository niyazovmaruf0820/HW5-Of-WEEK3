
class Teacher : Person
{
    public void Explain()
    {
        Console.WriteLine($"{Name} is explaning");
    }
    public Teacher(string name) : base(name) { }

}