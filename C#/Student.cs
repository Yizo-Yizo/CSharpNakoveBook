using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    public class Student
    {
        // Ch 14 No. 1
        private string? name;
        private string? course;
        private string? subject;
        private string? university;
        private string? email;
        private string? phoneNumber;

        // Ch 14 No. 3
        private static int count;

        public static int Count
        {
            get
            {
                return count;
            }
        }
        // Ch 14 No. 2
        public string? Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string? Course
        {
            get
            {
                return course;
            }
            set
            {
                course = value;
            }
        }
        public string? Subject
        {
            get
            {
                return subject;
            }
            set
            {
                subject = value;
            }
        }
        public string? University
        {
            get
            {
                return university;
            }
            set
            {
                university = value;
            }
        }
        public string? Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        public string? PhoneNumber
        {
            get
            {
                return phoneNumber;
            }
            set
            {
                phoneNumber = value;
            }
        }

        // Ch 14 No. 2
        public Student(string name, string course, string subject, string university, string email, string phoneNumber)
        {
            this.name = name;
            this.course = course;
            this.subject = subject;
            this.university = university;
            this.email = email;
            this.phoneNumber = phoneNumber;
            count++;
        }

        public Student(string name, string course)
        {
            this.name = name;
            this.course = course;
            this.subject = null;
            this.university = null;
            this.email = null;
            this.phoneNumber = null;
            count++;
        }

        public Student(string name)
        {
            this.name = name;
            this.course = null;
            this.subject = null;
            this.university = null;
            this.email = null;
            this.phoneNumber = null;
            count++;
        }

        // Ch 14 No.4
        public void PrintStudentInfo()
        {
            Console.WriteLine(
                "Name: \t{0}\n" +
                "Course: \t{1}\n"+
                "Subject: \t{2}\n" +
                "University: \t{3}\n" +
                "Email: \t{4}\n" +
                "Phone Number: \t{5}", this.name, this.course, this.subject, this.university, this.email, this.phoneNumber
                );
        }
    }
}
