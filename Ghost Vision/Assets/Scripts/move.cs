using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    Vector3 position;
    public float Speed;

    void Start()
    {
        position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        position.x += Input.GetAxis("Horizontal") * Speed * Time.deltaTime;
        position.z += Input.GetAxis("Vertical") * Speed * Time.deltaTime;
        
        position.x = Mathf.Clamp(position.x, -20.36f, 30.26f); //to limit the postion;

        transform.position = position;
    }
    public void incrSpeed()
    {
        Speed += 0.8f;
    }
}
