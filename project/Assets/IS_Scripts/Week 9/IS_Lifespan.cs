using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IS_Lifespan : MonoBehaviour
{
    public float lifeSpan = 1f;

    private float timeIsUp;
    // Start is called before the first frame update
    void Start()
    {
        timeIsUp = Time.time+lifeSpan;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time>timeIsUp)
        {
            Destroy(gameObject);
        }
    }
}
