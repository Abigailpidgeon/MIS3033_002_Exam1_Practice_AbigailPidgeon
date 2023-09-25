// MIS 3033 002
// September 25 2023
// Exam 1 Practice
// Abigail Pidegeon 113515288
using System.ComponentModel.Design;
using System.Diagnostics;

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

while (true)
{
    Console.WriteLine(menu);
    string userChoice;
    Console.Write("Enter your option: ");
    userChoice = Console.ReadLine();

    if (userChoice == "1") 
    {
       //1.Add one new student
    }
    else if (userChoice == "2")
    {
       //2.Show all students
    }
    else if (userChoice == "3")
    {
       //3.Search one student for a given ID
    }
    else if (userChoice == "4")
    {  
       //4.Edit one student for a given ID
    }
    else if (userChoice == "5")
    {
       //5.Delete one student for a given ID
    }
    else if (userChoice == "6")
    {
       //6.Student with highest grade
    }
    else if (userChoice == "7")
    {
       //7.Average grade
    }
    else
    {
        Console.WriteLine("Thank you and goodbye!");
        break;
}   }