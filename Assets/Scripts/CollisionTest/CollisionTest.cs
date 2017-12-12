using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTest : MonoBehaviour
{
    private float startTime;
    private float endTime;
    public float duration;
    public int alive;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision != null && collision.gameObject.tag == "collsion")
        {
            gameObject.SetActive(false);
        }
    }
    private void FixedUpdate()
    {
        //transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + Time.deltaTime * 10);
        //transform.Translate(Vector3.up*Time.deltaTime);
    }
    private void OnEnable()
    {
        startTime = Time.time;
        //print("script was enabled");
        //print("startTime = " + startTime);
        alive = 0;
        print("Alive" + alive);
    }
    private void OnDisable()
    {
        endTime = Time.time;
        duration = endTime - startTime;
        //print("duration time: " + duration);
        //print("script was disabled");
        //print("endTime = " + endTime);
        alive = 1;
        print("Dead!" + alive);
    }


}
