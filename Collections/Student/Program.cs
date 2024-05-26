namespace Student
{
    class Program
    {
        static void Main()
        {
            Student student = new Student();
            student.AddGrade("Math", 80);
            student.AddGrade("Math", 90);
            student.AddGrade("Science", 75);

            Console.WriteLine("All grades:");
            var allGrades = student.GetAllGradesByStudent();
            foreach (var subjectGrades in allGrades)
            {
                Console.WriteLine($"Subject: {subjectGrades.Key}, Grades: {string.Join(", ", subjectGrades.Value)}");
            }
            Console.WriteLine("Average grade for Math: " + student.GetAverageGrade("Math"));
        }
    }
}
