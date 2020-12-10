using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IS_Spawn_With_Force : MonoBehaviour
{
     public int numberOfTimes = 3;
    public bool infinite =false;
    public float timeBetween =1f;
    public GameObject go_spawnee;
    public Vector3 forceVector; 

private float nextTime;
private int countSoFar = 0;
private GameObject newObject;

    // Start is called before the first frame update
    void Start()
    {
        nextTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    { //check there is a spawnee set
        if(go_spawnee != null)
        {   //has the time between spawns passed 
            if(nextTime<Time.time)
    { //spawn if either infinite is set or the number of spawns have been/not been reached
        if(infinite || countSoFar < numberOfTimes)
{
     newObject = Instantiate(go_spawnee, transform.position, transform.rotation);
    //grab the newobjects rigidbody and give it a shove
    newObject.GetComponent<Rigidbody>().AddForce(forceVector,ForceMode.Impulse);
    //update count
    countSoFar++;
    //set the next time to spawn
    nextTime = Time.time+ timeBetween;
    //erase prev object
    newObject= null;
}}
        }}}