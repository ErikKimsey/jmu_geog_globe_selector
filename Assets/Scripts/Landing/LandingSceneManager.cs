using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class LandingSceneManager : MonoBehaviour
{

    [SerializeField] private float m_FadeDuration;
    [SerializeField] private Image m_FadePanel;

    private float m_AlphaVal = 0f;
    void Start()
    {
        
    }


    void Update()
    {
        
    }

    IEnumerator FadeScene()
    {
        float _currTime = 0f;
        float _alpha = m_FadePanel.color.a;
        while (_currTime < m_FadeDuration)
        {
            _alpha = Mathf.Lerp(0f, 1, _currTime / m_FadeDuration);
            m_
            _currTime += Time.deltaTime;
            yield return null;
        }
    }

    IEnumerator NavigateTo()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
        yield return new WaitForSeconds(1f);
    }

    public void NavigateToInputScene()
    {

    }
}