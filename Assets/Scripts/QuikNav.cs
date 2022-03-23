using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEditor.EditorTools;

public class QuikNav : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void NavtoInputScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}