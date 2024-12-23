#region Q1
/* using System;

 enum WeekDays
{
    Saturday,
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday
    
}

class Program
{
    static void Main()
    {
        /* foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
        {
            Console.WriteLine(day);
        } 
    }
} */
#endregion
#region Q2
/* using System;

struct Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program2
{
    static void Main()
    {
        Person[] people = new Person[3];

        people[0] = new Person { Name = "Fares", Age = 22 };
        people[1] = new Person { Name = "Hany", Age = 30 };
        people[2] = new Person { Name = "Ramadan", Age = 35 };

        foreach (var person in people)
        {
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
        }
    }
} */
#endregion
#region Q3
/* using System;

enum Season
{
    Spring,
    Summer,
    Autumn,
    Winter
}

class Program3
{
    static void Main()
    {
        Console.WriteLine("Enter a season (Spring, Summer, Autumn, Winter):");
        string input = Console.ReadLine();

        if (Enum.TryParse(input, true, out Season season))
        {
            switch (season)
            {
                case Season.Spring:
                    Console.WriteLine("March to May");
                    break;
                case Season.Summer:
                    Console.WriteLine("June to August");
                    break;
                case Season.Autumn:
                    Console.WriteLine("September to November");
                    break;
                case Season.Winter:
                    Console.WriteLine("December to February");
                    break;
                default:
                    Console.WriteLine("Invalid season");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }
} */
#endregion
#region Q4
/* using System;

[Flags]
enum Permissions
{
    None = 0,
    Read = 1,
    Write = 2,
    Delete = 4,
    Execute = 8
}

class Program4
{
    static void Main()
    {
        Permissions userPermissions = Permissions.Read | Permissions.Write;

        Console.WriteLine("Current Permissions: " + userPermissions);

        userPermissions |= Permissions.Execute;
        Console.WriteLine("After Adding Execute: " + userPermissions);

        userPermissions &= ~Permissions.Write;
        Console.WriteLine("After Removing Write: " + userPermissions);

        if ((userPermissions & Permissions.Read) == Permissions.Read)
        {
            Console.WriteLine("Read permission exists");
        }
        else
        {
            Console.WriteLine("Read permission does not exist");
        }
    }
} */
#endregion
#region Q5
/* using System;

enum Colors
{
    Red,
    Green,
    Blue
}

class Program5
{
    static void Main()
    {
        Console.WriteLine("Enter a color (Red, Green, Blue):");
        string input = Console.ReadLine();

        if (Enum.TryParse(input, true, out Colors color))
        {
            Console.WriteLine($"{color} is a primary color.");
        }
        else
        {
            Console.WriteLine("Not a primary color.");
        }
    }
}
*/
#endregion
#region Q6
/* using System;

struct Point
{
    public double X { get; set; }
    public double Y { get; set; }
}

class Program6
{
    static void Main()
    {
        Point point1 = new Point();
        Point point2 = new Point();

        Console.WriteLine("Enter X and Y for Point 1:");
        point1.X = double.Parse(Console.ReadLine());
        point1.Y = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter X and Y for Point 2:");
        point2.X = double.Parse(Console.ReadLine());
        point2.Y = double.Parse(Console.ReadLine());

        double distance = Math.Sqrt(Math.Pow(point2.X - point1.X, 2) + Math.Pow(point2.Y - point1.Y, 2));
        Console.WriteLine($"Distance: {distance}");
    }
} */
#endregion
#region Q7
/* using System;

struct Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program7
{
    static void Main()
    {
        Person[] people = new Person[3];

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Enter Name and Age for Person {i + 1}:");
            people[i].Name = Console.ReadLine();
            people[i].Age = int.Parse(Console.ReadLine());
        }

        Person oldest = people[0];
        foreach (var person in people)
        {
            if (person.Age > oldest.Age)
            {
                oldest = person;
            }
        }

        Console.WriteLine($"Oldest Person: {oldest.Name}, Age: {oldest.Age}");
    }
} */
#endregion