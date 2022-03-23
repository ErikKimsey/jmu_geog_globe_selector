using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    [SerializeField] private ActivityItem m_Item;

    private List<ActivityItem> _actItemsList;
    private string dataFile;
    private string fileContents;

    //
    public static DataManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    private void Start()
    {
        _actItemsList = new List<ActivityItem>();
        dataFile = Application.streamingAssetsPath + "/activtydata.json";
    }


    public List<ActivityItem> ReadFile()
    {
        List<ActivityItem> items = new List<ActivityItem>();

        if (File.Exists(dataFile))
        {
            fileContents = File.ReadAllText(dataFile);
            items = JsonHelper.FromJson<ActivityItem>(fileContents);
        }

        return items;
    }


    public void WriteFile(List<ActivityItem> list)
    {
        if (list.Count > 0)
        {
            var jsonString = JsonHelper.ToJson(list);
            File.WriteAllText(dataFile, jsonString);
        }
    }

    public List<ActivityItem> CreateFakeData()
    {
        for (int i = 0; i < 10; i++)
        {
            ActivityItem _item = new ActivityItem();
            _item.index = i;
            _item.itemLabel =
                "Messenger bag chartreuse art party cred street art photo booth.";
            _actItemsList.Add(_item);
        }

        return _actItemsList;
    }
}