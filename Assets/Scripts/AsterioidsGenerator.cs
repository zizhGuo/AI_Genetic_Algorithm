using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AsterioidsGenerator : MonoBehaviour
{
    private List<GameObject> asteriods;
    private float num;
    public GameObject asteriod1;
    public GameObject asteriod2;
    public GameObject asteriod3;
    public GameObject spaceship;
    public System.Random r;

    void Start()
    {
        asteriods = new List<GameObject>();
        asteriods.Add(asteriod1);
        asteriods.Add(asteriod2);
        asteriods.Add(asteriod3);
        r = new System.Random((int)DateTime.Now.Ticks % int.MaxValue);

        int x = 0;
        do
        {
            GameObject obj = (GameObject)Instantiate(spaceship);
            obj.transform.position = new Vector3(0, 0, 0);
            x++;
        } while (x < 1);
        for (float i = 15; i < 200; i += 20)
        {
            for (float j = 0; j < 100; j += 15)
            {
                for (float k = 0; k < 100; k += 15)
                {
                    num = r.Next(0, 3);
                    if (num < 1) num = 0;
                    else if (num < 2) num = 1;
                    else num = 2;
                    GameObject obj = (GameObject)Instantiate(asteriods[(int)num]);
                    obj.transform.position = new Vector3(j + 1, i, k + 1);

                }
            }
        }
    }

    void Update()
    {

    }
}
