using UnityEngine;
using UnityEngine.UI;

public class TextInputManager : MonoBehaviour
{
    private InputField m_InputField;
    private static string inputText;

    private void Start()
    {
        m_InputField = GetComponent<InputField>();
    }

    public void SetInput()
    {
        inputText = m_InputField.text;
    }

    public string GetInput()
    {
        return inputText;
    }

    void ClearInput()
    {

    }
}