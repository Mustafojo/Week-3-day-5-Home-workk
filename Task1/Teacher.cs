public class Teacher : Person
{
    int numCurses;
    List<string> courses = new List<string>();
    public Teacher(string name, string address) : base(name, address) { }
    public string toString()
    {
        return "TiString";
    }
    public List<string> GetCource()
    {
        return courses;
    }
    public bool AddCource(string cource)
    {
        var a = courses.Contains(cource);
        if (a == true)
        {
            return true;
        }
        else
        {
            courses.Add(cource);
            return false;
        }
    }
    public bool RemoveCource(string cource)
    {
        var a = courses.Contains(cource);
        if (a == true)
        {
            courses.Remove(cource);
            return true;
        }
        else
        {
            return false;
        }
    }
    public string ToString()
    {
        return $"Name: {GetName()} Address: {GetAddress()}";
    }

}