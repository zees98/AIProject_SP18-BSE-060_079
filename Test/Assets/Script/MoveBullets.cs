using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBullets : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * Time.deltaTime * 20);

        if (transform.position.x > 16.5)
            Destroy(gameObject);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {

            Destroy(gameObject);
            Destroy(other.gameObject);
           

        }
    }
}
