// See https://aka.ms/new-console-template for more information
namespace week1Task
{
    
    partial class school_Calculator
    {
        string course_Name = "";
        string course_Code = "";
        int course_unit, no_Of_Course;
        int point;
        int CGPA;
        int course_Score;
        int total_Point;
        int total_Course_unit,total_Course_Unit_Passed;
        List <string> Course_Name_File = new List<string>();
        List <string> Course_Code_File = new List<string>();
        List <int> Course_Unit_File = new List<int>();
        List <int> Course_Score_File = new List<int>();
        List<int> course_Unit_File = new List<int>();
        List<char> course_Grade_File = new List<char>();
        List<int> grade_Unit_File = new List<int>();
        List<int> weight_pt_File = new List<int>();
        List<string> remark_File = new List<string>();


        public void getUserInput()
        {


                try
                {
                    Console.WriteLine("Welcome To Sammy Calculator Which Is Reliable And Sufficient Please Type In Your User Input");
                    Console.WriteLine("Please enter the number of Courses you took for the semester");
                try
                {
                    no_Of_Course = Convert.ToInt32(Console.ReadLine());

                    total_Course_unit = 0;


                    for (int i = 0; i < no_Of_Course; i++)
                    {
                    Console.WriteLine("Please enter your course name: ");                 
                    course_Name = Console.ReadLine();

                    Console.WriteLine("Please enter your course code: ");
                    course_Code = Console.ReadLine();

                    Console.WriteLine("Please enter your course unit: ");
                    course_unit = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Please enter your  course score: ");
                    course_Score = Convert.ToInt32(Console.ReadLine());

                    course_Unit_File.Add(course_unit);
                    Course_Score_File.Add(course_Score);
                    Course_Name_File.Add(course_Name);
                    Course_Code_File.Add(course_Code);
                }

                }
                catch(FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
               

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            

        }


        public void processUserInfo()
              
        {
            
                total_Point = 0;
                point = 0;
                total_Course_Unit_Passed = 0;
                total_Course_unit = 0;
                for (int i = 0; i < no_Of_Course; i++)
                {
                    total_Course_unit += course_Unit_File[i];
                    if (Course_Score_File[i] >= 70 && Course_Score_File[i] <= 100)
                    {
                        grade_Unit_File.Add(5);
                        course_Grade_File.Add('A');
                        remark_File.Add("Excellent");
                        point = course_Unit_File[i] * 5;
                        total_Point += point;
                        weight_pt_File.Add(point);
                        total_Course_Unit_Passed += course_Unit_File[i];

                    }
                    else if (Course_Score_File[i] >= 60 && Course_Score_File[i] <= 69)
                    {
                        grade_Unit_File.Add(4);
                        course_Grade_File.Add('B');
                        remark_File.Add("Very Good");
                        point = course_Unit_File[i] * 4;
                        total_Point += point;
                        weight_pt_File.Add(point);
                        total_Course_Unit_Passed += course_Unit_File[i];


                    }
                    else if (Course_Score_File[i] >= 50 && Course_Score_File[i] <= 59)
                    {
                        grade_Unit_File.Add(3);
                        course_Grade_File.Add('C');
                        remark_File.Add("Good");
                        point = course_Unit_File[i] * 3;
                        total_Point += point;
                        weight_pt_File.Add(point);
                        total_Course_Unit_Passed += course_Unit_File[i];

                    }
                    else if (Course_Score_File[i] >= 45 && Course_Score_File[i] <= 49)
                    {
                        grade_Unit_File.Add(2);
                        course_Grade_File.Add('D');
                        remark_File.Add("Fair");
                        point = course_Unit_File[i] * 2;
                        total_Point += point;
                        weight_pt_File.Add(point);
                        total_Course_Unit_Passed += course_Unit_File[i];

                    }
                    else if (Course_Score_File[i] >= 40 && Course_Score_File[i] <= 44)
                    {
                        grade_Unit_File.Add(1);
                        course_Grade_File.Add('E');
                        remark_File.Add("Pass");
                        point = course_Unit_File[i] * 1;
                        total_Point += point;
                        weight_pt_File.Add(point);
                        total_Course_Unit_Passed += course_Unit_File[i];

                    }
                    else if (Course_Score_File[i] >= 0 && Course_Score_File[i] <= 39)
                    {
                        grade_Unit_File.Add(0);
                        course_Grade_File.Add('F');
                        remark_File.Add("Fail");
                        point = course_Unit_File[i] * 0;
                        total_Point += point;
                        weight_pt_File.Add(point);
                        total_Course_Unit_Passed += 0;

                    }

                }
            
            try
            {
                CGPA = total_Point / total_Course_Unit_Passed;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            
        }

    }
    
    partial class school_Calculator
    {
        public void printTable()
        {
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine(" COURSE & CODE | COURSE UNIT |  GRADE - UNIT  |  WEIGHT Pt  |  REMARK  |" );
            Console.WriteLine("-------------------------------------------------------------------------");

            for (int i = 0; i < no_Of_Course; i++)
            {
                 Console.WriteLine($"{Course_Name_File[i]} | {Course_Code_File[i]} | {course_Grade_File[i]} | {course_Unit_File[i]} | {weight_pt_File[i]} | {remark_File[i]} |");
            }
            Console.WriteLine("-------------------------------------------------------------------------");

            Console.WriteLine($" Total Course Registered is {total_Course_unit}");
            Console.WriteLine($"Total Course Unit Passed is {total_Course_Unit_Passed}");
            Console.WriteLine($"Total Weight point is {total_Point}");
            Console.WriteLine($" Your CGPA IS {CGPA}");
           



        }
        public static void Main()
        {
            school_Calculator Report = new school_Calculator();           
            Report.getUserInput();
            Report.processUserInfo();
            Report.printTable();

        }

    

    }



}
