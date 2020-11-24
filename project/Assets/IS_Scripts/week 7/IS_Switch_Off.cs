using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IS_Switch_Off : MonoBehaviour
{
    public GameObject ObjectToBeDeactivated;
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
   if(other.gameObject.tag == "Player")
   {
       ObjectToBeDeactivated.SetActive(false);
   }
}
}
