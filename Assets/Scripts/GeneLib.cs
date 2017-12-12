using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GeneLib : MonoBehaviour
{
    [SerializeField]
    //private List<List<Vector3>> Individuals;
    private Dictionary<int, List<Vector3>> individuals;
    public List<Vector3>[] chromosomes;
    private List<GameObject> cubes;
    public CollisionTest[] shipScripts;
    public Motor motorScript;
    State_Type currentState;

    private System.Random rand;
    private System.Random rand1;
    private System.Random rand2;
    private System.Random rand3;
    System.Random r1;
    System.Random r2;

    public int amoutIndi;
    public GameObject Cube;
    public GameObject cube0;
    public GameObject cube1;
    public GameObject cube2;
    public GameObject cube3;
    public GameObject cube4;
    public GameObject cube5;
    public GameObject cube6;
    public GameObject cube7;
    public GameObject cube8;
    public GameObject cube9;

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

    bool selectFlag = true;
    bool stopFlag = true;

    bool resurFlag = false;
    bool reposFlag = false;
    bool selecFlag = false;
    bool crossFlag = false;
    bool mutatFlag = false;
    enum State_Type
    {
        Simulation,
        Iteration,
    }
    void Start()
    {
        amoutIndi = 10;
        chromosomes = new List<Vector3>[10];
        individuals = new Dictionary<int, List<Vector3>>();
        cubes = new List<GameObject>();
        currentState = State_Type.Simulation;

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

        motorScript = this.GetComponent<Motor>();
        rand = new System.Random((int)DateTime.Now.Ticks % int.MaxValue);

        r1 = new System.Random((int)DateTime.Now.Ticks % int.MaxValue);
        r2 = new System.Random((int)DateTime.Now.Ticks % int.MaxValue);

        rand1 = new System.Random((int)DateTime.Now.Ticks % int.MaxValue);
        rand2 = new System.Random((int)DateTime.Now.Ticks % int.MaxValue);
        rand3 = new System.Random((int)DateTime.Now.Ticks % int.MaxValue);
        #region Generate chromosome
        for (int i = 0; i < 10; i++)
        {
            List<Vector3> chroms = new List<Vector3>();
            for (int k = 1; k < 11; k++)
            {
                float x = (float)r1.NextDouble();
                float z = (float)r2.NextDouble();
                //Get random position at layer j (y = j)
                Vector3 pos = new Vector3(x * 100, k * 20, z * 100);
                //print("generate Pos = " + pos);
                chroms.Add(pos);
            }
            individuals.Add(i, chroms);
        }
        for (int j = 0; j < 10; j++)
        {
            foreach (List<Vector3> value in individuals.Values)
            {
                chromosomes[j] = value;
                j++;
            }
        }

        //for (int i = 0; i < 10; i++)
        //{
        //    for (int k = 0; k < 10; k++)
        //    {
        //        Debug.Log("Dictionary number: " + i + "  Chromosome number: " + k + " Vector:  " + chromosomes[i][k]);
        //    }
        //}
        #endregion

        #region Indication cubes
        //for (int i = 0; i < 10; i++)
        //{
        //    for (int k = 0; k < 10; k++)
        //    {
        //        if (i == 0)
        //        {
        //            GameObject obj = (GameObject)Instantiate(cube0);
        //            cubes.Add(obj);
        //            obj.transform.position = chromosomes[i][k];
        //        }
        //        else if (i == 1)
        //        {
        //            GameObject obj = (GameObject)Instantiate(cube1);
        //            cubes.Add(obj);
        //            obj.transform.position = chromosomes[i][k];
        //        }
        //        else if (i == 2)
        //        {
        //            GameObject obj = (GameObject)Instantiate(cube2);
        //            cubes.Add(obj);
        //            obj.transform.position = chromosomes[i][k];
        //        }
        //        else if (i == 3)
        //        {
        //            GameObject obj = (GameObject)Instantiate(cube3);
        //            cubes.Add(obj);
        //            obj.transform.position = chromosomes[i][k];
        //        }
        //        else if (i == 4)
        //        {
        //            GameObject obj = (GameObject)Instantiate(cube4);
        //            cubes.Add(obj);
        //            obj.transform.position = chromosomes[i][k];
        //        }
        //        else if (i == 5)
        //        {
        //            GameObject obj = (GameObject)Instantiate(cube5);
        //            cubes.Add(obj);
        //            obj.transform.position = chromosomes[i][k];
        //        }
        //        else if (i == 6)
        //        {
        //            GameObject obj = (GameObject)Instantiate(cube6);
        //            cubes.Add(obj);
        //            obj.transform.position = chromosomes[i][k];
        //        }
        //        else if (i == 7)
        //        {
        //            GameObject obj = (GameObject)Instantiate(cube7);
        //            cubes.Add(obj);
        //            obj.transform.position = chromosomes[i][k];
        //        }
        //        else if (i == 8)
        //        {
        //            GameObject obj = (GameObject)Instantiate(cube8);
        //            cubes.Add(obj);
        //            obj.transform.position = chromosomes[i][k];
        //        }
        //        else if (i == 9)
        //        {
        //            GameObject obj = (GameObject)Instantiate(cube9);
        //            cubes.Add(obj);
        //            obj.transform.position = chromosomes[i][k];
        //        }
        //    }
        //}
        #endregion
    }

    //CollisionTest[] Ob, CollisionTest Ob1, CollisionTest Ob2, CollisionTest Ob3, CollisionTest Ob4, CollisionTest Ob5, CollisionTest Ob6, CollisionTest Ob7, CollisionTest Ob8, CollisionTest Ob9)
    int States(CollisionTest[] Ob)
    {
        int i = Ob[0].alive + Ob[1].alive + Ob[2].alive + Ob[3].alive + Ob[4].alive + Ob[5].alive + Ob[6].alive + Ob[7].alive + Ob[8].alive + Ob[9].alive;
        return i;
    }
    List<Vector3>[] Selection(CollisionTest[] Ob, List<Vector3>[] Chrom, System.Random R)
    {
        float[] p = new float[10];
        float[] c = new float[10];
        float[] r = new float[10];
        List<Vector3>[] temp = new List<Vector3>[10];
        float totalTime = 0;
        //int k = 0;
        //System.Random R = new System.Random((int)DateTime.Now.Ticks % int.MaxValue);
        //float totaltime = Ob0.duration + Ob1.duration + Ob2.duration + Ob3.duration + Ob4.duration + Ob5.duration + Ob6.duration + Ob7.duration + Ob8.duration + Ob9.duration;

        for (int i = 0; i < 10; i++)
        {
            totalTime = totalTime + Ob[i].duration;
            //print("Total time: " + totalTime);  // Succeeded
        }
        for (int i = 0; i < 10; i++)
        {
            p[i] = Ob[i].duration / totalTime;
            //print("p[" + i + "] = " + p[i]);   // Succeeded
            if (i > 0) c[i] = c[i - 1] + p[i];
            else c[i] = p[i];
            //print("c[" + i + "] = " + c[i]);  // Succeeded
        }
        for (int i = 0; i < 10; i++)
        {
            r[i] = (float)R.NextDouble();
            //print("Random num = " + r[i]);
        }
        for (int i = 0; i < 10; i++)
        {
            bool flag = true;
            for (int j = 0; j < 10; j++)
            {
                if (r[i] - c[j] < 0 && flag)
                {
                    //print("Num: " + i + "   Choose chrom0 " + j);
                    temp[i] = Chrom[j];
                    flag = false;
                }
                //else print("!!!:   "+ i );
            }
        }
        for (int i = 0; i < 10; i++)
        {
            Chrom[i] = temp[i];
        }
        //while (k < 10)
        //{
        //r[k] = (float)R.NextDouble();
        //    if ()
        //}
        print("Selection Done!");
        return Chrom;
    }

    List<Vector3>[] Crossover2(List<Vector3>[] Chrom, System.Random R)
    {
        float[] r = new float[10];
        float pc = 0.5f;
        int chosenNum = 0; ;
        List<Vector3>[] chosenChroms = new List<Vector3>[10];
        List<Vector3>[] newChroms = new List<Vector3>[10];
        List<int> chosenIndex = new List<int>();
        //List<Vector3>[] cutoffChrom = new List<Vector3>[10];
        Vector3[][] cutoffChrom = new Vector3[10][];
        Vector3[][] keptChrom = new Vector3[10][];

        //Vector3[] chosenChroms0 = new Vector3[10];
        List<Vector3> chosenChroms0 = new List<Vector3>();
        int C0 = 0;

        for (int i = 0; i < 10; i++)
        {
            newChroms[i] = new List<Vector3>();
        }

        for (int i = 0; i < 10; i++)
        {
            cutoffChrom[i] = new Vector3[10];
        }
        for (int i = 0; i < 10; i++)
        {
            keptChrom[i] = new Vector3[10];
        }
        int[] C = new int[10];

        ///<summary>
        ///Create a array of r select // Choose where to cut off the chromosome
        /// </summary>
        for (int i = 0; i < 10; i++)  
        {
            r[i] = (float)R.NextDouble();
            if (r[i] < pc)
            {
                chosenIndex.Add(i);
                chosenChroms[chosenNum] = Chrom[i];
                chosenNum++;
            }
        }
        #region Printing for debuging
        //for (int i = 0; i < 10; i++)
        //{
        //    if (r[i] < pc)
        //    {
        //        print("chosenNum = " + chosenNum);
        //    }
        //}
        //for (int i = 0; i < chosenIndex.Count; i++) print("chosenIndex = " + chosenIndex[i]);
        //for (int i = 0; i < chosenIndex.Count; i++)
        //{
        //    for (int j = 0; j < 10; j++)
        //    {
        //        print(chosenChroms[i][j]);
        //    }
        //}

        #endregion
        if (chosenNum == 1) return Chrom;
        else
        {
            for (int i = 0; i < chosenNum; i++) C[i] = R.Next(1, 9);  // Generate segment index 产生染色体截断点
            #region Printing for debuging
            for (int i = 0; i < chosenNum; i++) print("C[" + i + "] = " + C[i]); //Print out segment index 显示截断点数据
            #endregion


            for (int i = 0; i < chosenIndex.Count; i++) // Cut off chromosome & keep the front segment, and save them into two-dimensional array截断染色体，保留前部分
            {
                for (int j = 0; j < C[i]; j++)
                {
                    keptChrom[i][j] = chosenChroms[i][j];
                }
            }
            //
            print("C[0] = " + C[0]); //Print out segment index of 0显示C0

            for (int i = 0; i < 10; i++) //1.Clone the segment[0]. 2. Clone the first chromosom 1. 保存C[0]到C0， 2. 保存第一条阶段阶段染色体
            {
                chosenChroms0.Add(chosenChroms[0][i]);
                //chosenChroms0[i] = chosenChroms[0][i];
                C0 = C[0];
            }
            for (int i = 0; i < chosenNum - 1; i++) // Move chromosome one gene digit left 左移平移染色体
            {
                chosenChroms[i] = chosenChroms[i + 1];
            }
            chosenChroms[chosenNum - 1] = chosenChroms0;
            #region Printing for debuging
            //print("");
            //print("chosenNum -1 = " + chosenNum);
            //print("New C[chosenNum - 1] = " + C[chosenNum - 1]);
            //for (int i = 0; i < 10 - C[chosenNum -1]; i++)
            //{
            //    print("Just for new C[chosenNum - 1] " + cutoffChrom[chosenNum - 1][i]);
            //}
            //for (int i = 0; i < chosenNum; i++)
            //{
            //    for (int j = 0; j < 10 - C[i]; j++)
            //    {
            //        print("di " + i + "ge list di " + j + "ge vector = " + cutoffChrom[i][j]);
            //    }
            //}
            #endregion
            for (int i = 0; i < chosenNum; i++) // For debuging, print out segment index with it's value 显示老C
            {
                print("C[" + i + "] = " + C[i]);
            }
            for (int i = 0; i < chosenNum; i++)// Cut off chromosome & keep the back segment, and save them into two-dimensional array截断染色体，保留后部分
            {             
                for (int j = 0; j < 10 - C[i]; j++)
                {
                    // seg[j] = chosenChroms[i][C[i] + j]; // 算法绝对没问题 后面debug正确结果
                    cutoffChrom[i][j] = chosenChroms[i][C[i] + j];                    
                }

            }
            #region Printing for debuging
            //for (int i = 0; i < chosenNum; i++)
            //{
            //    for (int j = 0; j < 10 - C[i]; j++)
            //    {
            //        print("di " + i + "ge list di " + j + "ge vector = " + cutoffChrom[i][j]);
            //    }
            //}
            #endregion

            #region Printing for debuging
            //for (int i = 0; i < chosenNum; i++)
            //{
            //    for (int j = 0; j < C[i]; j++)
            //    {
            //        print("Kept ChromSeg = " + keptChrom[i][j]);
            //    }
            //}
            #endregion
            for (int i = 0; i < chosenNum; i++) //Put front segment into new List of chromosome 把前半部分装进新容器
            {
                for (int j = 0; j < C[i]; j++) {
                    print("di " + i + "ge di " + j + "ge" + keptChrom[i][j]);
                    newChroms[chosenIndex[i]].Add(keptChrom[i][j]);
                }
            }
            print("");
            for (int i = 0; i < chosenNum; i++) //Put back segment into new List of chromosome 把后半部分装进新容器
            {
                for (int j = 0; j < 10 - C[i]; j++)
                {
                    print("di " + i + "ge di " + j + "ge" + cutoffChrom[i][j]);
                    newChroms[chosenIndex[i]].Add(cutoffChrom[i][j]);
                }
            }
            //for (int i = 0; i < chosenIndex.Count; i++) // For debuging: traverse all new chromosome测试用遍历所有crossover后的list array
            //{

            //    for (int j = 0; j < 10; j++)
            //    {

            //        print("fuck zhongyu haole: "+newChroms[chosenIndex[i]][j]);
            //    }
            //}
            for (int i = 0; i < chosenIndex.Count; i++)
            {
                Chrom[chosenIndex[i]] = newChroms[chosenIndex[i]];
            }
            //for (int i = 0; i < chosenNum; i++) // 合成染色体
            //{                
            //    for (int j = 0; j < 10 - C[i]; j++)
            //    {
            //        // seg[j] = chosenChroms[i][C[i] + j]; // 算法绝对没问题 后面debug正确结果
            //        keptChrom[i][j] = cutoffChrom[i][C[i] + j];
            //        // print("di " + i + "ge list di " + j + "ge vector = " + seg[j]);
            //    }
            //}
            //print("");
            //for (int i = 0; i < chosenNum; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        print(keptChrom[i][j]);
            //    }
            //}
            return Chrom;
        }    
    }
    //List<Vector3>[] Crossover(CollisionTest[] Ob, List<Vector3>[] Chrom, System.Random R)
    //{
    //    float pc = 0.50f;
    //    int num = 0;
    //    float[] r = new float[10];
    //    int[] C = new int[10];
    //    List<int> parenNum = new List<int>();
    //    List<Vector3>[] parents = new List<Vector3>[20];
    //    List<Vector3> parents0 = new List<Vector3>();
    //    List<Vector3>[] tempParents = new List<Vector3>[20];
    //    Vector3[] chromSeg = new Vector3[20];
    //    //List<Vector3[]>[] chromSegs = new List<Vector3[]>[10];

    //    for (int i = 0; i < 10; i++)  // Choose where to cut off the chromosome
    //    {
    //        r[i] = (float)R.NextDouble();
    //        if (r[i] < pc)
    //        {
    //            parenNum.Add(i);
    //            parents[num] = Chrom[i];
    //            //tempParents[num] = Chrom[i];
    //            print("The chosen parent: " + parents[num] + "  and the order is " + i);
    //            num++;
    //        }
    //    }
    //    parents0 = parents[0];
    //    //for (int i = 0; i < 10; i++)
    //    //{
    //    //    for (int j = 0; j < 10; j++)
    //    //    {
    //    //        print(parents[i][j]);
    //    //    }
    //    //}
    //    if (num < 2) return Chrom;
    //    else
    //    {
    //        for (int i = 0; i < num; i++) C[i] = R.Next(1, 9);  // Generate cut-off point
    //        for (int i = 0; i < num; i++) // For debuging
    //        {
    //            for (int j = 0; j < 10; j++)
    //            {
    //                print("parents[" + i + "] = " + parents[i][j]);
    //            }
    //            print("C[" + i + "] = " + C[i]);
    //        } //Debug print
    //        for (int i = 0; i < num; i++) //        Crossover procedure
    //        {
    //            List<Vector3> chromSegs = new List<Vector3>();
    //            List<Vector3> temp = new List<Vector3>();
    //            for (int j = C[i]; j < 10; j++)
    //            {
    //                //temp.Add(parents[num - i - 1][j]);
    //                //chromSeg[i].Add(parents[num - i - 1][j]);
    //                if (i < num - 1)
    //                {
    //                    chromSeg[j - C[i]] = parents[i + 1][j];
    //                    print("i = " + i);
    //                    print("C[" + i + "] = " + C[i]);
    //                }
    //                if (i == num - 1)
    //                {
    //                    chromSeg[j - C[i]] = parents0[j];
    //                    print("i = " + i);
    //                    print("C[" + i + "] = " + C[i]);
    //                }
    //            }
    //            for (int j = 0; j < 10 - C[i]; j++)  //Debug
    //            {
    //                chromSegs.Add(chromSeg[j]);
    //                //print("Num" + i + " Chromsome Segment: " + chromSeg[j] + " for the " + j + "chromosom");
    //                //print("");
    //            }
    //            //chromSegs[i].Add(chromSeg);
    //            parents[i].RemoveRange(C[i], 10 - C[i]); // yes
    //                                                     //tempParents[i].RemoveRange(0,10);
    //            for (int k = 0; k < C[i]; k++)
    //            {
    //                temp.Add(parents[i][k]);
    //                //print("yuansu: " + parents[i][k]);  //yes
    //            }
    //            for (int k = 0; k < 10 - C[i]; k++)
    //            {
    //                temp.Add(chromSegs[k]);

    //                //print("yuansu: " + chromSegs[k]);   //yes
    //            }
    //            tempParents[i] = temp;
    //            for (int k = 0; k < 10; k++)
    //            {
    //                //print("combination" + tempParents[i][k]);
    //            }
    //            //print("Num = " + num);
    //        }
    //        for (int i = 0; i < parenNum.Count; i++)  // Update original chromosome
    //        {
    //            Chrom[parenNum[i]] = tempParents[i];
    //        }
    //        for (int i = 0; i < 10; i++) // For debuging
    //        {
    //            for (int j = 0; j < 10; j++)
    //            {
    //                //print("parents[" + i + "] = " + Chrom[i][j]);
    //            }
    //            //print("C[" + i + "] = " +C[i]);            
    //        }
    //        //print("Crossover Done!");
    //        return Chrom;
    //    }
    //}
    List<Vector3>[] Mutation(List<Vector3>[] Chrom, System.Random R1, System.Random R2, System.Random R3)
    {
        float mutationRate = 0.1f;
        int mutationNum;
        mutationNum = (int)(mutationRate * 100);
        int[] yAxis = new int[mutationNum];
        //mutationNum = 10;
        List<Vector3> mutationPos = new List<Vector3>();
        for (int i = 0; i < mutationNum; i++)
        {
            yAxis[i] = R1.Next(1, 10);
            //print("yAxis[" + i + "] = " + yAxis[i]);
        }

        for (int i = 0; i < mutationNum; i++)
        {

            float x = (float)R1.NextDouble();
            //float y = (float)R1.Next(1, 10);
            float z = (float)R2.NextDouble();
            //Get random position at layer j (y = j)
            Vector3 pos = new Vector3(x * 100, yAxis[i] * 20, z * 100);
            //print("new Pos = " + pos);
            mutationPos.Add(pos);
        }
        for (int i = 0; i < mutationNum; i++) // 10 times loop
        {
            int j = R3.Next(0, 9); // j = [0, 9]
            //print("J = "+j);
            //int k = R3.Next(0, 10);
            //print("Chrome[j][" + yAxis[i] + "]-1   mutationPos[" + i + "]");
            for (int k = 0; k < 10; k++) // 10 times loop
            {
                if (Chrom[j][k].y == yAxis[i] * 20)
                {
                    //print("old one number " + k + " is " + Chrom[j][yAxis[i] - 1]);
                    Chrom[j][k] = mutationPos[i];
                }
                // print("K loop end");
            }
            //Chrom[j][yAxis[i]-1] = mutationPos[i];
            // print("new one number " + i + " is " + mutationPos[i]);
            //print("");
        }
        //print("!!!!! this should be work    " + mutationNum);
        //for (int i = 0; i < mutationNum; i++)
        //{
        //    print("mutiantionPos[" + i + "] = " + mutationPos[i]);
        //}
        //for (int i = 0; i < 10; i++) // For debuging
        //{
        //    for (int j = 0; j < 10; j++)
        //    {
        //        print("parents[" + i + "] = " + Chrom[i][j]);
        //    }
        //    //print("C[" + i + "] = " +C[i]);            
        //}
        print("Mutation Done!");
        return Chrom;
    }
    void Resurrection(GameObject gb0, GameObject gb1, GameObject gb2, GameObject gb3, GameObject gb4, GameObject gb5, GameObject gb6, GameObject gb7, GameObject gb8, GameObject gb9)
    {
        gb0.SetActive(true);
        gb1.SetActive(true);
        gb2.SetActive(true);
        gb3.SetActive(true);
        gb4.SetActive(true);
        gb5.SetActive(true);
        gb6.SetActive(true);
        gb7.SetActive(true);
        gb8.SetActive(true);
        gb9.SetActive(true);
        print("Resurrection Done!");
    }
    void Reposition(GameObject gb0, GameObject gb1, GameObject gb2, GameObject gb3, GameObject gb4, GameObject gb5, GameObject gb6, GameObject gb7, GameObject gb8, GameObject gb9)
    {

        gb0.transform.position = new Vector3(50, 5, 50);
        gb1.transform.position = new Vector3(50, 5, 50);
        gb2.transform.position = new Vector3(50, 5, 50);
        gb3.transform.position = new Vector3(50, 5, 50);
        gb4.transform.position = new Vector3(50, 5, 50);
        gb5.transform.position = new Vector3(50, 5, 50);
        gb6.transform.position = new Vector3(50, 5, 50);
        gb7.transform.position = new Vector3(50, 5, 50);
        gb8.transform.position = new Vector3(50, 5, 50);
        gb9.transform.position = new Vector3(50, 5, 50);
        print("Re-position Done!");
    }
    private void FixedUpdate()
    {
        switch (currentState)
        {
            case State_Type.Simulation:
                // Debug.Log("Simulation!!!!!!!!!!");
                for (int i = 0; i < 10; i++) motorScript.Run(i, motorScript.ship[i]);
                if (States(shipScripts) == 10)
                {
                    currentState = State_Type.Iteration;
                }
                break;
            case State_Type.Iteration:
                Debug.Log("Iteration ongoing");
                if (!selecFlag && !crossFlag && !mutatFlag && !reposFlag && !resurFlag)
                {
                    chromosomes = Selection(shipScripts, chromosomes, rand);
                    selecFlag = true;
                }
                if (selecFlag && !crossFlag && !mutatFlag && !reposFlag && !resurFlag)
                {
                    //chromosomes = Crossover(shipScripts, chromosomes, rand);
                    chromosomes = Crossover2(chromosomes, rand);
                    crossFlag = true;
                }
                if (selecFlag && crossFlag && !mutatFlag && !reposFlag && !resurFlag)
                {
                    chromosomes = Mutation(chromosomes, rand1, rand2, rand3);
                    mutatFlag = true;
                }
                if (selecFlag && crossFlag && mutatFlag && !reposFlag && !resurFlag)
                {
                    Reposition(ship0, ship1, ship2, ship3, ship4, ship5, ship6, ship7, ship8, ship9);
                    reposFlag = true;
                }
                if (selecFlag && crossFlag && mutatFlag && reposFlag && !resurFlag)
                {
                    Resurrection(ship0, ship1, ship2, ship3, ship4, ship5, ship6, ship7, ship8, ship9);
                    resurFlag = true;
                }
                if (States(shipScripts) == 0 && selecFlag && crossFlag && mutatFlag && reposFlag && resurFlag)
                {
                    resurFlag = false;
                    reposFlag = false;
                    selecFlag = false;
                    crossFlag = false;
                    mutatFlag = false;

                    currentState = State_Type.Simulation;
                }
                // for (int i = 0; i < 10; i++) motorScript.Run(i, motorScript.ship[i]);
                break;
        }







        ///<summary>
        /// Only for Test
        /// </summary>
        //if (IterationDone(shipScripts) == 10 && selectFlag)
        //{
        //    chromosomes = Selection(shipScripts, chromosomes, rand);
        //   chromosomes = Crossover(shipScripts, chromosomes, rand);
        //   chromosomes = Mutation(shipScripts, chromosomes, rand1, rand2, rand3);
        //    selectFlag = false;
        //}
        //if (!selectFlag && stopFlag)
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        for (int k = 0; k < 10; k++)
        //        {
        //            if (i == 0)
        //            {
        //                GameObject obj = (GameObject)Instantiate(cube0);
        //                //cubes.Add(obj);
        //                obj.transform.position = chromosomes[i][k];
        //            }
        //            else if (i == 1)
        //            {
        //                GameObject obj = (GameObject)Instantiate(cube1);
        //                //cubes.Add(obj);
        //                obj.transform.position = chromosomes[i][k];
        //            }
        //            else if (i == 2)
        //            {
        //                GameObject obj = (GameObject)Instantiate(cube2);
        //                //cubes.Add(obj);
        //                obj.transform.position = chromosomes[i][k];
        //            }
        //            else if (i == 3)
        //            {
        //                GameObject obj = (GameObject)Instantiate(cube3);
        //                //cubes.Add(obj);
        //                obj.transform.position = chromosomes[i][k];
        //            }
        //            else if (i == 4)
        //            {
        //                GameObject obj = (GameObject)Instantiate(cube4);
        //                //cubes.Add(obj);
        //                obj.transform.position = chromosomes[i][k];
        //            }
        //            else if (i == 5)
        //            {
        //                GameObject obj = (GameObject)Instantiate(cube5);
        //                //cubes.Add(obj);
        //                obj.transform.position = chromosomes[i][k];
        //            }
        //            else if (i == 6)
        //            {
        //                GameObject obj = (GameObject)Instantiate(cube6);
        //                //cubes.Add(obj);
        //                obj.transform.position = chromosomes[i][k];
        //            }
        //            else if (i == 7)
        //            {
        //                GameObject obj = (GameObject)Instantiate(cube7);
        //                // cubes.Add(obj);
        //                obj.transform.position = chromosomes[i][k];
        //            }
        //            else if (i == 8)
        //            {
        //                GameObject obj = (GameObject)Instantiate(cube8);
        //                // cubes.Add(obj);
        //                obj.transform.position = chromosomes[i][k];
        //            }
        //            else if (i == 9)
        //            {
        //                GameObject obj = (GameObject)Instantiate(cube9);
        //                // cubes.Add(obj);
        //                obj.transform.position = chromosomes[i][k];
        //            }
        //        }
        //    }
        //    stopFlag = false;
        //}
    }
}




