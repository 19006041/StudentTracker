using System;
using System.Collections.Specialized;
using System.Text;


namespace StudentEditor
{
    class Program
    {
        static string file = "records.txt";
        static string[] menuChoices = {"Add Student", "View Students", "Quit"};
        static string[] studentMenu = {"Full Time", "Distance", "Back"};
        static string[] choice = {"No", "Yes"};

        

        static void Main(string[] args)
        {
            FileWorker fileWorker = new FileWorker(file);
            StudentWorker.setStudents(fileWorker.readFile());           
            mainMenu();
        }

        static void mainMenu()
        {
            int item = 0;
            ConsoleKeyInfo keyInfo;

             do
            {
                Console.Clear();
             
                System.Console.WriteLine("Use the Arrow Keys to pick an option");

                for (int i = 0; i < menuChoices.Length; i++)
                {
                    if (item == i)
                    {
                        System.Console.Write(menuChoices[i].PadRight(35));
                        System.Console.WriteLine("<<");
                    }
                    else
                    {
                        System.Console.WriteLine(menuChoices[i]);    
                    }
                }

                keyInfo = Console.ReadKey(true);

                if (keyInfo.Key.ToString() == "DownArrow")
                {
                    item++;
                    if (item > menuChoices.Length - 1) 
                    {
                        item = 0;
                    }
                }
                else if (keyInfo.Key.ToString() == "UpArrow")
                {
                    item--;
                    if (item < 0)
                    {
                        item = menuChoices.Length - 1;
                    } 
                }
            } while (keyInfo.KeyChar != 13);

            switch (item)
            {
                case 0:
                    addStudentMenu();
                    break;
                case 1:
                    viewStudents();
                    break;
                case 2:                
                    Console.Clear();
                    break;
                default:
                    break;
            } 

        }


        static void viewStudents()
        {
            Console.Clear();
      
            System.Console.WriteLine("");
            
            System.Console.WriteLine(StudentFormatter.studentReport(StudentWorker.getStudents()));

            System.Console.WriteLine("\n\n\nPress any Key to go back ...");
            Console.ReadKey();
    
            mainMenu();
        }


         static void addStudentMenu()
        {
            int selection = 0;
            
            ConsoleKeyInfo keyInfo;

            do
            {
                Console.Clear();

                System.Console.WriteLine("Use the Arrow Keys to pick an option");

                for (int i = 0; i < studentMenu.Length; i++)
                {
                    
                    if (selection == i)
                    {
                        System.Console.Write(studentMenu[i].PadRight(35));
                        System.Console.WriteLine("<<");
                    }
                    else
                    {
                        System.Console.WriteLine(studentMenu[i]);    
                    }
                }

                keyInfo = Console.ReadKey(true);

                if (keyInfo.Key.ToString() == "DownArrow")
                {
                    selection++;
                    if (selection > studentMenu.Length - 1) 
                    {
                        selection = 0;
                    }
                }
                else if (keyInfo.Key.ToString() == "UpArrow")
                {
                    selection--;
                    if (selection < 0)
                    {
                        selection = studentMenu.Length - 1;
                    } 
                }


            } while (keyInfo.KeyChar != 13);

            if (selection != 2)
            {
                addStudent(selection);
            }
            else
            {
                mainMenu();
            }
        }

           static void addStudent(int selection)
        {
            Console.Write("STUDENT ID     >> ");
            string id = Console.ReadLine();
            Console.Write("FIRST NAME     >> ");
            string fName = Console.ReadLine();
            Console.Write("LAST NAME      >> ");
            string lName = Console.ReadLine();

            FileWorker fw = new FileWorker(file);

            if(selection == 0)
            {
                Console.Write("CAMPUS         >> ");
                string campus = Console.ReadLine();
                FullTimeStudent fts = new FullTimeStudent(id,fName,lName,true,campus);
                StudentWorker.addStudent(fts);
                fw.addToFile(StudentFormatter.formatForWrite(fts));
                
            }else
            {
                Console.Write("FACILITATOR    >> ");
                string facilitator = Console.ReadLine();
                DistanceStudent dts = new DistanceStudent(id,fName,lName,true,facilitator);
                StudentWorker.addStudent(dts);
                fw.addToFile(StudentFormatter.formatForWrite(dts));
            }

            System.Console.WriteLine($"Student with id {id} added");
            System.Console.WriteLine("Press any key to go back ...");
            Console.ReadKey();
            addStudentMenu();
        }
    }
}
