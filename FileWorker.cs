using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEditor
{
    public class FileWorker
    {
        private string filename;
        
        public FileWorker(string filename)
        {   
            if (!File.Exists(filename))
            {
                createFile(filename);
            }
            else
            {
                this.filename = filename;
            }
        }

        private void createFile(string filename)
        {
            File.CreateText(filename);
        }

        public void addToFile(String line)
        {
            using (StreamWriter sw = File.AppendText(this.filename))
            {
                sw.WriteLine(line);
            }	
        }

        public List<Student> readFile()
        {
            List<Student> students = new List<Student>();

            if( new FileInfo( filename ).Length > 0 )
            {string[] lines = File.ReadAllLines(filename);
            if (lines.Length > 0)
            {
                foreach (string line in lines)
                {
                    string[] record = line.Split('#');
                    
                    if (record[0].Equals("F"))
                    {
                        string id = record[1];
                        string fName = record[2];
                        string lName = record[3];
                        string campus = record[4];

                        FullTimeStudent fts = new FullTimeStudent(id,fName,lName,true,campus);
                        students.Add(fts);
                    }
                    if(record[0].Equals("D"))
                    {
                        string id = record[1];
                        string fName = record[2];
                        string lName = record[3];
                        string facilitator = record[4];

                        DistanceStudent dts = new DistanceStudent(id,fName,lName,true,facilitator);
                        students.Add(dts);
                    }
                }
            }

            }
            
            
            
         return students;
        }
    }
}