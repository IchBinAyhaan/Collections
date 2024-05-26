
using System.Diagnostics;

namespace Student
{
    internal class Student
    {
        private Dictionary<string, List<int>> Grades { get; } = new Dictionary<string, List<int>>();
        public void AddGrade(string subject, int grade)
        {
            if (!Grades.ContainsKey(subject))
                Grades[subject] = new List<int>();

            Grades[subject].Add(grade);
        }
        public void RemoveGrade(string subject, int grade)
        {
            if (Grades.ContainsKey(subject))
                Grades[subject].Remove(grade);
        }
        public double GetAverageGrade(string subject)
        {
            return Grades.ContainsKey(subject) ? Grades[subject].Average() : -1;
        }
        public Dictionary<string, List<int>> GetAllGradesByStudent()
        {
            return Grades;
        }
    }
    
}
