using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SAT.DATA.EF.Models/*.Metadata*/
{
    #region Course
    public class CourseMetadata
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; } = null!;
        public string CourseDescription { get; set; } = null!;
        public byte CreditHours { get; set; }
        public string? Curriculum { get; set; }
        public string? Notes { get; set; }
        public bool IsActive { get; set; }
    }
    #endregion

    #region Enrollment 
    public class EnrollmentMetadata
    {
        public int EnrollmentId { get; set; }
        public int StudentId { get; set; }
        public int ScheduledClassId { get; set; }
        public DateTime EnrollmentDate { get; set; }

    }
    #endregion

    #region ScheduledClass
    public class ScheduledClassMetadata
    {
        public int ScheduledClassId { get; set; }
        public int CourseId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string InstructorName { get; set; } = null!;
        public string Location { get; set; } = null!;
        public int Scsid { get; set; }
    }
    #endregion

    #region ScheduledClassStatus
    public class ScheduledClassStatusMetadata
    {
        public int Scsid { get; set; }
        public string ScsName { get; set; } = null!;
    }
    #endregion

    #region Student
    public class StudentMetadata
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? Major { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? ZipCode { get; set; }
        public string? Phone { get; set; }
        public string Email { get; set; } = null!;
        public string? PhotoUrl { get; set; }
        public int Ssid { get; set; }
    }

    #endregion

    #region StudentStatus
    public class StudentStatusMetadata
    {
        public int Ssid { get; set; }
        public string Ssname { get; set; } = null!;
        public string? Ssdescription { get; set; }
    }
    #endregion
}
