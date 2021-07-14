using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task3
{
    public class Student
    {
        public int GetAverage(int[] marks)
        {
            if (marks == null) throw new ArgumentException();

            if (marks.Length == 0) throw new ArgumentException("Marks is empty");

            return marks.ToList().Sum() / marks.Length;
        }
    }
}
