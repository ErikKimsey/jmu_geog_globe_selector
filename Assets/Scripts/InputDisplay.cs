using System;
using UnityEngine;
using UnityEngine.UI;

public class InputDisplay : MonoBehaviour
{
    private string inputText;
    private Text displayedInput;
    [SerializeField] private GameObject m_ListItemPrefab;
    [SerializeField] private GameObject m_Panel;

    private void Start()
    {
        displayedInput = GetComponent<Text>();
    }

    public void DisplayInput(ActivityItem n)
    {
            if (String.IsNullOrEmpty(n.itemLabel) == false &&
                m_ListItemPrefab != null)
            {
                // 1. instantiate ListItem PREFAB
                GameObject _clone = Instantiate(m_ListItemPrefab, m_Panel.transform);

                // 2. add item text to ListItem.text
               _clone.GetComponent<InputItem>().SetInput(n.itemLabel);
            }
    }
}