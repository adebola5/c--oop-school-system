class Student : Person
{

    public int StudentId { get; set; }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Student ID: {StudentId}");
    }
}