using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatesController : MonoBehaviour
{
    public CollisionTest[] shipScripts;

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

    [SerializeField]
    State_Type currentState;

    void Start()
    {
        shipScripts = new CollisionTest[10];
        shipScripts[0] = ship0.GetComponent<CollisionTest>();
        shipScripts[1] = ship1.GetComponent<CollisionTest>();
        shipScripts[2] = ship2.GetComponent<CollisionTest>();
        shipScripts[3] = ship3.GetComponent<CollisionTest>();
        shipScripts[4] = ship4.GetComponent<CollisionTest>();
        shipScripts[5] = ship5.GetComponent<CollisionTest>();
        shipScripts[6] = ship6.GetComponent<CollisionTest>();
        shipScripts[7] = ship7.GetComponent<CollisionTest>();
        shipScripts[8] = ship8.GetComponent<CollisionTest>();
        shipScripts[9] = ship9.GetComponent<CollisionTest>();

        currentState = State_Type.Simulation;
    }
    enum State_Type
    {
        Simulation,
        Iteration,
    }

    int States(CollisionTest[] Ob)
    {
        int i = Ob[0].alive + Ob[1].alive + Ob[2].alive + Ob[3].alive + Ob[4].alive + Ob[5].alive + Ob[6].alive + Ob[7].alive + Ob[8].alive + Ob[9].alive;
        return i;
    }
    void Update()
    {
        if (States(shipScripts) == 10) currentState = State_Type.Iteration;
        else currentState = State_Type.Simulation;

        switch (currentState)
        {
            case State_Type.Simulation:
                Debug.Log("Simulation!!!!!!!!!!");

                break;
            case State_Type.Iteration:
                Debug.Log("Iteration!!!!!!!!!!!");

                break;
        }

    }
}
