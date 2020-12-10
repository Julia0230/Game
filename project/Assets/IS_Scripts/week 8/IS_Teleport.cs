using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 public class IS_Teleport : MonoBehaviour 
 {
 
     public Transform Destination;       // Gameobject where they will be teleported to
     public string TagList = "Player";
 
     // Use this for initialization
     void Start () {
         // As needed
     }
     
     // Update is called once per frame
     void Update () {
         // As needed
     }
 
     void OnTriggerEnter(Collider other)
     {   if (TagList.Contains(string.Format("Player")))
        {
             // Update other objects position and rotation
             other.transform.position = Destination.transform.position;
             other.transform.rotation = Destination.transform.rotation;
         }
     }
 }