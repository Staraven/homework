using System;

namespace OOPM

{
public class Class
{
    public string Code;
private List<Student> _students = new List<Student>();
public Student[] Students
{
        get
        {
            return this.Students.ToArray();
        }
}
public Class(string code)
{
this.Code= code;
}
}

private void Validate(string Code)
{
    if (string.IsNullOrWhiteSpace(code))
    {
        throw new ApplicationException("Fill the Code ");
    }
    
}
}



