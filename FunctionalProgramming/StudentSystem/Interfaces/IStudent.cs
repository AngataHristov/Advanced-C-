namespace StudentSystem.Interfaces
{
    using System.Collections.Generic;

    public interface IStudent
    {
        string FirstName { get; }

        string LastName { get; }

        int Age { get; }

        string FacultyNumber { get; }

        string Phone { get; }

        string Email { get; }

        IList<int> Marks { get; }

        int GroupNumber { get; }

        string GroupName { get; }
    }
}
