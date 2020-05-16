using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colliding : MonoBehaviour
{
    public GameObject sp;
    public GameObject explosion;
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Sphere")
        {
            //Debug.Log("Collision Happened");
            Instantiate(explosion, transform.position, transform.rotation);
        }
    }
}
