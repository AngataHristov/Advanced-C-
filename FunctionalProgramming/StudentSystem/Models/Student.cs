namespace StudentSystem.Models
{
    using System.Collections.Generic;
    using System.Text;
    using Interfaces;

    public class Student : IStudent
    {
        private IList<int> marks;

        public Student(
            string firstName,
            string lastName,
            int age,
            string facultyNumber,
            string phone,
            string email,
            IList<int> marks,
            int groupNumber,
            string groupName
            )
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.FacultyNumber = facultyNumber;
            this.Phone = phone;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
            this.GroupName = groupName;
        }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public int Age { get; private set; }

        public string FacultyNumber { get; private set; }

        public string Phone { get; private set; }

        public string Email { get; private set; }

        public int GroupNumber { get; private set; }

        public string GroupName { get; private set; }

        public IList<int> Marks
        {
            get
            {
                return this.marks;
            }

            private set
            {
                if (value == null)
                {
                    value = new List<int>();
                }

                this.marks = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(string.Format("Name: {0} {1}", this.FirstName, this.LastName));
            result.AppendLine(string.Format("Age: {0}", this.Age));
            result.AppendLine(string.Format("Faculty number: {0}", this.FacultyNumber));
            result.AppendLine(string.Format("Phone number: {0}", this.Phone));
            result.AppendLine(string.Format("Email: {0}", this.Email));
            result.AppendLine(string.Format("Group number: {0}", this.GroupNumber));
            result.AppendLine(string.Format("Group name: {0}", this.GroupName));
            result.AppendLine(string.Format("Marks: {0}", this.Marks.Count > 0 ? string.Join(", ", this.Marks) : "No marks"));

            return result.ToString().Trim();
        }
    }
}
