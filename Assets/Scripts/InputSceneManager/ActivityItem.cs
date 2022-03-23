using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "ActivityItem", menuName = "Activity Item ")]
[Serializable]
public class ActivityItem : ScriptableObject
{
     public int index;
     public string itemLabel = "";
}