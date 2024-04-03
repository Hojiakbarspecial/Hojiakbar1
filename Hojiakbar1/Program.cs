

Console.WriteLine("To get the list of Students write 1\nTo add a student write 2");


string userInput = Console.ReadLine()!;

var context = new Hojiakbar1.Context();

while (userInput != "1" && userInput != "2")
{
    Console.WriteLine("Please write 1 or 2");
    userInput = Console.ReadLine()!;
}

if (userInput == "1")
{
    var AllStudents = context.Students!.ToList();
    Console.WriteLine(""); // shunchaki joy tashlash uchun
    foreach (var item in AllStudents)
    {
        Console.WriteLine($"{item.StudentID} | {item.StudentName} | {item.StudentAge} | {item.StudentNationality}");
    }
}
else
{
    Console.WriteLine("Please enter student's name | age | nationality (seperately) ");
    string name = Console.ReadLine()!;
    int age = Convert.ToInt32(Console.ReadLine());
    string nationality = Console.ReadLine()!;

    var student = new Hojiakbar1.Student
    {
        StudentName = name,
        StudentAge = age,
        StudentNationality = nationality
    };

    context.Students.Add(student);

    context.SaveChanges();
}