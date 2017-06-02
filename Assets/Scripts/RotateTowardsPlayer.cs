using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTowardsPlayer : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
        this.transform.forward = (Camera.main.transform.position - this.transform.position);
	}
}
