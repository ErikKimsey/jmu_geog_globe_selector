using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "ActivityManagement", menuName = "ActivityManagement", order = 0)]
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