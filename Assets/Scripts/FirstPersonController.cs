using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonController : MonoBehaviour {

    //Recharge on keyUp

    private float speed = 4;
    private float stamina = 100;
    private bool tired = false;

    private float sprintIncrease = 0.25f;
    private float sprintDecrease = 0.5f;

	// Use this for initialization
	void Start () {
        Cursor.lockState = CursorLockMode.Locked;
	}
	
	// Update is called once per frame
	void Update () {
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float y = Input.GetAxis("Vertical") * Time.deltaTime * speed;

        if (stamina < 0)
            tired = true;
        else
            tired = false;

        transform.Translate(x, 0, y);
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.W) && !tired || Input.GetKey("joystick button 0") && !tired)
        {
            speed = 8;
            if(stamina >= 0)
                stamina = stamina - sprintDecrease;
        }
        else
        {
            speed = 4;
        }
        if (Input.GetKey(KeyCode.LeftShift) != true && stamina < 100)
        {
            stamina = stamina + sprintIncrease;
        }
        //Debug.Log(stamina);
	}
}
