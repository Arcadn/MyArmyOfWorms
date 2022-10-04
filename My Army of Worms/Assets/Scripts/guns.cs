using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guns : MonoBehaviour
{
    public int pelletCount;
    public float spreadAngle;
    public GameObject Pellet;
    public Transform GunEndPoint;
    public float pelletFireVelocity = 1;
    public List<Quaternion> pellets;



    void Awake()
    {
        pellets = new List<Quaternion>(pelletCount);
        for (int i = 0; i < pelletCount; i++)
        {
            pellets.Add(Quaternion.Euler(Vector3.zero));

        }
    }

    void Update()   //When pressing fire button, fire
    {
        if (Input.GetButtonDown("Fire1")) // Change to whatever controll is fire
        {
            fire();
        }
    }

    void fire()
    {
        for (int i = 0; i < pelletCount; i++) //Spread of gun . In following "pel" is pellet
        {
            pellets[i] = Random.rotation;
            GameObject pel = Instantiate(Pellet, GunEndPoint.position, GunEndPoint.rotation);
            pel.transform.rotation = Quaternion.RotateTowards(pel.transform.rotation, pellets[i], spreadAngle);
            pel.GetComponent<Rigidbody>().AddForce(pel.transform.right * pelletFireVelocity);
            i++;

            Destroy(pel, 0.5f);
        }
    }



}
