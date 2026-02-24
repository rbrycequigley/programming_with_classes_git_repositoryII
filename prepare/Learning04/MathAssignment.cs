using System;

class MathAssignment : Assignment
{

    private string _TextbookSection = "";
    private string _Problems = "";
    
    public MathAssignment(string Textbook, string Problems, string student, string topic) : base(student, topic)
    {
        _TextbookSection = Textbook;
        _Problems = Problems;
        _studentName = student;
        _topic = topic;
    }
    
    public string GetHomeworkList()
    {
        return $"{base.GetHomeworkList()}\n{_TextbookSection} {_Problems}";
    }
}