using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Units : MonoBehaviour
{
    public string unitName;

    public int healAmount = 10;
    public int damageAmount = 20;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))    //Change to bullet attacking
        {
            Damage();

        }
        if (Input.GetKeyDown(KeyCode.Q))    //Change to when pickup medkit
        {
            Healing();

        }
    }
    public void Damage()
    {
        gameObject.GetComponent<UnitHealth>().currentHealth -= damageAmount;
    }

    public void Healing()
    {
       gameObject.GetComponent<UnitHealth>().currentHealth += healAmount;
    }
}
