using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerTurn : MonoBehaviour
{
    private int playerIndex;

    public void SetPlayerTurn(int index)
    {
        playerIndex = index;
    }

    public bool IsPlayerTurn()
    {
        return turnManager.GetInstance().IsItPlayerTurn(playerIndex);
    }
}