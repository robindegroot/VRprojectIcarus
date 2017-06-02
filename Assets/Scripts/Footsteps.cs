using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour {

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

	void Update()
    {
        if(rb.velocity.magnitude > 1f)
        {
            Debug.Log("HAhaj;dasdoi;");
        }
        //Debug.Log(rb.velocity.magnitude);
    }
}
