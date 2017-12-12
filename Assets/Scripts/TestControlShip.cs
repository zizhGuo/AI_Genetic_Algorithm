using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestControlShip : MonoBehaviour
{
    private float currentTime;
    private Quaternion rotation;
    public GameObject target;

    void Start()
    {
        //currentTime = Time.time;
        rotation = transform.transform.rotation;
    }

    void Update()
    {
        //if (Time.time - currentTime > 3)
        //{
        //    transform.rotation = Quaternion.Inverse(transform.rotation);
        //    currentTime = Time.time;    
        //}

        Vector3 relativePos = transform.position-target.transform.position;
        Quaternion rotation = Quaternion.LookRotation(relativePos);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * 10);


    }
}
