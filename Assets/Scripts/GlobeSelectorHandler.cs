using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobeSelectorHandler : MonoBehaviour
{
    // [SerializeField] private GameObject m_WedgePrefab;
    // [SerializeField] private int totalWedgeCount = 6;
    [SerializeField] private float m_RotationRate;
    // [SerializeField] private Material[] m_Materials;
    // [SerializeField] private Color m_SelectedColor;
    private Rigidbody m_Rigidbody;
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    void RotateSphere()
    {
        m_Rigidbody.AddTorque(0f, -m_RotationRate, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            RotateSphere();
        }
        if (Input.touchCount > 0)
        {
            Touch m_touch = Input.GetTouch(0);
            if (m_touch.phase == TouchPhase.Began)
            {
                RotateSphere();
            }

        }

    }
}