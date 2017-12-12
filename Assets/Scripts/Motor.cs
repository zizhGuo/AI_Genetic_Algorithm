using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motor : MonoBehaviour
{
    public GameObject mainCam;
    public GameObject[] ship;
    public GameObject ship0;
    public GameObject ship1;
    public GameObject ship2;
    public GameObject ship3;
    public GameObject ship4;
    public GameObject ship5;
    public GameObject ship6;
    public GameObject ship7;
    public GameObject ship8;
    public GameObject ship9;

    public float speed;

    private GeneLib genlibScript;
    private Vector3 dir;

    void Start()
    {
        genlibScript = mainCam.GetComponent<GeneLib>();
        ship = new GameObject[10];
        ship[0] = ship0;
        ship[1] = ship1;
        ship[2] = ship2;
        ship[3] = ship3;
        ship[4] = ship4;
        ship[5] = ship5;
        ship[6] = ship6;
        ship[7] = ship7;
        ship[8] = ship8;
        ship[9] = ship9;
        speed = 10f;
    }

    void Update()
    {
        #region Test Run Method
        //if (ship0.transform.position.y < 20)
        //{
        //    dir = genlibScript.chromosomes[0][0] - ship0.transform.position;
        //    ship0.transform.position = new Vector3(ship0.transform.position.x + Vector3.Normalize(dir).x * Time.deltaTime * speed, ship0.transform.position.y+ Vector3.Normalize(dir).y * Time.deltaTime * speed, ship0.transform.position.z + Vector3.Normalize(dir).z * Time.deltaTime * speed);
        //    ship0.transform.rotation = Quaternion.Slerp(ship0.transform.rotation, Quaternion.LookRotation(-dir), 2f * Time.deltaTime);
        //    Debug.Log("dir = " + dir);
        //}
        //else if (ship0.transform.position.y >= 20 && ship0.transform.position.y < 40)
        //{
        //    dir = genlibScript.chromosomes[0][1] - ship0.transform.position;
        //    ship0.transform.position = new Vector3(ship0.transform.position.x + Vector3.Normalize(dir).x * Time.deltaTime * speed, ship0.transform.position.y + Vector3.Normalize(dir).y * Time.deltaTime * speed, ship0.transform.position.z + Vector3.Normalize(dir).z * Time.deltaTime* speed);
        //    ship0.transform.rotation = Quaternion.Slerp(ship0.transform.rotation, Quaternion.LookRotation(-dir), 2f * Time.deltaTime);
        //    Debug.Log("dir = " + dir);
        //}
        //else if (ship0.transform.position.y >= 40 && ship0.transform.position.y < 60)
        //{
        //    dir = genlibScript.chromosomes[0][2] - ship0.transform.position;
        //    ship0.transform.position = new Vector3(ship0.transform.position.x + Vector3.Normalize(dir).x * Time.deltaTime * speed, ship0.transform.position.y + Vector3.Normalize(dir).y * Time.deltaTime * speed, ship0.transform.position.z + Vector3.Normalize(dir).z * Time.deltaTime * speed);
        //    ship0.transform.rotation = Quaternion.Slerp(ship0.transform.rotation, Quaternion.LookRotation(-dir), 2f * Time.deltaTime);
        //    Debug.Log("dir = " + dir);
        //}
        //else if (ship0.transform.position.y >= 60 && ship0.transform.position.y < 80)
        //{
        //    dir = genlibScript.chromosomes[0][3] - ship0.transform.position;
        //    ship0.transform.position = new Vector3(ship0.transform.position.x + Vector3.Normalize(dir).x * Time.deltaTime * speed, ship0.transform.position.y + Vector3.Normalize(dir).y * Time.deltaTime * speed, ship0.transform.position.z + Vector3.Normalize(dir).z * Time.deltaTime * speed);
        //    ship0.transform.rotation = Quaternion.Slerp(ship0.transform.rotation, Quaternion.LookRotation(-dir), 2f * Time.deltaTime);
        //    Debug.Log("dir = " + dir);
        //}
        //else if (ship0.transform.position.y >= 80 && ship0.transform.position.y < 100)
        //{
        //    dir = genlibScript.chromosomes[0][4] - ship0.transform.position;
        //    ship0.transform.position = new Vector3(ship0.transform.position.x + Vector3.Normalize(dir).x * Time.deltaTime * speed, ship0.transform.position.y + Vector3.Normalize(dir).y * Time.deltaTime * speed, ship0.transform.position.z + Vector3.Normalize(dir).z * Time.deltaTime * speed);
        //    ship0.transform.rotation = Quaternion.Slerp(ship0.transform.rotation, Quaternion.LookRotation(-dir), 2f * Time.deltaTime);
        //    Debug.Log("dir = " + dir);
        //}
        //else if (ship0.transform.position.y >= 100 && ship0.transform.position.y < 120)
        //{
        //    dir = genlibScript.chromosomes[0][5] - ship0.transform.position;
        //    ship0.transform.position = new Vector3(ship0.transform.position.x + Vector3.Normalize(dir).x * Time.deltaTime * speed, ship0.transform.position.y + Vector3.Normalize(dir).y * Time.deltaTime * speed, ship0.transform.position.z + Vector3.Normalize(dir).z * Time.deltaTime * speed);
        //    ship0.transform.rotation = Quaternion.Slerp(ship0.transform.rotation, Quaternion.LookRotation(-dir), 2f * Time.deltaTime);
        //    Debug.Log("dir = " + dir);
        //}
        //else if (ship0.transform.position.y >= 120 && ship0.transform.position.y < 140)
        //{
        //    dir = genlibScript.chromosomes[0][6] - ship0.transform.position;
        //    ship0.transform.position = new Vector3(ship0.transform.position.x + Vector3.Normalize(dir).x * Time.deltaTime * speed, ship0.transform.position.y + Vector3.Normalize(dir).y * Time.deltaTime * speed, ship0.transform.position.z + Vector3.Normalize(dir).z * Time.deltaTime * speed);
        //    ship0.transform.rotation = Quaternion.Slerp(ship0.transform.rotation, Quaternion.LookRotation(-dir), 2f * Time.deltaTime);
        //    Debug.Log("dir = " + dir);
        //}
        //else if (ship0.transform.position.y >= 140 && ship0.transform.position.y < 160)
        //{
        //    dir = genlibScript.chromosomes[0][7] - ship0.transform.position;
        //    ship0.transform.position = new Vector3(ship0.transform.position.x + Vector3.Normalize(dir).x * Time.deltaTime * speed, ship0.transform.position.y + Vector3.Normalize(dir).y * Time.deltaTime * speed, ship0.transform.position.z + Vector3.Normalize(dir).z * Time.deltaTime * speed);
        //    ship0.transform.rotation = Quaternion.Slerp(ship0.transform.rotation, Quaternion.LookRotation(-dir), 2f * Time.deltaTime);
        //    Debug.Log("dir = " + dir);
        //}
        //else if (ship0.transform.position.y >= 160 && ship0.transform.position.y < 180)
        //{
        //    dir = genlibScript.chromosomes[0][8] - ship0.transform.position;
        //    ship0.transform.position = new Vector3(ship0.transform.position.x + Vector3.Normalize(dir).x * Time.deltaTime * speed, ship0.transform.position.y + Vector3.Normalize(dir).y * Time.deltaTime * speed, ship0.transform.position.z + Vector3.Normalize(dir).z * Time.deltaTime * speed);
        //    ship0.transform.rotation = Quaternion.Slerp(ship0.transform.rotation, Quaternion.LookRotation(-dir), 2f * Time.deltaTime);
        //    Debug.Log("dir = " + dir);
        //}
        //else if (ship0.transform.position.y >= 180 && ship0.transform.position.y < 200)
        //{
        //    dir = genlibScript.chromosomes[0][9] - ship0.transform.position;
        //    ship0.transform.position = new Vector3(ship0.transform.position.x + Vector3.Normalize(dir).x * Time.deltaTime * speed, ship0.transform.position.y + Vector3.Normalize(dir).y * Time.deltaTime * speed, ship0.transform.position.z + Vector3.Normalize(dir).z * Time.deltaTime * speed);
        //    ship0.transform.rotation = Quaternion.Slerp(ship0.transform.rotation, Quaternion.LookRotation(-dir), 2f * Time.deltaTime);
        //    Debug.Log("dir = " + dir);
        //}
        #endregion
        //for (int i = 0; i < 10; i++)
        //{
        //    Run(i, ship[i]);
        //}
        //Run(0, ship[0]);
        //Run(1, ship[1]);
        //Run(2, ship[2]);
        //Run(3, ship[3]);
        //Run(4, ship[4]);
        //Run(5, ship[5]);
        //Run(6, ship[6]);
        //Run(7, ship[7]);
        //Run(8, ship[8]);
        //Run(9, ship[9]);
    }

   public void Run(int i, GameObject gb)
    {
        if (gb.transform.position.y < 20)
        {
            dir = genlibScript.chromosomes[i][0] - gb.transform.position;
            float dist = Vector3.Distance(genlibScript.chromosomes[i][0], gb.transform.position);
            //gb.transform.position = new Vector3(gb.transform.position.x + Vector3.Normalize(dir).x * Time.deltaTime * xspeed, gb.transform.position.y + Vector3.Normalize(dir).y * Time.deltaTime * yspeed, gb.transform.position.z + Vector3.Normalize(dir).z * Time.deltaTime * zspeed);
            //gb.transform.Translate(Vector3.Normalize(dir) * (Vector3.Distance(genlibScript.chromosomes[i][0], gb.transform.position)) /100f);
            gb.transform.position = new Vector3(gb.transform.position.x + Vector3.Normalize(dir).x * Time.deltaTime * speed, gb.transform.position.y + Vector3.Normalize(dir).y * Time.deltaTime * speed, gb.transform.position.z + Vector3.Normalize(dir).z * Time.deltaTime * speed);
            gb.transform.rotation = Quaternion.Slerp(gb.transform.rotation, Quaternion.LookRotation(-dir), 2f * Time.deltaTime);
            //Debug.Log("dir = " + dir);
        }
        else if (gb.transform.position.y >= 19 && gb.transform.position.y < 39)
        {
            dir = genlibScript.chromosomes[i][1] - gb.transform.position;
            //gb.transform.Translate(Vector3.Normalize(dir) * (Vector3.Distance(genlibScript.chromosomes[i][1], gb.transform.position)) / 100f);
            gb.transform.position = new Vector3(gb.transform.position.x + Vector3.Normalize(dir).x * Time.deltaTime * speed, gb.transform.position.y + Vector3.Normalize(dir).y * Time.deltaTime * speed, gb.transform.position.z + Vector3.Normalize(dir).z * Time.deltaTime * speed);
            gb.transform.rotation = Quaternion.Slerp(gb.transform.rotation, Quaternion.LookRotation(-dir), 2f * Time.deltaTime);
            //Debug.Log("dir = " + dir);
        }
        else if (gb.transform.position.y >= 39 && gb.transform.position.y < 59)
        {
            dir = genlibScript.chromosomes[i][2] - gb.transform.position;
            gb.transform.position = new Vector3(gb.transform.position.x + Vector3.Normalize(dir).x * Time.deltaTime * speed, gb.transform.position.y + Vector3.Normalize(dir).y * Time.deltaTime * speed, gb.transform.position.z + Vector3.Normalize(dir).z * Time.deltaTime * speed);
            gb.transform.rotation = Quaternion.Slerp(gb.transform.rotation, Quaternion.LookRotation(-dir), 2f * Time.deltaTime);
            //Debug.Log("dir = " + dir);
        }
        else if (gb.transform.position.y >= 59 && gb.transform.position.y < 79)
        {
            dir = genlibScript.chromosomes[i][3] - gb.transform.position;
            gb.transform.position = new Vector3(gb.transform.position.x + Vector3.Normalize(dir).x * Time.deltaTime * speed, gb.transform.position.y + Vector3.Normalize(dir).y * Time.deltaTime * speed, gb.transform.position.z + Vector3.Normalize(dir).z * Time.deltaTime * speed);
            gb.transform.rotation = Quaternion.Slerp(gb.transform.rotation, Quaternion.LookRotation(-dir), 2f * Time.deltaTime);
            //Debug.Log("dir = " + dir);
        }
        else if (gb.transform.position.y >= 79 && gb.transform.position.y < 99)
        {
            dir = genlibScript.chromosomes[i][4] - gb.transform.position;
            gb.transform.position = new Vector3(gb.transform.position.x + Vector3.Normalize(dir).x * Time.deltaTime * speed, gb.transform.position.y + Vector3.Normalize(dir).y * Time.deltaTime * speed, gb.transform.position.z + Vector3.Normalize(dir).z * Time.deltaTime * speed);
            gb.transform.rotation = Quaternion.Slerp(gb.transform.rotation, Quaternion.LookRotation(-dir), 2f * Time.deltaTime);
            //Debug.Log("dir = " + dir);
        }
        else if (gb.transform.position.y >= 99 && gb.transform.position.y < 119)
        {
            dir = genlibScript.chromosomes[i][5] - gb.transform.position;
            gb.transform.position = new Vector3(gb.transform.position.x + Vector3.Normalize(dir).x * Time.deltaTime * speed, gb.transform.position.y + Vector3.Normalize(dir).y * Time.deltaTime * speed, gb.transform.position.z + Vector3.Normalize(dir).z * Time.deltaTime * speed);
            gb.transform.rotation = Quaternion.Slerp(gb.transform.rotation, Quaternion.LookRotation(-dir), 2f * Time.deltaTime);
           // Debug.Log("dir = " + dir);
        }
        else if (gb.transform.position.y >= 119 && gb.transform.position.y < 139)
        {
            dir = genlibScript.chromosomes[i][6] - gb.transform.position;
            gb.transform.position = new Vector3(gb.transform.position.x + Vector3.Normalize(dir).x * Time.deltaTime * speed, gb.transform.position.y + Vector3.Normalize(dir).y * Time.deltaTime * speed, gb.transform.position.z + Vector3.Normalize(dir).z * Time.deltaTime * speed);
            gb.transform.rotation = Quaternion.Slerp(gb.transform.rotation, Quaternion.LookRotation(-dir), 2f * Time.deltaTime);
            //Debug.Log("dir = " + dir);
        }
        else if (gb.transform.position.y >= 139 && gb.transform.position.y < 159)
        {
            dir = genlibScript.chromosomes[i][7] - gb.transform.position;
            gb.transform.position = new Vector3(gb.transform.position.x + Vector3.Normalize(dir).x * Time.deltaTime * speed, gb.transform.position.y + Vector3.Normalize(dir).y * Time.deltaTime * speed, gb.transform.position.z + Vector3.Normalize(dir).z * Time.deltaTime * speed);
            gb.transform.rotation = Quaternion.Slerp(gb.transform.rotation, Quaternion.LookRotation(-dir), 2f * Time.deltaTime);
            //Debug.Log("dir = " + dir);
        }
        else if (gb.transform.position.y >= 159 && gb.transform.position.y < 179)
        {
            dir = genlibScript.chromosomes[i][8] - gb.transform.position;
            gb.transform.position = new Vector3(gb.transform.position.x + Vector3.Normalize(dir).x * Time.deltaTime * speed, gb.transform.position.y + Vector3.Normalize(dir).y * Time.deltaTime * speed, gb.transform.position.z + Vector3.Normalize(dir).z * Time.deltaTime * speed);
            gb.transform.rotation = Quaternion.Slerp(gb.transform.rotation, Quaternion.LookRotation(-dir), 2f * Time.deltaTime);
            //Debug.Log("dir = " + dir);
        }
        else if (gb.transform.position.y >= 179 && gb.transform.position.y < 199)
        {
            dir = genlibScript.chromosomes[i][9] - gb.transform.position;
            gb.transform.position = new Vector3(gb.transform.position.x + Vector3.Normalize(dir).x * Time.deltaTime * speed, gb.transform.position.y + Vector3.Normalize(dir).y * Time.deltaTime * speed, gb.transform.position.z + Vector3.Normalize(dir).z * Time.deltaTime * speed);
            gb.transform.rotation = Quaternion.Slerp(gb.transform.rotation, Quaternion.LookRotation(-dir), 2f * Time.deltaTime);
            //Debug.Log("dir = " + dir);
        }
    }
    
}
