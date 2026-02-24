using System;

class Assignment
{

    protected string _studentName = "";
    protected string _topic = "";
    
    public Assignment(string student, string topic)
    {
        _studentName = student;
        _topic = topic;
    }
    
    public string GetHomeworkList()
    {
        return $"{_studentName} - {_topic}";
    }
}