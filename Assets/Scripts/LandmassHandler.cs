using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LandmassHandler : MonoBehaviour
{
    [SerializeField] private float rotationRate;
    private GameObject m_LandMass;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(transform.position, transform.up * -1f, Time.deltaTime * rotationRate);
    }
}