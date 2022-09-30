using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;

public class turnManager : MonoBehaviour
{
    private static turnManager instance;
    [SerializeField] private playerTurn playerOne;
    [SerializeField] private playerTurn playerTwo;
    [SerializeField] private float timeBetweenTurns; //Dont need time between , I need when mousebtn clicked (aka character chosen)

    private int currentPlayerIndex;
    private bool waitingForNextTurn;                //this is therefore not needed ^ ?
    private float turnDelay;                        // movement shalt be time based, but then action points on shooting
    public bool endTurn;
    public GameObject cinemaGO;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            currentPlayerIndex = 1;
            playerOne.SetPlayerTurn(1);
            playerTwo.SetPlayerTurn(2);
        }
    }

    private void Update()
    {
        if (waitingForNextTurn)
        {
            turnDelay += Time.deltaTime;
            if (turnDelay >= timeBetweenTurns)
            {
                turnDelay = 0;
                waitingForNextTurn = false;
                ChangeTurn();
            }
        }
    }

    public bool IsItPlayerTurn(int index) //checks if it's player turn
    {
        if (waitingForNextTurn)
        {
            return false;
        }

        return index == currentPlayerIndex;
    }

    public static turnManager GetInstance()
    {
        return instance;
    }

    public void TriggerChangeTurn()
    {
        waitingForNextTurn = true;
    }

    private void ChangeTurn()
    {
        if (currentPlayerIndex == 1)
        {
            endTurn = true;
            cinemaGO.GetComponent<CinemachineSwitcher>().SwitchPriority();
            currentPlayerIndex = 2;
        }
        else if (currentPlayerIndex == 2)
        {
            endTurn = true;
            cinemaGO.GetComponent<CinemachineSwitcher>().SwitchPriority();
            currentPlayerIndex = 1;
        }
    }
}
