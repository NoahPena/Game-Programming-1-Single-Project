using UnityEngine;
using System.Collections;

public class TeleportPlayerToLevelTwo : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void OnTriggerEnter(Collider other)
	{
		Vector3 difference = gameObject.transform.position - GameObject.Find ("MagicWall").transform.position;
		Vector3 offset = GameObject.Find ("Player").transform.position - GameObject.Find ("Ayy").transform.position;

		GameObject.Find ("Player").transform.position = new Vector3 (GameObject.Find("LMAO").transform.position.x - Mathf.Abs(offset.x) , 1.076612f, Mathf.Abs (difference.z) + GameObject.Find ("NewMagicWall").transform.position.z);
	}
}
