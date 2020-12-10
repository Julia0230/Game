using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IS_Spawner : MonoBehaviour
{
    public int numberOfTimes = 3;
    public bool infinite =false;
    public float timeBetween =1f;
    public GameObject go_spawnee;

private float nextTime;
private int countSoFar = 0;

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
        Instantiate(go_spawnee, transform.position, transform.rotation);
    //update count
         countSoFar++;
    //set the next time to spawn
        nextTime = Time.time + timeBetween;
}}}}}
