using UnityEngine;
using System.Collections;
using Valve.VR;

public class TouchPadWalking : MonoBehaviour
{
	public SteamVR_TrackedObject trackedObject;
	public SteamVR_Controller.Device device;

	public SteamVR_TrackedController controller;

	void Start(){	
		trackedObject = GetComponent<SteamVR_TrackedObject> ();
		controller = GetComponent<SteamVR_TrackedController> ();

		controller.PadClicked += Controller_PadClicked;
	}

	private void Controller_PadClicked(object sender, ClickedEventArgs e){
		if(device.GetAxis().x != 0 || device.GetAxis().y != 0){
			Debug.Log(device.GetAxis().x + " " + device.GetAxis().y);
		}
	}
	void Update(){
		device = SteamVR_Controller.Input ((int)trackedObject.index);
	}
}