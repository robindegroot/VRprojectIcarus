using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AltarScript : MonoBehaviour {

    // Op de player
    // 4 verschillende triggers voor elke altaar


    [SerializeField]
    private GameObject statueNorth;
    [SerializeField]
    private GameObject statueEast;
    [SerializeField]
    private GameObject statueSouth;
    [SerializeField]
    private GameObject statueWest;

    public bool altarNorthActivated = false;
    public bool altarEastActivated = false;
    public bool altarSouthActivated = false;
    public bool altarWestActivated = false;

    private bool statueNorthPutDown = false;
    private bool statueEastPutDown = false;
    private bool statueSouthPutDown = false;
    private bool statueWestPutDown = false;

    [SerializeField]
    private GameObject ending;

    [SerializeField]
    private Text text;

    //private float counter = 0;

    // Use this for initialization
    void Start () {
        statueNorth.SetActive(false);
        statueSouth.SetActive(false);
        statueEast.SetActive(false);
        statueWest.SetActive(false);

        ending.SetActive(false);
        text.enabled = false;
	}
	
    void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "AltarNorth")
        {
            text.enabled = true;
            if (Input.GetKeyDown("joystick button 2") || Input.GetKeyDown(KeyCode.E))
                if (altarNorthActivated)
                {
                    {
                        statueNorth.SetActive(true);
                        statueNorthPutDown = true;
                        //counter = counter + 1;
                    }
                }
            //Debug.Log("AltarNorth");
        }
        if (other.gameObject.tag == "AltarEast")
        {
            text.enabled = true;
            if (Input.GetKeyDown("joystick button 2") || Input.GetKeyDown(KeyCode.E))
                if (altarEastActivated)
                {
                    {
                        statueEast.SetActive(true);
                        statueEastPutDown = true;
                        //counter = counter + 1;
                    }
                }
            //Debug.Log("AltarEast");
        }
        if (other.gameObject.tag == "AltarSouth")
        {
            text.enabled = true;
            if (Input.GetKeyDown("joystick button 2") || Input.GetKeyDown(KeyCode.E))
                if (altarSouthActivated)
                {
                    {
                        statueSouth.SetActive(true);
                        statueSouthPutDown = true;
                        //counter = counter + 1;
                    }
                }
            //Debug.Log("AltarSouth");
        }
        if (other.gameObject.tag == "AltarWest")
        {
            text.enabled = true;
            if (Input.GetKeyDown("joystick button 2") || Input.GetKeyDown(KeyCode.E))
                if (altarWestActivated)
                {
                    {
                        statueWest.SetActive(true);
                        statueWestPutDown = true;
                        //counter = counter + 1;
                    }
                }
            //Debug.Log("AltarWest");
        }
    }
	// Update is called once per frame
	void Update () {
		if(statueNorthPutDown && statueEastPutDown && statueSouthPutDown && statueWestPutDown)
        {
            Ending();
        }
	}

    void Ending()
    {
        ending.SetActive(true);
    }
}
