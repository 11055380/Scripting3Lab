using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncecode : MonoBehaviour
{
    public float bounceForce = 3f;
    
    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<Rigidbody>().AddForce(Vector3.up*bounceForce, ForceMode.Impulse);
    }
}
