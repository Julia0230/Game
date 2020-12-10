using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IS_Basic_Movement : MonoBehaviour
{
    public float movementspeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp("k"))
        {
         transform.Translate(0,movementspeed,0);

        }
        
        if(Input.GetKeyUp("m"))
        {
         transform.Translate(0,-movementspeed,0);

        }
    }
}
