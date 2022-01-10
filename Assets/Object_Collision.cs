using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Collision : MonoBehaviour
{
    float power = 100.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collided)
    {
        this.GetComponent<AudioSource>().Play();
        Debug.Log(collided.gameObject.name);

        Vector3 launch_direction = new Vector3(0, 1, 1);
        
        if (collided.gameObject.name == "Plane")
        {
            this.GetComponent<Rigidbody>().AddForce(launch_direction * power);
        }
    }
}
