using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IS_Checkpoint : MonoBehaviour
{
    public Material Mat1;
    public Material Blue;
    public Transform NextCheckpoint;

    private Renderer _Renderer;
    private IS_LevelManager levelManagerReference;

    // Start is called before the first frame update
    void Start()
    {
      _Renderer = gameObject.GetComponent<Renderer>();
      _Renderer.material = Blue;
      levelManagerReference = GameObject.Find("LevelManager").GetComponent<IS_LevelManager>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
{
    //print (_Render.material.name);
    if(_Renderer.material.name == "Light blue (Instance)" && other.gameObject.tag == "Player" )
    {
        //print("Change");
        _Renderer.material = Mat1;
        levelManagerReference.lastGoodCheckpoint = NextCheckpoint.transform;
    }

}

}
