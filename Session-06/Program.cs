// See https://aka.ms/new-console-template for more information



using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Session_06;

class University //if i suppress can i take null or not

{ public Student[] Students { get; set; }
    public Course[]? Courses { get; set; }
    public Grade[]? Grades { get; set; }
    public ScheduledCourse[]? ScheduledCourses { get; set; }

    private void GetStudents(){

    
    }
    private void SetCourses() { 
    
    }
    private void GetGrades()
    {


    }
    private void SetSchedule( int CourseID, string Professor, int datetime)
    {


    }

    }


}
public class ScheduledCourse
{

}

public class Grade
{
}

public class Course
{
    int ID;
    string Code;
    string Subject;

}

public class Student
{
    int RegistrationNumber;
    public Course[]? Courses { get; set; }

    private void Attend(string course, int datetime)
    {

    }
    private void WriteExam( string course, int time) { 
    
    
    }

};

