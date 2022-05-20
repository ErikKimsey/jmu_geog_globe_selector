using UnityEngine;

public class Navigation : MonoBehaviour
{
    [SerializeField] private string[] scenes;
    void Start()
    {
        
    }

    public void LoadActivity()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(scenes[1]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}