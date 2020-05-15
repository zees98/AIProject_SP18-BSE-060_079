using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    // Start is called before the first frame update
    int gunIndex = 0;
    public GameObject gun1;
    public static int ammo = 25;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)  )
        {
            if(ammo > 0)
            {
                ammo--;
                if (gunIndex++ % 2 == 0)
                    Instantiate(gun1, new Vector3(gun1.transform.position.x + 0.55f, gun1.transform.position.y, transform.position.z - 0.46f), gun1.transform.rotation);
                else
                    Instantiate(gun1, new Vector3(gun1.transform.position.x + 0.55f, gun1.transform.position.y, transform.position.z + 0.46f), gun1.transform.rotation);
                Debug.Log(ammo);
            }
            else
            {
                Debug.Log("No Ammo");
            }
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PowerUp"))
        {
            gunIndex = 25;
        }
    }
}
