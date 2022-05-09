using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;



public class ActivityOption : ScriptableObject
{
    // "ActivityTitle" defined when class is instantiated.
    public string ActivityTitle = "";

    // "OptionLabel" defined when globe stop spinning, selection is made.
    public string OptionLabel = "";

    // names of students, populated by "AddStudentName()"
    public List<string> m_StudentNames = new List<string>();

    // student name added when button "Add Student" is pressed
    public void AddStudentName(string _name)
    {
        m_StudentNames.Add(_name);
    }

    public List<string> GetStudentNames()
    {
        return m_StudentNames;
    }
}

public class ActivityManagement : ScriptableObject
{
    public List<ActivityOption> m_ActivityOptions = new List<ActivityOption>();


    // Called when globe selector stops on an activty option
    public void CreateNewOptionSelection(string _activityTitle, string _optionLabel)
    {
        ActivityOption _activityOption =
            (ActivityOption)ScriptableObject.CreateInstance<ActivityOption>();
        _activityOption.OptionLabel = _optionLabel;
        _activityOption.ActivityTitle = _activityTitle;
        m_ActivityOptions.Add(_activityOption);
    }

    public void AddStudentName(string _name)
    {
        ActivityOption _current = m_ActivityOptions.Last();
        _current.AddStudentName(_name);
    }


}