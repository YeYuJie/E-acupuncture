//======= Copyright (c) Valve Corporation, All rights reserved. ===============


using UnityEngine;
using System.Collections;

[RequireComponent(typeof(SteamVR_TrackedObject))]
public class SteamVR_TestThrow : MonoBehaviour
{
	public GameObject prefab;
	public Rigidbody attachPoint;

	SteamVR_TrackedObject trackedObj;
	FixedJoint joint;

	void Awake()
	{
		trackedObj = GetComponent<SteamVR_TrackedObject>();
	}

	void FixedUpdate()
	{
		var device = SteamVR_Controller.Input((int)trackedObj.index);
		if (device.GetTouchDown (SteamVR_Controller.ButtonMask.Touchpad)) {
			Debug.Log ("TouchDown Touchpad");
		}
		if (device.GetTouchDown(SteamVR_Controller.ButtonMask.Trigger))
		{
			Debug.Log ("TouchDown Trigger");
		}
		if (device.GetTouch (SteamVR_Controller.ButtonMask.Trigger)) {
			Debug.Log ("Touch Trigger");
		}
		if(device.GetTouchUp(SteamVR_Controller.ButtonMask.Trigger))
		{
			Debug.Log ("TouchUp Trigger");
		}
		if (device.GetTouchDown (SteamVR_Controller.ButtonMask.Grip)) {
			Debug.Log ("TouchDown Grip");
		}
		if (device.GetPressDown (SteamVR_Controller.ButtonMask.Grip)) {
			Debug.Log ("PressDown Grip");
		}


	}
}
