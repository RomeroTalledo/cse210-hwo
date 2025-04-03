using System;

namespace assignmentProgram;

public class WritingAssignment : Assignment
{
    protected string _title;

    public WritingAssignment(string studentName, string topic, string title) : base(studentName,topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        return $"{_studentName} - {_topic} \n{_title}";
    }
}