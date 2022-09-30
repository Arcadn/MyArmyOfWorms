using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MindScript : MonoBehaviour
{
    //Following is Camera
    public GameObject[] Players;
    [SerializeField]
    public GameObject CurrentPlayer;
    private MindCameraScript mindCameraScript;

    void Start() // Start, overall camera, and then only click changes to worm clicked will be better. Change if u manage to
    {
        //Following is Camera Start
        for (int i = 1; i < Players.Length; i++)    //Changes to the player you click, only players in the player list. (AKA if I make another one of these, but for team B?
        {
            Players[i].GetComponent<ThirdPersonMovement>().enabled = false;
        }

        CurrentPlayer = Players[0];
        mindCameraScript = GetComponent<MindCameraScript>();    //Camera
    }


    public void ChangePlayer(GameObject player)     //Makes the movement script deactivate for previous player, and activate on new player (PlayerScript)
    {
        CurrentPlayer.GetComponent<ThirdPersonMovement>().enabled = false;
        CurrentPlayer = player;
        mindCameraScript.Focus(player.transform);   //Camera
    }

}