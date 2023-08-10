using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atomic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, 6);
    }
    void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "cube")
        {
            Destroy(gameObject);
            
        }
    }

    private void OnDestroy()
    {
        GameObject[] Atomic_Boom = GameObject.FindGameObjectsWithTag("cube");
        foreach (GameObject gObject in Atomic_Boom)
        {
            Destroy(gObject);
        }
    }
}
