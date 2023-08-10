using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cmObject : MonoBehaviour
{
    private float scale = 0.001f;
    private GameObject objectToOrbit;
    // Start is called before the first frame update
    void Start()
    {
        objectToOrbit = GameObject.Find("target");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pointDirection = objectToOrbit.transform.position - transform.position;
        Vector3 moveToPoint2 = pointDirection.normalized * 20;
        Vector3 moveTopoint = transform.position + moveToPoint2;

        this.gameObject.transform.localScale += new Vector3(scale, scale, 0f);
        transform.Translate(moveTopoint.normalized * Time.deltaTime * 10);

        

    }
}
