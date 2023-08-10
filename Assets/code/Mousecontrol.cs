using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Mousecontrol : MonoBehaviour
{
    public Transform objectToOrbit;
    private float fixedDeltaTime;
    public GameObject projectilPrefab;
    public GameObject AtomicBomb;
    void Start()
    {
        
        // Make a copy of the fixedDeltaTime, it defaults to 0.02f, but it can be changed in the editor
        this.fixedDeltaTime = Time.fixedDeltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(objectToOrbit.position, Vector3.up, Input.GetAxis("Mouse X"));

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Time.timeScale == 1.0f)
                Time.timeScale = 5.0f;
            else
                Time.timeScale = 1.0f;
            // Adjust fixed delta time according to timescale
            // The fixed delta time will now be 0.02 real-time seconds per frame
            Time.fixedDeltaTime = this.fixedDeltaTime * Time.timeScale;
        }

        shoot();

        war();
        
    }
    void shoot()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            Instantiate(projectilPrefab, transform.position, projectilPrefab.transform.rotation);

        }
    }
    void war()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            Instantiate(AtomicBomb, transform.position, AtomicBomb.transform.rotation);

        }
    }
    

}
