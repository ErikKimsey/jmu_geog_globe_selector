using System;
using System.Collections.Generic;
using UnityEngine;


public static class JsonHelper
{
    public static List<T> FromJson<T>(string json)
    {
        Wrapper<T> wrapper = JsonUtility.FromJson<Wrapper<T>>(json);
        return wrapper.Items;
    }

    public static string ToJson<T>(List<T> _list)
    {
        Wrapper<T> wrapper = new Wrapper<T>();
        wrapper.Items = _list;
        return JsonUtility.ToJson(wrapper);
    }

    public static string ToJson<T>(List<T> _list, bool prettyPrint)
    {
        Wrapper<T> wrapper = new Wrapper<T>();
        wrapper.Items = _list;
        return JsonUtility.ToJson(wrapper, prettyPrint);
    }

    [Serializable]
    private class Wrapper<T>
    {
        public List<T> Items;
    }
}