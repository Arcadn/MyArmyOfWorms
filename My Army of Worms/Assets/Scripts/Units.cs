/*using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Units : MonoBehaviour
{
    public string unitName;
    public UnitHealth unitHealth;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            PlayerTakesDamage(20);
            Debug.Log(unitHealth.currentHealth.Health);

        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            PlayerTakesDamage(10);
            Debug.Log(unitHealth.currentHealth.Health);

        }
    }

    private void PlayerTakesDamage(int dmg)
    {
        unitHealth.currentHealth.dmgUnit(dmg);
    }

    private void Playerheals(int heal)
    {
        unitHealth.currentHealth.healUnit(heal);
    }
}
*/