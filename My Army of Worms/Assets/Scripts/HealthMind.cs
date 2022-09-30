/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthMind : MonoBehaviour
{
    //following is Health
    public static HealthMind healthMind { get; private set; }

    public UnitHealth PlayerHealth = new UnitHealth(100, 100);

    void awake()
    {
        if (healthMind != null && healthMind != this)
        {
            Destroy(this);
        }

        else
        {
            healthMind = this;
        }
    }
    
}
*/