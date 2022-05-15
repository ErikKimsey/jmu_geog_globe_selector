using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityTemplateProjects;

public class GameManager : MonoBehaviour
{
    private List<ActivityItem> m_ActivityItems;
    private GameObject m_Canvas;
    [SerializeField] private InputDisplay m_InputDisplay;
    [SerializeField] private InputManager m_InputManager;
    [SerializeField] private ActivityOption m_ActivityOption;
    private DataManager m_DataManager;
    public ActivityManagement m_ActivityManagement;

    public static GameManager Instance;
    private void Awake()
    {

            if (Instance != null && Instance != this)
            {
                Destroy(this);
            }
            else
            {
                Instance = this;
            }
        
    }

    private void Start()
    {
        m_ActivityManagement =
            (ActivityManagement)ScriptableObject
                .CreateInstance<ActivityManagement>();
    }

    public void AddInput()
    {
        m_InputManager.AddInput();
        m_Canvas = GameObject.Find("Input UI");
    }

    public void SubmitItems()
    {
        m_ActivityItems = m_InputManager.GetItems();
        if (m_ActivityItems.Count > 0)
        {
            DataManager.instance.WriteFile(m_ActivityItems);

            if (m_Canvas && m_Canvas.activeSelf &&
                GameObject.Find("EventSystem") &&
                GameObject.Find("EventSystem").activeSelf)
            {
                m_Canvas.SetActive(false);
                GameObject.Find("EventSystem").SetActive(false);
            }

            UnityEngine.SceneManagement.SceneManager.LoadScene(1);
        }
    }

    public List<ActivityItem> GetItems()
    {
        return m_DataManager.ReadFile();
    }
}