var student = new Student("Mustafo","Rohi-Nav");
student.AddCourceGrade(".Net",5);
student.AddCourceGrade("JS",4);
student.AddCourceGrade("C#",3);
student.AddCourceGrade("C++",5);
System.Console.WriteLine(student.GetAverageGrade());
System.Console.WriteLine(student.ToString());
foreach (var item in student.GetGrade())
{
    System.Console.WriteLine(item);
}
foreach (var item in student.GetCource())
{
    System.Console.WriteLine(item);
}


var teacher = new Teacher("Barotov","Dushanbe");
System.Console.WriteLine( teacher.AddCource("C#"));
System.Console.WriteLine(teacher.AddCource("JS"));
System.Console.WriteLine( teacher.RemoveCource("JS"));
System.Console.WriteLine( teacher.AddCource("C#"));

foreach (var item in teacher.GetCource())
{
    System.Console.WriteLine(item);
}

System.Console.WriteLine(teacher.ToString());