using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Core;
using System.ComponentModel;

namespace SAT.DATA.EF.Models/*.Metadata*/
{
    #region Course
    public class CourseMetadata
    {
        public int CourseId { get; set; }

        [Required]
        [MaxLength(50)]
        [DisplayName("Course Name")]
        public string CourseName { get; set; } = null!;

        [Required]
        [MaxLength(1000)]
        [DisplayName("Course Description")]
        public string CourseDescription { get; set; } = null!;

        [Required]
        [Range(0, 255, ErrorMessage = "Value must be between 0 and 255")]
        [DisplayName("Credit Hours")]
        public byte CreditHours { get; set; }

        [MaxLength(250)]
        public string? Curriculum { get; set; }

        [MaxLength(500)]
        public string? Notes { get; set; }

        [Required]
        [DisplayName("Is Active?")]
        public bool IsActive { get; set; }
    }
    #endregion

    #region Enrollment 
    public class EnrollmentMetadata
    {
        public int EnrollmentId { get; set; }
        public int StudentId { get; set; }
        public int ScheduledClassId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }

    }
    #endregion

    #region ScheduledClass
    public class ScheduledClassMetadata
    {
        public int ScheduledClassId { get; set; }
        public int CourseId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Start Date")]
        public DateTime StartDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayName("End Date")]
        public DateTime EndDate { get; set; }

        [Required]
        [MaxLength(40)]
        [DisplayName("Instructor Name")]
        public string InstructorName { get; set; } = null!;

        [Required]
        [MaxLength(20)]
        public string Location { get; set; } = null!;
        public int Scsid { get; set; }
    }
    #endregion

    #region ScheduledClassStatus
    public class ScheduledClassStatusMetadata
    {
        public int Scsid { get; set; }

        [Required]
        [MaxLength(50)]
        [DisplayName("SCS Name")]
        public string ScsName { get; set; } = null!;
    }
    #endregion

    #region Student
    public class StudentMetadata
    {
        public int StudentId { get; set; }

        [Required]
        [MaxLength(20)]
        [DisplayName("First Name")]
        public string FirstName { get; set; } = null!;

        [Required]
        [MaxLength(20)]
        [DisplayName("Last Name")]
        public string LastName { get; set; } = null!;

        [MaxLength(15, ErrorMessage = "Must be 15 characters or less")]
        public string? Major { get; set; }

        [MaxLength(50)]
        public string? Address { get; set; }

        [MaxLength(25)]
        public string? City { get; set; }

        [MaxLength(2)]
        [DataType(DataType.Text)]
        public string? State { get; set; }

        [MaxLength(10)]
        [DataType(DataType.PostalCode)]
        public string? ZipCode { get; set; }

        [MaxLength(13)]
        [DataType(DataType.PhoneNumber)]
        public string? Phone { get; set; }

        [Required]
        [MaxLength(60)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = null!;

        [MaxLength(100)]
        [DataType(DataType.Url)]
        public string? PhotoUrl { get; set; }
        public int Ssid { get; set; }
    }

    #endregion

    #region StudentStatus
    public class StudentStatusMetadata
    {
        public int Ssid { get; set; }

        [Required]
        [MaxLength(30)]
        [DisplayName("SS Name")]
        public string Ssname { get; set; } = null!;

        [MaxLength(250)]
        [DisplayName("SS Description")]
        public string? Ssdescription { get; set; }
    }
    #endregion
}
