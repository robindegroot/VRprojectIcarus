using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickeringLight : MonoBehaviour {

    Light flickeringLight;
    public float minWaitTime;
    public float maxWaitTime;

	// Use this for initialization
	void Start () {
        flickeringLight = GetComponent<Light>();
        StartCoroutine("Flickering");	
	}
	
	IEnumerator Flickering()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(minWaitTime, maxWaitTime));
            flickeringLight.enabled = !flickeringLight.enabled;
        }
    }
}
