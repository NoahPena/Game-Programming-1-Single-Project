using UnityEngine;
using System.Collections;

public class TeleportPlayer : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.P)) 
		{
			//Debug.Log ("Pressed");

			Camera.main.transform.LookAt (GameObject.Find ("cliff").transform);

			//GameObject.Find("Player").transform.Rotate (GameObject.Find("Player").transform.rotation.x, GameObject.Find("Player").transform.rotation.y, 180);
//			GameObject.Find ("Player").transform.position = new Vector3 (35, 100, 5);

		}
	}
}
