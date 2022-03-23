using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InputItem : MonoBehaviour
{
    private string inputText;
    private Text m_TextComp;
    [SerializeField] private Text m_Text;

    private void Start()
    {

    }

    public void SetInput(string input)
    {
        if (String.IsNullOrEmpty(input) == false)
        {
            m_TextComp = Instantiate(m_Text, transform);
            m_TextComp.text = input;

        }
    }
}