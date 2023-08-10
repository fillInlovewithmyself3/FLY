using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class columnar : MonoBehaviour
{
    public GameObject[] columnarPrefabs;

    private float X;
    private float Z;

    private float startDelay = 0.1f;
    private float spawnInterval = 1.5f;
    

    

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("ColumnarBody", startDelay, spawnInterval);
        InvokeRepeating("Timergenerate", 2f , 5f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    void ColumnarBody()
    {
        int columnarIndex = Random.Range(0, columnarPrefabs.Length);      
        //Vector3 columnar=naw Vector3(Random.Range(-X, X,), 0, Z);
        Instantiate(columnarPrefabs[columnarIndex],new Vector3(RandomNum(), 0, RandomNum()), columnarPrefabs[columnarIndex].transform.rotation);
        
    }
    void Timergenerate()
    {
        int Timergenerate = Random.Range(1, 4);
        switch (Timergenerate)
        {
            case 1:
                ColumnarBody();
                break;
            case 2:
                ColumnarBody();
                ColumnarBody();
                break;
            case 3:
                ColumnarBody();
                ColumnarBody();
                ColumnarBody();
                break;
            case 4:
                ColumnarBody();
                ColumnarBody();
                ColumnarBody();
                ColumnarBody();
                break;
        }

    }
    float RandomNum()
    {
        int randomNum = Random.Range(-4, 4);
        return randomNum;
    }
}
