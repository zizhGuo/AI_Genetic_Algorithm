using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathIndicator : MonoBehaviour
{
    public GameObject cubesPooler1;
    public GameObject cubesPooler2;
    public GameObject cubesPooler3;
    public GameObject cubesPooler4;
    public GameObject cubesPooler5;
    public GameObject cubesPooler6;
    public GameObject cubesPooler7;
    public GameObject cubesPooler8;
    public GameObject cubesPooler9;
    public GameObject cubesPooler0;
    public GameObject maincam;

    private NewObjectPoolerScript cubesScript1;
    private NewObjectPoolerScript cubesScript2;
    private NewObjectPoolerScript cubesScript3;
    private NewObjectPoolerScript cubesScript4;
    private NewObjectPoolerScript cubesScript5;
    private NewObjectPoolerScript cubesScript6;
    private NewObjectPoolerScript cubesScript7;
    private NewObjectPoolerScript cubesScript8;
    private NewObjectPoolerScript cubesScript9;
    private NewObjectPoolerScript cubesScript0;
    private GeneLib genelib;

    void Start()
    {
        cubesScript0 = cubesPooler0.GetComponent<NewObjectPoolerScript>();
        cubesScript1 = cubesPooler1.GetComponent<NewObjectPoolerScript>();
        cubesScript2 = cubesPooler2.GetComponent<NewObjectPoolerScript>();
        cubesScript3 = cubesPooler3.GetComponent<NewObjectPoolerScript>();
        cubesScript4 = cubesPooler4.GetComponent<NewObjectPoolerScript>();
        cubesScript5 = cubesPooler5.GetComponent<NewObjectPoolerScript>();
        cubesScript6 = cubesPooler6.GetComponent<NewObjectPoolerScript>();
        cubesScript7 = cubesPooler7.GetComponent<NewObjectPoolerScript>();
        cubesScript8 = cubesPooler8.GetComponent<NewObjectPoolerScript>();
        cubesScript9 = cubesPooler9.GetComponent<NewObjectPoolerScript>();
        genelib = maincam.GetComponent<GeneLib>();

        for (int i = 0; i < cubesScript0.pooledAmount; i++)
        {
            if (!cubesScript0.pooledObjects[i].activeInHierarchy)
            {
                cubesScript0.pooledObjects[i].transform.position = genelib.chromosomes[0][i]; // hit.transform.position;
                cubesScript0.pooledObjects[i].SetActive(true);
                break;
            }
            if (cubesScript0.pooledObjects[i] == null) return;
        }
        for (int i = 0; i < cubesScript1.pooledAmount; i++)
        {
            if (!cubesScript1.pooledObjects[i].activeInHierarchy)
            {
                cubesScript1.pooledObjects[i].transform.position = genelib.chromosomes[1][i]; // hit.transform.position;
                cubesScript1.pooledObjects[i].SetActive(true);
                break;
            }
            if (cubesScript1.pooledObjects[i] == null) return;
        }
        for (int i = 0; i < cubesScript2.pooledAmount; i++)
        {
            if (!cubesScript2.pooledObjects[i].activeInHierarchy)
            {
                cubesScript2.pooledObjects[i].transform.position = genelib.chromosomes[2][i]; // hit.transform.position;
                cubesScript2.pooledObjects[i].SetActive(true);
                break;
            }
            if (cubesScript2.pooledObjects[i] == null) return;
        }
        for (int i = 0; i < cubesScript3.pooledAmount; i++)
        {
            if (!cubesScript3.pooledObjects[i].activeInHierarchy)
            {
                cubesScript3.pooledObjects[i].transform.position = genelib.chromosomes[3][i]; // hit.transform.position;
                cubesScript3.pooledObjects[i].SetActive(true);
                break;
            }
            if (cubesScript3.pooledObjects[i] == null) return;
        }
        for (int i = 0; i < cubesScript4.pooledAmount; i++)
        {
            if (!cubesScript4.pooledObjects[i].activeInHierarchy)
            {
                cubesScript4.pooledObjects[i].transform.position = genelib.chromosomes[4][i]; // hit.transform.position;
                cubesScript4.pooledObjects[i].SetActive(true);
                break;
            }
            if (cubesScript4.pooledObjects[i] == null) return;
        }
        for (int i = 0; i < cubesScript5.pooledAmount; i++)
        {
            if (!cubesScript5.pooledObjects[i].activeInHierarchy)
            {
                cubesScript5.pooledObjects[i].transform.position = genelib.chromosomes[5][i]; // hit.transform.position;
                cubesScript5.pooledObjects[i].SetActive(true);
                break;
            }
            if (cubesScript5.pooledObjects[i] == null) return;
        }
        for (int i = 0; i < cubesScript6.pooledAmount; i++)
        {
            if (!cubesScript6.pooledObjects[i].activeInHierarchy)
            {
                cubesScript6.pooledObjects[i].transform.position = genelib.chromosomes[6][i]; // hit.transform.position;
                cubesScript6.pooledObjects[i].SetActive(true);
                break;
            }
            if (cubesScript6.pooledObjects[i] == null) return;
        }
        for (int i = 0; i < cubesScript7.pooledAmount; i++)
        {
            if (!cubesScript7.pooledObjects[i].activeInHierarchy)
            {
                cubesScript7.pooledObjects[i].transform.position = genelib.chromosomes[7][i]; // hit.transform.position;
                cubesScript7.pooledObjects[i].SetActive(true);
                break;
            }
            if (cubesScript7.pooledObjects[i] == null) return;
        }
        for (int i = 0; i < cubesScript8.pooledAmount; i++)
        {
            if (!cubesScript8.pooledObjects[i].activeInHierarchy)
            {
                cubesScript8.pooledObjects[i].transform.position = genelib.chromosomes[8][i]; // hit.transform.position;
                cubesScript8.pooledObjects[i].SetActive(true);
                break;
            }
            if (cubesScript8.pooledObjects[i] == null) return;
        }
        for (int i = 0; i < cubesScript9.pooledAmount; i++)
        {
            if (!cubesScript9.pooledObjects[i].activeInHierarchy)
            {
                cubesScript9.pooledObjects[i].transform.position = genelib.chromosomes[9][i]; // hit.transform.position;
                cubesScript9.pooledObjects[i].SetActive(true);
                break;
            }
            if (cubesScript9.pooledObjects[i] == null) return;
        }
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {

        }
    }
}
