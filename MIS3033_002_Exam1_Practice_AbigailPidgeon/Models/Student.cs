using System.ComponentModel.DataAnnotations;

namespace a
{
    public class Student
    {
        [Key]
        public string ID { get; set; }
        public string name { get; set; }
        public double grade { get; set; }
        public int gradeLevel { get; set; }
        public Student() { }
        public override string ToString()
        {
            return $"{this.name}({this.ID}), Grade: {this.grade:F2} (Level {this.gradeLevel})";
        }
        public int GetGradeLevel()
        {
            if (this.grade >= 80)
            {
                gradeLevel = 1;
            }
            else if (this.grade >= 65)
            {
                gradeLevel = 2;
            }
            else
            {
                gradeLevel = 3;
            }
            return gradeLevel;
        }

    }
}