using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableMovement : MonoBehaviour {

    [SerializeField]
    private GameObject obj;
    private bool floatPlayer = false;

    public Transform target;
    public float speed = 0.1f;

   void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            obj.GetComponent<FirstPersonController>().enabled = false;
            if (other.attachedRigidbody)
                other.attachedRigidbody.useGravity = false;

            floatPlayer = true;
        }
    }

    void Update()
    {
        if(floatPlayer)
            obj.transform.Translate(Vector3.up * Time.deltaTime);
    }
}
