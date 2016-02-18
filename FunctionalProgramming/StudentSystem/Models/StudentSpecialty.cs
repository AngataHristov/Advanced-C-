namespace StudentSystem.Models
{
    using Interfaces;
    public class StudentSpecialty : IStudentSpecialty
    {
        public StudentSpecialty(string specialtyName, string facultyNumber)
        {
            this.SpecialtyName = specialtyName;
            this.FacultyNumber = facultyNumber;
        }

        public string SpecialtyName { get; private set; }

        public string FacultyNumber { get; private set; }
    }
}
