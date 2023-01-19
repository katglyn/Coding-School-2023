// See https://aka.ms/new-console-template for more information



using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Session_06;

class Institute {

    public Guid ID { get; set; }
    string Name;
    int YearsInService;

    public void GetName()
    {

    }
    public void SetName(string name)
    {

    }


    class University : Institute //if i suppress can i take null or not

    {
        private ScheduledCourse[]? schedule;

        public Students[] Student { get; set; }
        public Courses[]? Course { get; set; }
        public Grades[]? Grade { get; set; }
        public ScheduledCourse[]? Schedule { get => schedule; set => schedule = value; }

        private void GetStudents()
        {

        }
        private void GetCourses()
        {

        }
        private void GetGrades()
        {

        }
        private void SetSchedule(int CourseID, int ProfessorID, int datetime)
        {


        }

    }

    public class Schedule { }
   // mou vgazei error pws uparxei hdh kai den me afhnei na to ksanavalw
   //public Guid ID;
    public Guid CourseID { get; set; }
    public Guid ProfessorID { get; set; }

    // public void Calendar[]? DateandTime {}



    public class Person {
    public Guid ID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    

    public Person(Guid id, string name) { }
    
      
   

public class Professor
    {
        public string Rank;
        public Course[]? Courses { get; set; }

        private void Teach(string course, int datetime)
        {

        }

        private void SetGrade(int StudentID, int courseID, int grade)
        {

        }
        private void Getname()
        {

        }
    }

}



public class ScheduledCourse
{

}

public class Grades
{
    
}

public class Courses
{
    int ID;
    string Code;
    string Subject;

}

public class Students : Person 
{
    int RegistrationNumber;

    public Students(Guid id, string name) : base(id, name)
    {
    }

    public Course[]? Courses { get; set; }

    private void Attend(string course, int datetime)
    {

    }
    private void WriteExam(string course, int time) {




    }

}

public class Course
{
}



}
