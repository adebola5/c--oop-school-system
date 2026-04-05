class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age {Age}");
    }
}