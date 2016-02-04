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
			Debug.Log ("Pressed");
			this.transform.position.Set (this.transform.position.x, this.transform.position.y + 100, this.transform.position.z);

		}
	}
}
