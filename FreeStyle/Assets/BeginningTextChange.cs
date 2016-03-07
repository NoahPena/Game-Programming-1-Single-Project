using UnityEngine;
using System.Collections;

public class BeginningTextChange : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (GameObject.Find ("TeleportBackTriggerExit").GetComponent<TeleportPlayerBack> ().passed) 
		{
			gameObject.SetActive (false);
		}
	}
}
