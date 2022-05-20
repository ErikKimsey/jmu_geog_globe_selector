using System;
using UnityEngine;
[CreateAssetMenu(fileName = "ActivityItem", menuName = "Activity Item ")]
[Serializable]
public class ActivityItem : ScriptableObject
{
     public int index;
     public string itemLabel = "";
}