using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LandmassHandler : MonoBehaviour
{
    [SerializeField] private float rotationRate;
    private Vector3 m_TransformUp;

    void Start()
    {
        m_TransformUp = transform.up * -1f;
    }

    void Update()
    {
        transform.RotateAround(transform.position, m_TransformUp, Time.deltaTime * rotationRate);
    }
}