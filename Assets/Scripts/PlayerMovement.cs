using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public Vector3 pos;
	[SerializeField]
	private TouchPadWalking touchpadwalking;
	public Transform headset;
	public float speed = 10;

	// Use this for initialization
	void Start () {
		touchpadwalking = touchpadwalking.GetComponent<TouchPadWalking> ();
	}
	
	// Update is called once per frame
	void Update () {
		pos = new Vector3 (headset.transform.forward.x, 0, headset.transform.forward.z);
		if (touchpadwalking.device.GetAxis ().x >= -0.25 && touchpadwalking.device.GetAxis ().x <= 0.25) {
			transform.position += pos * speed;
		}


	}
}
