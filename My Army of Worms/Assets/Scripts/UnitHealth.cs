using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitHealth : MonoBehaviour
{

    public int currentHealth;
    public int currentMaxHealth = 20;

   void Start()
    {
        currentHealth = currentMaxHealth;
    }

    void Update()
    {
        if(currentHealth > currentMaxHealth)
        {
            currentHealth = currentMaxHealth;
        }

        if (currentHealth == 0)
        {
            Destroy(this.gameObject);
        }
    }
}
