using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSceneManager : MonoBehaviour
{
    [Header("Script references")]
    [SerializeField] private LandmassNormals m_LandmassNormals;
    [SerializeField] private GameObject m_ListItemPrefab;
    [SerializeField] private DataManager m_DataManager;

    private InputManager m_InputManager;
    private List<ActivityItem> m_ActivityItems;


    void Start()
    {
        m_ActivityItems = new List<ActivityItem>();
        m_ActivityItems = m_DataManager.CreateFakeData();

       if(m_ActivityItems.Count > 0)
        {
            StartCoroutine(InstantiateIndicators());
        }
    }

    IEnumerator InstantiateIndicators()
    {
        yield return new WaitForSeconds(1);
        m_LandmassNormals.CreatePrimitives(m_ActivityItems);
    }
}