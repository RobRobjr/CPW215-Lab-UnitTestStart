using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public class Course
    {
        public Course(string courseName)
        {
            if (string.IsNullOrWhiteSpace(courseName))
            {
                throw new ArgumentNullException($"{nameof(courseName)} cannot be null or whitespace");
            }
            CourseName = courseName;
        }

        /// <summary>
        /// The instructor teaching the course
        /// </summary>
        private static string instructorName = "STAFF";
        public string InstructorName
        {
            get { return instructorName; }
            set { instructorName = value; }
        }

        /// <summary>
        /// The name of the course
        /// </summary>
        public string CourseName { get; set; }


        /// <summary>
        /// Number of credits for the course
        /// </summary>
        public byte NumberOfCredits { get; set; }

        public Course(byte numCredits)
        {
            if (numCredits == 0 || numCredits > 30)
            {
                throw new ArgumentException("You must have between 1 and 30 credits!");
            }
            NumberOfCredits = numCredits;
        }
    }
}

