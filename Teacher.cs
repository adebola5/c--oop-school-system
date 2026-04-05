class Teacher : Person
{
    public string Subject { get; set; }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Subject: {Subject}");
    }
}