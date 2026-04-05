namespace InheritanceProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Test in the main class
            //create a list of all the people
            List<Person> people = new List<Person>();

            //add user input here to determinre if the program should continue or stop
            Console.WriteLine("Enter 1 to continue or any other number to stop: ");
            String num = Console.ReadLine();
            int number = Convert.ToInt32(num);

            while (number ==1)
            {
                //give the user options on what they want to do 
                Console.WriteLine("\n1. Add Student");
                Console.WriteLine("2. Add Teacher");
                Console.WriteLine("3. View All");
                Console.WriteLine("4. Search");
                Console.WriteLine("5. Exit");

                Console.Write("Choose option: ");
                string choice = Console.ReadLine();

                //now we want to call a bunch of methods based on the user's input we could also use your method but then it would not be neat
                if (choice == "1")
                {
                    //call the add studdent methofd
                    AddStudent(people);
                }
                else if (choice == "2")
                {
                    AddTeacher(people);
                }
                else if (choice == "3")
                {
                   DisplayPeople(people);
                }
                else if (choice == "4")
                {
                    SearchPerson(people);
                }
                else if (choice == "5")
                {
                    break;//break because we are exiting
                }
                else
                {
                    Console.WriteLine("Invalid choice");
                }
            }

        }
        //create the AddStudent class after the main method 
        //make it static so it can be accessed anywhere in the program
        static void AddStudent(List<Person> people)
        {
            //ask the user for inputs, then use the inputs to create a student object and add it to the person list
            Console.Write("Enter name: ");
            string name = Console.ReadLine();

            Console.Write("Enter age: ");
            int age;
            while (!int.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine("Invalid input. Enter a number:");
            }

            Console.Write("Enter student ID: ");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Invalid input. Enter a number:");
            }

            //create a student object
            Student s = new Student
            {
                Name = name,
                Age = age,
                StudentId = id
            };

            //add the student to the list for people
            people.Add(s);
            Console.WriteLine("Student added!");
        }

        //create a display method to display the info of those in the list
        static void DisplayPeople(List<Person> people)
        {
            foreach (Person p in people)
            {
                //call the existing display method from the person class
                p.DisplayInfo();
            }
        }

        static void AddTeacher(List<Person> people)
        {
            //ask the user for the information to build the teacher object
            Console.Write("Enter name: ");
            string name = Console.ReadLine();

            Console.Write("Enter age: ");
            int age;
            while (!int.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine("Invalid input. Enter a number:");
            }

            Console.Write("Enter student ID: ");
            string subject = Console.ReadLine();

            //create the teacher object
            Teacher teacher = new Teacher();
            teacher.Name = name;
            teacher.Age = age;
            teacher.Subject = subject;

            //add it to the list of people
            people.Add(teacher);
            Console.WriteLine("Teacher added!");//confirm adding the teacher to list
        }

        static void SearchPerson(List<Person> people)
        {
            Console.Write("Enter name to search: ");
            string searchName = Console.ReadLine().ToLower();

            bool found = false;

            foreach (Person p in people)
            {
                if (p.Name.ToLower() == searchName)
                {
                    p.DisplayInfo();
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("No person found with that name.");
            }
        }
    }
}

