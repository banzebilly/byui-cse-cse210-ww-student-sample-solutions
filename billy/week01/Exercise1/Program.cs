//author: Banze

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public class ASSIgnm
{
    private string _studentN;
    private string _topicOFStudent;


    public ASSIgnm(string studentN, string topicOFStudent)
    {
        _studentN = studentN;
        _topicOFStudent = topicOFStudent;
    }

    // to create getter for the private member 

    public string GetStudentN()
    {
        return _studentN;
    }
    public string GetTopicOfStudent()
    {
        return _topicOFStudent;
    }


    public string GetSummaries()
    {
        return _studentN + "-" + _topicOFStudent;
    }
}





class MathAssgnme : ASSIgnm
{
    private string _textbookSection;
    private string _problem;


    public MathAssgnme(string studentN, string topicOFStudent, string textbookSection, string problems)
        : base(studentN, topicOFStudent)

    {
       _textbookSection = textbookSection;
       _problem = problems;


        
    }

    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problem {_problem}";
    }

    
   
}



public class WritingAssigments : ASSIgnm
{
    private string _title;


    public WritingAssigments(string studentN, string topicOFStudent, string title)
       : base(studentN, topicOFStudent)
    {
        _title = title;
    }

    public string GetwritingInfo()
    {
        string studemtName = GetStudentN();
        return $"{_title} by {studemtName}";
    }
}




class Problem
{
    static void Main(string[] args)
    {
        ASSIgnm a1 = new ASSIgnm("billy Paul", "Multiplication");
        Console.WriteLine(a1.GetSummaries());

        MathAssgnme a2 = new MathAssgnme("Eddo Mpundu", "Franctions", "7.3", "8-19");
        Console.WriteLine(a2.GetSummaries());
        Console.WriteLine(a2.GetHomeworkList);



        WritingAssigments a3 = new WritingAssigments("marry Paul", "Europe history", "The cause of world war II");
        Console.WriteLine(a3.GetSummaries());
        Console.WriteLine(a3.GetwritingInfo());
    }
}





