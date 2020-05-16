using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Targest : MonoBehaviour
{
    public GameObject[] Target;
    int Current = 0;
    int Prev = 0;
    float RotSpeed;
    public float Speed;
    float change = 1;


    private void Update()
    {
        if(Vector3.Distance(Target[Current].transform.position,transform.position) < change)
        {
            Current = Random.Range(0, 10);
            if (Current == Prev)
            {
                TryAgain();
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, Target[Current].transform.position, Time.deltaTime * Speed);
        Prev = Current;
    }
    void TryAgain()
    {
        if (Prev == 0)
        {
            Current = Prev + 1;
        }

        else if (Prev > 0)
        {
            Current = Prev - 1;
        }
    }
}
