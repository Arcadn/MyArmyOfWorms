using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.InputSystem;
using System;

public class CinemachineSwitcher : MonoBehaviour  //THIS IS THE SCRIPT THAT NEEDS CHANGING IF YOU WANT OVERALL CAMERA TO BE THE FIRST CAMREA, AND THEN WHEN U CLICK PLAYER IT GOES "OH, U WANT THIS PLAYER, NICE" !!!!
{
    [SerializeField] private CinemachineVirtualCamera vcam; //Overall
    [SerializeField] private CinemachineFreeLook fcam; //Player
    [SerializeField] private bool OverallCamera = true;

    void Start()
    {
      if(GetComponent<turnManager>().endTurn == true)    //turn end, when a players turn ends camera should be changed to over all camera. 
         {
             SwitchPriority();
         }
     }

     public void SwitchPriority()
     {
         if (OverallCamera)
         {
             vcam.Priority = 0;
             fcam.Priority = 1;
         }

         else
         {
             vcam.Priority = 1;
             fcam.Priority = 0;
         }

         OverallCamera = !OverallCamera;
    }
}
