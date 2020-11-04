using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace _20201104student
{
    class Student
    {
        public string StudentID;
        public string Name;
        public int Grade;

        public string Say()
        {
     
            return "My name is " + Name + ",and I am a grade " + Grade + " student.My student ID is " + StudentID + ".";
        }

        
    }
}
