using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IS_death : MonoBehaviour
{
    public Transform respawn = null;
    public GameObject Player;   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

void OnTriggerEnter(Collider other)
{
    print("Death");
   other.transform.position = respawn.transform.position;
}

}
