using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class CameraBlend : MonoBehaviour
{
    [SerializeField] private InputAction action;
    private Animator animator;
    private bool inputCamera = true;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        action.Enable();
    }

    private void OnDisable()
    {
        action.Disable();
    }

    void Start()
    {
        action.performed += _ => SwitchState();
    }

    void SwitchState()
    {
        if(inputCamera)
        {
            animator.Play("VCamInput");
        }
        else
        {
            animator.Play("VcamSelection");
        }

        inputCamera = !inputCamera;
    }
}