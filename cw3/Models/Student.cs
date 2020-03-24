﻿namespace cw3.Models
{
    public class Student
    {
        public int IdStudent { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IndexNumber { get; set; }

        public override string ToString()
        {
            return $"{IdStudent} {FirstName} {LastName} {IndexNumber}";
        }
    }
}