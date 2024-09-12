using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyForce : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(Vector3.forward*500);
    }
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision detected with "+collision.gameObject.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
