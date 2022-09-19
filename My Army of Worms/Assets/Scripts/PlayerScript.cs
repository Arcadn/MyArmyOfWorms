using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    public MindScript mind; //Calls MindScript
    

    void OnMouseDown() //Adds Movement script on current player
    {
        mind.ChangePlayer(this.gameObject);
        GetComponent<ThirdPersonMovement>().enabled = true;
    }
}
