using System.Threading;
using System.Threading.Tasks;
using System.Security;
using System;
using System.Collections.Generic;

namespace StudentEditor
{
    public class StudentWorker
    {
        private static List<Student> students = new List<Student>();

        public static List<Student> getStudents() 
        {
		    return students;
        }

        public static void setStudents(List<Student> list) 
        {
		    students = list;
        }

          public static void addStudent(Student st){
            students.Add(st);
        }

    }
}