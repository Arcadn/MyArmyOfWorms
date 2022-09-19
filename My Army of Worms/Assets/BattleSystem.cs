using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;

public enum BattleState { START, PLAYERTURN, ENEMYTURN, WON, LOST }

public class BattleSystem : MonoBehaviour
{
    public GameObject playerPrefab; //arrays of players needed
    public GameObject enemyPrefab;

    public Transform playerBattlestation; // spawn areas rather than stations 
    public Transform enemyBattleStation;
    public BattleState state;
    void Start()
    {
        state = BattleState.START;
        SetupBattle();
    }

    void SetupBattle()
    {
        Instantiate(playerPrefab, playerBattlestation);
        Instantiate(enemyBattleStation, enemyBattleStation);
    }
    
}
