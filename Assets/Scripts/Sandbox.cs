using UnityEngine;

public class Sandbox : MonoBehaviour
{
    [SerializeField] private GameObject wedge;
    void Start()
    {
        
    }

    public void ScaleLocally()
    {
        if (wedge != null)
        {
            wedge.transform.localScale = new Vector3(1.75f, 1f, 1.75f);
        }
    }

    public void ResetScale()
    {
        if (wedge != null)
        {
            wedge.transform.localScale = new Vector3(1f, 1f, 1f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}