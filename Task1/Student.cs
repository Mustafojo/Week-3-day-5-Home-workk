public class Student : Person
{
    int numCurses;
    List<string> courses = new List<string>();
    List<int> grades = new List<int>();
    public Student(string name,string address):base(name,address){}
    public string toString()
    {
        return "string";
    }
     public List<string> GetCource()
    {
        return courses;
    }
     public List<int> GetGrade()
    {
        return grades;
    }
    public void AddCourceGrade(string cource,int grade)
    {
        courses.Add(cource);
        grades.Add(grade);
    }
    public void PrintGrades()
    {
        System.Console.WriteLine(grades);
    }
    public double GetAverageGrade()
    {
        return grades.Sum() / grades.Count();
    }
    public string ToString()
    {
        return $"Name: {GetName()} Address: {GetAddress()}";
    }
} 