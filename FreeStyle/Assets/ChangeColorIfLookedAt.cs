﻿using UnityEngine;
using System.Collections;

public class ChangeColorIfLookedAt : MonoBehaviour 
{
	GameObject player;
	bool once = false;

	// Use this for initialization
	void Start () 
	{
		player = GameObject.Find ("Player");
	}

	// Update is called once per frame
	void Update () 
	{
		Vector3 moveDirection = Camera.main.transform.forward;

		//Debug.Log (moveDirection);

		RaycastHit hit;
		Vector3 CameraCenter = Camera.main.ScreenToWorldPoint (new Vector3 (Screen.width / 2, Screen.height / 2, Camera.main.nearClipPlane));
		if (Physics.Raycast(CameraCenter,  Camera.main.transform.forward, out hit, 100))
		{
			if(Camera.main.transform.forward.y >= .9)
			{
				GameObject hitObject = hit.transform.gameObject;
					
				if(hitObject == gameObject && !once)
				{
					once = true;
					Physics.gravity = new Vector3 (0, Physics.gravity.y * -1, 0);
					gameObject.GetComponent<Renderer> ().material.color = Color.blue;
					player.transform.position = new Vector3 (player.transform.position.x, 10, player.transform.position.z);

				}
			}
			else
			{
			//	gameObject.GetComponent<Renderer>().material.color = Color.white;
			//	player.transform.position = new Vector3 (player.transform.position.x, 2, player.transform.position.z);
			}
		}

	}
}
