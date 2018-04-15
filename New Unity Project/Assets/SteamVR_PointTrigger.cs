using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SteamVR_PointTrigger : MonoBehaviour {

	SteamVR_LaserPointer slp;
	SteamVR_TrackedController stc;
	GameObject target=null;
	GameObject check=null;
	bool changeColor=false;
	Color defaultColor;

	// Use this for initialization
	void Start () {
		slp = GetComponent<SteamVR_LaserPointer> ();
		slp.PointerIn += OnpointerIn;
		slp.PointerOut += OnpointerOut;
		stc = GetComponent<SteamVR_TrackedController> ();
		stc.TriggerClicked += OnTriggerClicked;
		//stc.TriggerPressed += OnTriggerClicked;
		//stc.TriggerUnclicked += OnTriggerUnclicked;
	}

	// Update is called once per frame
	void Update () {

	}
	void OnpointerIn(object sender,PointerEventArgs e)
	{
		GameObject obj = e.target.gameObject;
		if(obj!=null)
			target = obj;
		if (obj.tag.Equals ("Scence1")||obj.tag.Equals("Scence2")||obj.tag.Equals("Exit")) {
			Material[] material = obj.GetComponent<Renderer> ().materials;
			defaultColor = material [0].GetColor (obj.name);
			material [0].color = new Color (0,255,0,255);
			changeColor = true;
		}
		/*
        if (obj.tag.Equals("Cube"))
			Debug.Log("Cube");
            */
	}
	void OnpointerOut(object sender,PointerEventArgs e)
	{
		if (changeColor) {
			Material[] material = target.GetComponent<Renderer> ().materials;
			material [0].color = new Color (255, 255, 255, 255);
			changeColor = false;
		}
	}
	void OnTriggerClicked(object sender, ClickedEventArgs e)
	{
		if (target != null)
		{
			if(target.tag.Equals("Exit"))
				Application.Quit();
			if (target.tag.Equals ("Scence1"))
				SceneManager.LoadScene (1);
			if (target.tag.Equals ("Scence2"))
				SceneManager.LoadScene (2);
			if (target.tag.Equals ("Scence2Start")) {
				check = target;
				target.SendMessage ("StartTest");
			}
			if(target.tag.Equals("Untagged")){
				if(check!=null)
					check.SendMessage("CheckCorrect",1);
			}

			if (target.tag.Equals ("12")) {
				OnGUI ();
			}
				

			Debug.Log(target.tag);
		}
	}

	void OnGUI(){
		GUI.TextArea (new Rect (10, 10, 100, 100), "asdfad", 100);
	}
}
