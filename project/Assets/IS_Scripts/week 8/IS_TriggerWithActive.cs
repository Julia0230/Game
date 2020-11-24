using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IS_TriggerWithActive : MonoBehaviour
{
    public bool fl_activate = false;
    public GameObject objectToActivate;
    private bool canActivate = false;
    private IS_LevelManager currentLevelManager;
    // Start is called before the first frame update
    void Start()
    {
        GameObject go = GameObject.Find("LevelManager");
        currentLevelManager = go.GetComponent<IS_LevelManager>();
    }

    // Update is called once per frame
    void Update()
    {
     if(Input.GetKeyUp("e") && canActivate)
     {
         fl_activate = !fl_activate;
         objectToActivate.SetActive(fl_activate);
     }   
    }
    private void OnTrigerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            canActivate = true;
            currentLevelManager.ShowMessage("Press E to Activate");
        }
    }
    private void OnTrigerExit(Collider other)
    {
        if(other.gameObject.tag == "PLayer")
        {
            canActivate = false;
        }
    }
}