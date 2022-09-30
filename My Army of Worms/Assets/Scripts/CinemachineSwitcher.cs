using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.InputSystem;
using System;

public class CinemachineSwitcher : MonoBehaviour  //THIS IS THE SCRIPT THAT NEEDS CHANGING IF YOU WANT OVERALL CAMERA TO BE THE FIRST CAMREA, AND THEN WHEN U CLICK PLAYER IT GOES "OH, U WANT THIS PLAYER, NICE" !!!!
{
    private CinemachineVirtualCamera vcam1; //overall
    [SerializeField]

    private CinemachineVirtualCamera vcam2; //Player
    [SerializeField]

    private bool OverallCamera = true;

    void Start()
    {
        // action.performed += _ => SwitchPriority();
    }

    private void SwitchPriority()
    {
        if (OverallCamera)
        {
            vcam1.Priority = 0;
            vcam2.Priority = 1;
        }

        else
        {
            vcam1.Priority = 1;
            vcam2.Priority = 0;
        }

        OverallCamera = !OverallCamera;
    }
}
