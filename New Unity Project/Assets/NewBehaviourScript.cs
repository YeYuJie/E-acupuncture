using UnityEngine;
using System.Collections;
using Valve.VR;

public class StartVR:MonoBehaviour{

	public SteamVR_TrackedObject leftHand;
	public SteamVR_TrackedObject rightHand;

	private VRControllerState_t leftControllerState;
	private VRControllerState_t rightControllerState;

	void Update(){

		CVRSystem system=OpenVR.System;

		if(system!=null && system.GetControllerState((uint)leftHand.index,ref leftControllerState,1))
		{
			SteamVR_Controller.Device device=SteamVR_Controller.Input((int)leftHand.index);

			float px=leftControllerState.rAxis0.x;
			float py=leftControllerState.rAxis0.y;

			if(device.GetPressDown(EVRButtonId.k_EButton_SteamVR_Trigger)){
				Debug.Log("按下trigger键");
			} 
			else if(device.GetPress(EVRButtonId.k_EButton_SteamVR_Trigger)){
				Debug.Log("按住trigger键");
			}
			else if(device.GetPressUp(EVRButtonId.k_EButton_SteamVR_Trigger)){
				Debug.Log("抬起trigger键");
			}

			if(device.GetPressDown(EVRButtonId.k_EButton_ApplicationMenu)){
				Debug.Log("按下menu键");
			}
			else if(device.GetPress(EVRButtonId.k_EButton_ApplicationMenu)){
				Debug.Log("按住menu键");
			}
			else if(device.GetPressUp(EVRButtonId.k_EButton_ApplicationMenu)){
				Debug.Log("抬起menu键");
			}

			if(device.GetTouchDown(EVRButtonId.k_EButton_SteamVR_Touchpad)){
				Debug.Log("触摸pad面板");
			}
			else if(device.GetTouch(EVRButtonId.k_EButton_SteamVR_Touchpad)){
				Debug.Log("持续触摸pad面板");
			}
			else if(device.GetTouchUp(EVRButtonId.k_EButton_SteamVR_Touchpad)){
				Debug.Log("从pad面板上抬起手");
			}

			if(device.GetPressDown(EVRButtonId.k_EButton_SteamVR_Touchpad)){
				Debug.Log("按下pad按钮");
			}
			else if(device.GetPress(EVRButtonId.k_EButton_SteamVR_Touchpad)){
				Debug.Log("按住pad按钮");
			}
			else if(device.GetPressUp(EVRButtonId.k_EButton_SteamVR_Touchpad)){
				Debug.Log("抬起pad按钮");
			}

			if(device.GetPressDown(EVRButtonId.k_EButton_Grip)){
				Debug.Log("按下Grip键");
			}
			else if(device.GetPress(EVRButtonId.k_EButton_Grip)){
				Debug.Log("按住Grip键");
			}
			else if(device.GetPressUp(EVRButtonId.k_EButton_Grip)){
				Debug.Log("抬起Grip键");
			}

			if(device.GetHairTriggerDown()){
				Debug.Log("轻按trigger");
			}
			else if(device.GetHairTrigger()){
				Debug.Log("持续轻按trigger键");
			}
			else if(device.GetHairTriggerUp()){
				Debug.Log("抬起轻按trigger键");
			}
		}




		if(system!=null && system.GetControllerState((uint)rightHand.index,ref rightControllerState,1))
		{
			SteamVR_Controller.Device device=SteamVR_Controller.Input((int)rightHand.index);

			float px=rightControllerState.rAxis0.x;
			float py=rightControllerState.rAxis0.y;

			if(device.GetPressDown(EVRButtonId.k_EButton_SteamVR_Trigger)){
				Debug.Log("按下trigger键");
			} 
			else if(device.GetPress(EVRButtonId.k_EButton_SteamVR_Trigger)){
				Debug.Log("按住trigger键");
			}
			else if(device.GetPressUp(EVRButtonId.k_EButton_SteamVR_Trigger)){
				Debug.Log("抬起trigger键");
			}

			if(device.GetPressDown(EVRButtonId.k_EButton_ApplicationMenu)){
				Debug.Log("按下menu键");
			}
			else if(device.GetPress(EVRButtonId.k_EButton_ApplicationMenu)){
				Debug.Log("按住menu键");
			}
			else if(device.GetPressUp(EVRButtonId.k_EButton_ApplicationMenu)){
				Debug.Log("抬起menu键");
			}

			if(device.GetTouchDown(EVRButtonId.k_EButton_SteamVR_Touchpad)){
				Debug.Log("触摸pad面板");
			}
			else if(device.GetTouch(EVRButtonId.k_EButton_SteamVR_Touchpad)){
				Debug.Log("持续触摸pad面板");
			}
			else if(device.GetTouchUp(EVRButtonId.k_EButton_SteamVR_Touchpad)){
				Debug.Log("从pad面板上抬起手");
			}

			if(device.GetPressDown(EVRButtonId.k_EButton_SteamVR_Touchpad)){
				Debug.Log("按下pad按钮");
			}
			else if(device.GetPress(EVRButtonId.k_EButton_SteamVR_Touchpad)){
				Debug.Log("按住pad按钮");
			}
			else if(device.GetPressUp(EVRButtonId.k_EButton_SteamVR_Touchpad)){
				Debug.Log("抬起pad按钮");
			}

			if(device.GetPressDown(EVRButtonId.k_EButton_Grip)){
				Debug.Log("按下Grip键");
			}
			else if(device.GetPress(EVRButtonId.k_EButton_Grip)){
				Debug.Log("按住Grip键");
			}
			else if(device.GetPressUp(EVRButtonId.k_EButton_Grip)){
				Debug.Log("抬起Grip键");
			}

			if(device.GetHairTriggerDown()){
				Debug.Log("轻按trigger");
			}
			else if(device.GetHairTrigger()){
				Debug.Log("持续轻按trigger键");
			}
			else if(device.GetHairTriggerUp()){
				Debug.Log("抬起轻按trigger键");
			}
		}
	}
}