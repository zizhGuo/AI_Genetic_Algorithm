using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeScale : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.A))
        {
            Time.timeScale = 2.0f;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Time.timeScale = 10f;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Time.timeScale = 20.0f;
        }
    }
}
