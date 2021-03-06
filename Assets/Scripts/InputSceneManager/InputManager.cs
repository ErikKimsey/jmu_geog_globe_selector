using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEditor.EditorTools;

[ExecuteInEditMode]
public class InputManager : MonoBehaviour
{
    [SerializeField] private Button addButton;
    [SerializeField] private Button submitButton;
    [SerializeField] private InputField m_InputField;
    [SerializeField] InputDisplay m_InputDisplay;
    [SerializeField] private DataManager m_DataManager;
    [SerializeField] private ActivityItem m_ActivityItem;


    private List<ActivityItem> m_ItemList;
    private int m_CurrIndex = 0;

    private void Start()
    {
        m_ItemList = new List<ActivityItem>();
    }

    public List<ActivityItem> GetItemList()
    {
        return m_ItemList;
    }

    public void AddInput()
    {
        ActivityItem _item = ScriptableObject.CreateInstance<ActivityItem>();
        _item.itemLabel = m_InputField.text;
        _item.index = m_ItemList.Count + 1;
        m_ItemList.Add(_item);
        UpdateDisplayedList(m_ItemList);
        ClearInput();
    }

    // Send updated list to InputDisplay
    public void UpdateDisplayedList(List<ActivityItem> list)
    {
        m_InputDisplay.DisplayInput(list.Last());

        // TODO:
        // 1. If no JSON file exists, create one.
        // m_DataManager.WriteFile(list);
        // 2. Write list to JSON file.
        // 3. etc:: Ideally, InputDisplay gets its data from the JSON file.
    }

    public List<ActivityItem> GetItems()
    {
        return m_ItemList;
    }

    void ClearInput()
    {
        m_InputField.text = "";
    }

    public void SubmitItems()
    {
        // TODO:
        // 1. Navigate to Main Scene,
        // ----> Start scene transition (?)
        // 2. (?) Delete all prefab instances
        m_DataManager.WriteFile(m_ItemList);
    }
}

// [Serializable]
// public class ActivityItem
// {
//     public int index;
//     public string itemLabel = "";
// }