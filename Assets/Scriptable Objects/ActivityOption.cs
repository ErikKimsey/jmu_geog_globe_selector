using System.Collections.Generic;
using UnityEngine;


    [CreateAssetMenu(fileName = "ActivityOption", menuName = "ActivityOption", order = 0)]
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