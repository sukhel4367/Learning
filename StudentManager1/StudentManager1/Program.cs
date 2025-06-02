using System.Xml.Linq;

public class Student
{
    public string StudentName { get; set; }
    public Dictionary<string, int> SubjectMarks { get; set; }

    public Student(string StudentName)
    {
        this.StudentName = StudentName;
        SubjectMarks = new Dictionary<string, int>();
    }


    public void AddMark(string subject, int mark)
    {
        SubjectMarks[subject] = mark;
    }
    public void Print()
    {
        Console.WriteLine($"Student Name : {StudentName}");
        foreach (var item in SubjectMarks)
        {
            Console.WriteLine($"{item.Key} : {item.Value}");
        }
    }



    public class Program
    {
        public static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>();

            Console.WriteLine("No of students wanted to add");
            int input = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= input; i++)
            {
                Console.Write($"Enter Student Name  :");
                string StudentName = Console.ReadLine();

                Console.Write($"Enter Subject Name of Student - {i} :");
                string SubjectName = Console.ReadLine();

                Console.Write($"Enter Subject Mark of Student - {i} :");
                int SubjectMark = int.Parse(Console.ReadLine());

                Student student = new Student(StudentName);
                student.AddMark(SubjectName, SubjectMark);
                studentList.Add(student);



            }
            Console.Write($"Type Y or y to view Student Data ");
            string option = Console.ReadLine();
            if (option == "Y" || option == "y")
            {
                foreach (var student in studentList)
                {
                    student.Print();
                }

            }
        }
    }
}