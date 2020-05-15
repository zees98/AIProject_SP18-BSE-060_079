using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlBackground : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -53.5)
        {
            transform.position = new Vector3(15.1f, 0, 0);
        }
    }
}
