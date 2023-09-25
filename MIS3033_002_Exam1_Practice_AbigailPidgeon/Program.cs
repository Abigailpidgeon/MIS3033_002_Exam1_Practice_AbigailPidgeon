// MIS 3033 002
// September 25 2023
// Exam 1 Practice
// Abigail Pidegeon 113515288
using a;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;

Console.WriteLine("Exam 1 Practice");

string menu = @"
***************************************************
Menu Options
1. Add one new student 
2. Show all students
3. Search one student for a given ID
4. Edit one student for a given ID
5. Delete one student for a given ID
6. Student with highest grade
7. Average grade
Press any key to exit
****************************************************
";

StudentDB db;
db = new StudentDB();

while (true)
{
    Console.WriteLine(menu);
    string userChoice;
    Console.Write("Enter your option: ");
    userChoice = Console.ReadLine();

    if (userChoice == "1") 
    {
        Console.WriteLine("Add one new student");

        Console.Write("ID: ");
        string id = Console.ReadLine();

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Grade: ");
        string gradeStr = Console.ReadLine();
        double grade = Convert.ToDouble(gradeStr);

        Student stu;
        stu = new Student() {ID = id,name=name,grade=grade};
        stu.GetGradeLevel();//get grade changes

        db.StuTbl.Add(stu);// in the computer mem
        db.SaveChanges();// persist

        Console.WriteLine(stu);

    }
    else if (userChoice == "2")
    {
        Console.WriteLine("Show all students");
        db.StuTbl.ToList().ForEach(t => Console.WriteLine(t));

        //List<student> stulist = db.StuTbl.ToList();
        //for (int i = 0; i < stulist.Count; i++)
        //{
        //    Console.WriteLine(stulist[i]);
        //}
   
    }
    else if (userChoice == "3")
    {
        Console.WriteLine("Search one student for a given ID");
        Console.Write("ID: ");
        string id = Console.ReadLine();

        Student stu = db.StuTbl.Where(t=>t.ID ==id).FirstOrDefault();// where is always a collection

        if (stu == null)
        {
            Console.WriteLine($"Student {id} does not exist in the database.");
        }
        else
        {
            Console.WriteLine(stu);
        }
    }
    else if (userChoice == "4")
    {
        Console.WriteLine("Edit one student for a given ID");
        Console.Write("ID: ");
        string id = Console.ReadLine();

        Student stu = db.StuTbl.Where(t => t.ID == id).FirstOrDefault();// where is always a collection

        if (stu == null)
        {
            Console.WriteLine($"Student {id} does not exist in the database.");
        }
        else
        {
            Console.WriteLine("The current info is:");
            Console.WriteLine(stu);

            Console.Write("New name: ");
            string name = Console.ReadLine();

            Console.Write("New grade: ");
            string gradestr = Console.ReadLine();
            double grade = Convert.ToDouble(gradestr);

            stu.name = name; 
            stu.grade = grade;
            stu.GetGradeLevel();//computer memoery

            db.SaveChanges();//persist updating th db

            Console.WriteLine("The new info is: ");
            Console.WriteLine(stu);

        }
    }
    else if (userChoice == "5")
    {
        Console.WriteLine("Delete one student for a given ID");
        Console.Write("ID: ");
        string id = Console.ReadLine();

        Student stu = db.StuTbl.Where(t => t.ID == id).FirstOrDefault();// where is always a collection

        if (stu == null)
        {
            Console.WriteLine($"Student {id} does not exist in the database.");
        }
        else
        {
            db.StuTbl.Remove(stu);
            db.SaveChanges();//persist
            Console.WriteLine("Student deleted sucessfully.");
            Console.WriteLine(stu);
        }

    }
    else if (userChoice == "6")
    {
        Console.WriteLine("Student with highest grade");
        Student stu = db.StuTbl.ToList().MaxBy(x=>x.grade);
        Console.WriteLine(stu);
        
    }
    else if (userChoice == "7")
    {
        Console.WriteLine("Average grade");
        double avggrade = db.StuTbl.Average(a => a.grade);
        Console.WriteLine($"{avggrade:F2}");

    }
    else
    {
        Console.WriteLine("Thank you and goodbye!");
        db.Dispose();//disconnect form the database 
        break;
}   }