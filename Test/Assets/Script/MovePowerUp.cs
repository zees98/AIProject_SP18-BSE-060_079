﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePowerUp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * 20);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))

        {
            Shoot.ammo = 25;
        }
    }
}
