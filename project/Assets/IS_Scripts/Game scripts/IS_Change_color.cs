using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IS_Change_color : MonoBehaviour
{
    public GameObject ObjectThatChangeColor;
 public Material Mat;

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
  
   
        ObjectThatChangeColor.GetComponent<MeshRenderer> ().material = Mat;
   
}
}
