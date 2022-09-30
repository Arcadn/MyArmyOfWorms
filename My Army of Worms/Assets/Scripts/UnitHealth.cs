using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitHealth 
{

    public int currentHealth;
    public int currentMaxHealth;

    public int Health       //call this when wanting health

    {
        get { return currentHealth; }
        set { currentHealth = value; }
    }

   public int MaxHealth
    {
        get { return currentMaxHealth; }
        set { currentMaxHealth = value; }
    }

   public UnitHealth(int health, int maxHealth)
    {
        currentHealth = health;
        currentMaxHealth = maxHealth;
    }

    // Damage

    public void dmgUnit(int dmgAmount)
    {
        if(currentHealth > 0)
        {
            currentHealth -= dmgAmount;
        }
    }

    //healing 
    public void healUnit(int healAmount)
    {
        if (currentHealth > currentMaxHealth)
        {
            currentHealth += healAmount;
        }
        if(currentHealth > currentMaxHealth)
        {
            currentHealth = currentMaxHealth;
        }
    }
}
