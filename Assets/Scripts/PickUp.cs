using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class PickUp : MonoBehaviour {

    [SerializeField]
    private Text pickUpText;
    private bool pickedUp = true;
    private bool hintSound = true;
    private float waitTime = 10f;

    private AltarScript player;

    [SerializeField]
    private string objectName = "";

    public AudioClip clip;

	// Use this for initialization
	void Start () {
        pickUpText.enabled = false;
        GameObject g = GameObject.FindGameObjectWithTag("Player");
        player = g.GetComponent<AltarScript>();
	}

    void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "StatueNorth")
        {
            pickUpText.enabled = true;
        }
        if (other.gameObject.tag == "StatueNorth" && pickedUp == true && Input.GetKeyDown(KeyCode.E) || (other.gameObject.tag == "StatueNorth" && pickedUp == true && Input.GetKeyDown("joystick button 2")))
        {
            Destroy(other.gameObject);
            player.altarNorthActivated = true;
            pickUpText.enabled = false;
            //Inventory.add(objectName);
        }

        if (other.gameObject.tag == "StatueEast")
        {
            pickUpText.enabled = true;
        }
        if (other.gameObject.tag == "StatueEast" && pickedUp == true && Input.GetKeyDown(KeyCode.E) || (other.gameObject.tag == "StatueEast" && pickedUp == true && Input.GetKeyDown("joystick button 2")))
        {
            Destroy(other.gameObject);
            player.altarEastActivated = true;
            pickUpText.enabled = false;
            //Inventory.add(objectName);
        }

        if (other.gameObject.tag == "StatueWest")
        {
            pickUpText.enabled = true;
        }
        if (other.gameObject.tag == "StatueWest" && pickedUp == true && Input.GetKeyDown(KeyCode.E) || (other.gameObject.tag == "StatueWest" && pickedUp == true && Input.GetKeyDown("joystick button 2")))
        {
            Destroy(other.gameObject);
            player.altarWestActivated = true;
            pickUpText.enabled = false;
            //Inventory.add(objectName);
        }

        if (other.gameObject.tag == "StatueSouth")
        {
            pickUpText.enabled = true;
        }
        if (other.gameObject.tag == "StatueSouth" && pickedUp == true && Input.GetKeyDown(KeyCode.E) || (other.gameObject.tag == "StatueSouth" && pickedUp == true && Input.GetKeyDown("joystick button 2")))
        {
            Destroy(other.gameObject);
            player.altarSouthActivated = true;
            pickUpText.enabled = false;
            //Inventory.add(objectName);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "StatueNorth")
            pickUpText.enabled = false;
        if (other.gameObject.tag == "StatueEast")
            pickUpText.enabled = false;
        if (other.gameObject.tag == "StatueSouth")
            pickUpText.enabled = false;
        if (other.gameObject.tag == "StatueWest")
            pickUpText.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && hintSound)
        {
            AudioSource.PlayClipAtPoint(clip, transform.position, 0.01f);
            StartCoroutine("HintSoundCooldown");
        }
    }

    IEnumerator HintSoundCooldown()
    {
        hintSound = false;
        yield return new WaitForSeconds(waitTime);
        hintSound = true;
    }
}
