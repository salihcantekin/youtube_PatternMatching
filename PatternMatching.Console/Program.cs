

using PatternMatching.Console;

var studentList = new List<Student>()
{
    new ITStudent(new Random().Next(100)) {  ComputerExamResult = 29},
    new MISStudent(new Random().Next(100))
};

var student = studentList[new Random().Next(studentList.Count)];

//if (student is ITStudent)
//{
//    ITStudent itStudent = (ITStudent)student;

//    Console.WriteLine("FullName: {0}", itStudent.ExamResult);
//}

//if (student is ITStudent itStudent)
//{
//    Console.WriteLine("FullName: {0}", itStudent.FullName);
//}


//if (student is ITStudent itStudent)
//{
//    if (itStudent.ComputerExamResult > 25 && itStudent.ComputerExamResult < 50)
//    {
//        Console.WriteLine("Between 25 and 50");
//    }
//    else
//    {
//        Console.WriteLine("NOT BETWEEN. {0}", itStudent.ComputerExamResult);
//    }
//}

//if (student is ITStudent { ComputerExamResult: > 25 and < 50 } itStudent)
//{
//    Console.WriteLine("Between 25 and 50");
//}
//else
//    Console.WriteLine("NOT BETWEEN.");


//if (student is ITStudent || student is not MISStudent { ProjectManagementExamResult: > 30 })
//{
//    Console.WriteLine(student.GetType().FullName);

//    if (student is MISStudent mis)
//    {
//        Console.WriteLine("Result: {0}", mis.ProjectManagementExamResult);
//    }
//}




//switch (student)
//{
//    case ITStudent itStudent:
//        {
//            Console.WriteLine("FullName: {0}", itStudent.FullName);
//            Console.WriteLine("ExamResult: {0}", itStudent.ExamResult);
//            Console.WriteLine("ComputerExamResult: {0}", itStudent.ComputerExamResult);
//            break;
//        }
//        break;
//    case MISStudent misStudent:
//        Console.WriteLine();
//        break;
//    default:
//        break;
//}


var alumni = student switch
{
    ITStudent itStudent => itStudent.ComputerExamResult > 49,
    MISStudent misStudent => misStudent.ProjectManagementExamResult > 69,
    Student s => s.ExamResult > 29,
    _ => false
};











Console.WriteLine("\n\nDONE!");
Console.ReadKey();
