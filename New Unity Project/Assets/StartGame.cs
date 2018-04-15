using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;


public class StartGame : MonoBehaviour {
	int currentPoint=-1;
	volatile bool correct=true;
	int score=-1;
	// Use this for initialization
	void Start () {
		//ThreadPool.QueueUserWorkItem (new WaitCallback(CheckThread),1);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void StartTest(){
		//Debug.Log ("start");
		System.Random rd = new System.Random ();
		currentPoint = rd.Next (0,20);
		Debug.Log (currentPoint);
		Thread th = new Thread (new ThreadStart(CheckThread));
		th.IsBackground=true;
		th.Start ();
	}
	void CheckCorrect(int ID){
		//if(ID==currentPoint)
			correct=true;
	}
	void CheckThread(){
		while(true)
		{
			if(correct==true)
			{
				System.Random rd = new System.Random ();
				int temp = rd.Next ();
				while (temp == currentPoint)
					temp = rd.Next ();
				currentPoint = temp;
				correct=false;
				Debug.Log (currentPoint);
				score++;
			}
		}
	}
}
