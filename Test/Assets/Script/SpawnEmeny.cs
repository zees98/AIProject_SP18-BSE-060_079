using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEmeny : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemy;

    void Start()
    {
        InvokeRepeating("spawnMethod", 2.5f, 1f);   
    }

    // Update is called once per frame
    void spawnMethod()
    {
        float num = Random.Range(-4.0f, 4.0f);
        Instantiate(enemy, new Vector3(enemy.transform.position.x, enemy.transform.position.y, num), enemy.transform.rotation);
    }
    void Update()
    {
        
    }
}
