using System;

class WritingAssignment : Assignment
{

    private string _Title = "";
    
    public WritingAssignment(string title, string student, string topic) : base(student, topic)
    {
        _Title = title;
        _studentName = student;
        _topic = topic;
    }

    public string getWritingInformation()
    {
        return $"{_studentName} - {_topic}\n{_topic}";
    }
}