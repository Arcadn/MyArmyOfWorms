using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pellets : MonoBehaviour
{
    public float damage;

    private void OnCollisionEnter(Collision collision)
    {
        GameObject collisionGameObject = collision.gameObject;

        if (collisionGameObject.name != "Team1")
        {
            if (collisionGameObject.GetComponent<Units>() != null)
            {
                collisionGameObject.GetComponent<Units>().damageAmount(damage); //should say damage but doesn't work
            }
        }
    }
}
