using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPowerUp : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject powerUp;
    void Start()
    {
        InvokeRepeating("spawnMethod", 2.5f, 10.0f);
    }
    void spawnMethod() {
        float randF = Random.Range(-4f, 4f);
        Instantiate(powerUp, new Vector3(17.26f, 0.1022932f, randF), powerUp.transform.rotation);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
