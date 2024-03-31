using System;
using System.Reflection.Metadata.Ecma335;

namespace OOPM
{

public class Student

{
private Class _class;

public Class Class
{
get
{
    return this._class;
}
set
{
     this._class = value;
}
}   
public string name;
public DateTime BirthDate;
}
}