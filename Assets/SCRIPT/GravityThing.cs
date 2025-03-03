using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityThing : MonoBehaviour
{
    private Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }



    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player")) 
        {
            rb.useGravity = true;
        }

    }
}
