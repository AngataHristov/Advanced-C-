namespace StudentSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Models;

    public class StudentSystemMain
    {

        public static void Main()
        {
            //Problem 1.	Class Student

            IList<Student> students = new List<Student>()
            {
                new Student("Petar","Petrov",23,"800014","+359 888456123","alabala@dir.bg",new List<int>() { 2, 3, 4, 4, 5, 5, 6, 6 }, 2,"Sofia"),
                new Student("Emil","Emilov",33,"850014","+359 2555623","emil@abv.bg",new List<int>() { 6, 6, 6, 6, 6, 5, 6, 6 }, 1,"Plovdiv"),
                new Student("Zdravko","Ivanov",17,"734015","+359 42456123","zizo@dir.bg",new List<int>() { 2, 3, 4, 6, 6, 4, 5, 5, 5, 3, 2 }, 2,"Varna"),
                new Student("Dinko","Dinev",26,"023016","+359 888457873","dinko@softuni.bg",null, 1,"Plovdiv"),
                new Student("Samuil","Asparuhov",19,"800014","+359 888456123","alabala@dir.bg",new List<int>() { 2, 3, 4, 4, 3, 5, 5, 3 }, 2,"Sofia"),
                new Student("Gosho","Peshev",33,"851014","02 888555623","gosho@abv.bg",new List<int>() { 6, 6, 6, 6, 6, 5, 6, 6 }, 1,"Varna"),
            };

            //Problem 2.	Students by Group

            var studentsByGroups =
                from student in students
                where student.GroupNumber == 2
                orderby student.FirstName
                select student;

            //List<Student> studentsByGroups = students
            //    .Where(s => s.GroupNumber == 2)
            //    .OrderBy(s => s.FirstName)
            //    .ToList();

            foreach (Student student in studentsByGroups)
            {
                Console.WriteLine(student);
                Console.WriteLine(new string('=', 30));
            }

            MakeBoundaries();

            // Problem 3.	Students by First and Last Name

            //List<Student> studentsByFirstAndLastName = students
            //    .Where(s => s.FirstName.CompareTo(s.LastName) < 0)
            //    .ToList();

            var studentsByFirstAndLastName =
                from student in students
                where student.FirstName.CompareTo(student.LastName) < 0
                select student;

            foreach (Student student in studentsByFirstAndLastName)
            {
                Console.WriteLine(student);
                Console.WriteLine(new string('=', 30));
            }

            MakeBoundaries();

            // Problem 4.	Students by Age

            //var studentsByAge = students
            //    .Where(st => st.Age > 18 && st.Age < 24)
            //    .Select(st => new { FirstName = st.FirstName, LastName = st.LastName, Age = st.Age })
            //    .ToList();

            //foreach (var student in studentsByAge)
            //{
            //    Console.WriteLine(string.Format("{0} {1}: {2}", student.FirstName, student.LastName, student.Age));
            //}

            var studentsByAge =
                from student in students
                where student.Age > 18 && student.Age < 24
                select string.Format("{0} {1}: {2}", student.FirstName, student.LastName, student.Age);

            foreach (string student in studentsByAge)
            {
                Console.WriteLine(student);
            }

            MakeBoundaries();

            // Problem 5.	Sort Students

            List<Student> sortedStudent = students
                .OrderByDescending(st => st.FirstName)
                .ThenByDescending(st => st.LastName)
                .ToList();

            //var sortedStudent =
            //    from student in students
            //    orderby student.FirstName descending, student.LastName descending
            //    select student;

            foreach (Student student in sortedStudent)
            {
                Console.WriteLine(student);
                Console.WriteLine(new string('=', 30));
            }

            MakeBoundaries();

            // Problem 6.	Filter Students by Email Domain

            //List<Student> studentsByEmailDomain = students
            //    .Where(st => st.Email.Contains("@abv.bg"))
            //    .ToList();

            var studentsByEmailDomain =
                from student in students
                where student.Email.Contains("@abv.bg")
                select student;

            foreach (Student student in studentsByEmailDomain)
            {
                Console.WriteLine(student);
                Console.WriteLine(new string('=', 30));
            }

            MakeBoundaries();

            // Problem 7.	Filter Students by Phone

            //List<Student> studentsByPhone = students
            //    .Where(st =>
            //        st.Phone.StartsWith("02") ||
            //        st.Phone.StartsWith("+3592") ||
            //        st.Phone.StartsWith("+359 2"))
            //    .ToList();

            var studentsByPhone =
                from student in students
                where
                    student.Phone.StartsWith("02") ||
                    student.Phone.StartsWith("+3592") ||
                    student.Phone.StartsWith("+359 2")
                select student;

            foreach (Student student in studentsByPhone)
            {
                Console.WriteLine(student);
                Console.WriteLine(new string('=', 30));
            }

            MakeBoundaries();

            //Problem 8.	Excellent Students

            //var excellentStudents = students
            //    .Where(st => st.Marks.Any(m => m == 6))
            //    .Select(st => new { FullName = st.FirstName + " " + st.LastName, Marks = st.Marks })
            //    .ToList();

            var excellentStudents =
                from student in students
                where student.Marks.Contains(6)
                select new { FullName = student.FirstName + " " + student.LastName, Marks = student.Marks };

            foreach (var student in excellentStudents)
            {
                Console.WriteLine("{0}: {1}", student.FullName, string.Join(", ", student.Marks));
            }

            MakeBoundaries();

            // Problem 9. Weak Students

            List<Student> weakStudents = students
                .Where(st => st.Marks.Where(m => m == 2).Count() == 2)
                .ToList();

            foreach (Student student in weakStudents)
            {
                Console.WriteLine(student);
                Console.WriteLine(new string('=', 30));
            }

            MakeBoundaries();

            // Problem 10.	Students Enrolled in 2014

            List<IList<int>> studentsEnrolledIn2014 = students
                .Where(st => st.FacultyNumber.EndsWith("14"))
                .Select(st => st.Marks)
                .ToList();

            foreach (IList<int> marks in studentsEnrolledIn2014)
            {
                Console.WriteLine(string.Join(" ", marks));
                Console.WriteLine(new string('=', 30));
            }

            MakeBoundaries();

            // Problem 11.	* Students by Groups

            //var studentsByGroupName = students
            //    .GroupBy(st => st.GroupName)
            //    .Select(gr =>  new {GroupName = gr.Key, Students = gr.ToList()})
            //    .ToList();

            var studentsByGroupName =
                from student in students
                group student by student.GroupName
                into gr
                select new { GroupName = gr.Key, Students = gr.ToList() };

            foreach (var group in studentsByGroupName)
            {
                Console.WriteLine("{0}:", group.GroupName);
                Console.WriteLine("\t{0}", string.Join("\n\t", group.Students));
            }

            MakeBoundaries();

            // Problem 12.	* Students Joined to Specialties

            var specialties = new List<StudentSpecialty>()
            {
            new StudentSpecialty("Web Developer", "734015"),
            new StudentSpecialty("QA", "023016"),
            new StudentSpecialty("Web Developer", "800014"),
            new StudentSpecialty("QA", "850014"),
            new StudentSpecialty("Web Developer", "851014"),
            new StudentSpecialty("Java Developer", "023116"),
            new StudentSpecialty("Java Developer", "734115")
            };

            var studentSpecialty =
                from student in students
                join specialty in specialties
                    on student.FacultyNumber equals specialty.FacultyNumber
                orderby student.FirstName
                select new
                {
                    FullName = student.FirstName + " " + student.LastName,
                    FacNum = student.FacultyNumber,
                    Specialty = specialty.SpecialtyName
                };

            //var studentSpecialty = students
            //    .OrderBy(st => st.FirstName)
            //    .Join(specialties, st => st.FacultyNumber, sp => sp.FacultyNumber, (st, sp) => new
            //    {
            //        FullName = st.FirstName + " " + st.LastName,
            //        FacNum = st.FacultyNumber,
            //        Specialty = sp.SpecialtyName
            //    })
            //    .ToList();

            Console.WriteLine("Students with specialties: \n");
            foreach (var item in studentSpecialty)
            {
                Console.WriteLine("{0,-17} - {1,-5} - {2}", item.FullName, item.FacNum, item.Specialty);
            }

            MakeBoundaries();

        }

        private static void MakeBoundaries()
        {
            Console.WriteLine();
            Console.WriteLine(new string('$', 50));
            Console.WriteLine();
        }
    }
}
