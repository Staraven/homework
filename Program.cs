using System;
using System.Security.Permissions;

namespace OOPM
{

public class Program
{
        public static void Main(string[] args)
        {


          Student  A = new Student();

           A.name="Okyay";
           A.Class.Code="11A";
           A.BirthDate= new DateTime(2000-9-27);
            

           Student B = new Student();

           B.name = "Levo";
           B.Class.Code="12A";
           B.BirthDate = new DateTime(1994-7-26);

           Class class1 = new Class("11A", new Student[] {A});


               
                Console.WriteLine($"Student A Name: {A.name}, Student A Class : {A.Class.Code}, Student A Age : {DateTime.UtcNow.Year-A.BirthDate.Year}");

                Console.WriteLine($"Student B Name: {B.name}, Student B Class : {B.Class.Code}, Student B Age : {DateTime.UtcNow.Year-B.BirthDate.Year}");

           

            

        }














}























}