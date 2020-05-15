using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepPlayerInbounds : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float newZ = transform.position.z;
        if (transform.position.z > 4)
        {
            newZ = 4f;
        }
        else if (transform.position.z < -4)
        {
            newZ = -4f;

        }
        transform.position = new Vector3(transform.position.x, transform.position.y, newZ);
    }
}
