using System;
using System.Collections.Generic;
namespace StudentEditor
{
    public class StudentFormatter
    {
        public static string studentReport(List<Student> students){
            int fullTime = 0;
            int distance = 0;
            string ftStudents = String.Empty;
            string dtStudents = String.Empty;
            
            foreach (Student item in students)
            {
                if (item is FullTimeStudent)
                {
                    FullTimeStudent fts = (FullTimeStudent)item;
                    fullTime++;
                    ftStudents += $"{fts.getId()}\t{fts.getFirstName()}\t{fts.getLectureHours()}\t{fts.getCampus()}\n";
                }
                
                else if (item is DistanceStudent)
                {
                    DistanceStudent dts = (DistanceStudent)item;
                    distance++;
                    dtStudents += $"{dts.getId()}\t{dts.getFirstName()}\t{dts.getLectureHours()}\t{dts.getFacilitator()}\n";
                    
                }
            }

            return $"There are {fullTime} Full Time Students\nThere are {distance} Part Time Students\n\nFULL TIME STUDENTS:\n{ftStudents}\n\nPART TIME STUDENTS:\n{dtStudents}";
        }

        public static string formatForWrite(Student stIn)
        {
            if (stIn is FullTimeStudent)
                {
                    FullTimeStudent fts = (FullTimeStudent)stIn;
                    return $"F#{fts.getId()}#{fts.getFirstName()}#{fts.getLastName()}#{fts.getCampus()}";
                }
                else if (stIn is DistanceStudent)
                {
                    DistanceStudent dts = (DistanceStudent)stIn;
                    return $"D#{dts.getId()}#{dts.getFirstName()}#{dts.getLastName()}#{dts.getFacilitator()}";
                }else
                {
                    return $"E#{stIn.getId()}";
                }
        }
    }
}