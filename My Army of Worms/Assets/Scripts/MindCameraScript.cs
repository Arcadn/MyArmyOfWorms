using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class MindCameraScript : MonoBehaviour
{
    public MindScript mind; //Calls MindScript

    public CinemachineFreeLook vcam;


    
    public void Focus(Transform target)  //Can change to right click, and then only changes to first person when shooting. This way I do not have to script character rotarion. (:smirk:) ( Don't fuck with the script too much tho :d )
    {
        vcam.Follow = target;
        vcam.LookAt = target;

        Debug.Log(mind.CurrentPlayer.transform.name);
    }

}

