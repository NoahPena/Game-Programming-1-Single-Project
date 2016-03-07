using UnityEngine;
using System.Collections;

public class TeleportPlayerBack : MonoBehaviour 
{
	public GameObject trigger;
	public GameObject floor;

	public bool passed = false;
	float wallX = -35.46277f;
	float newWallX = 482.07f;

	GameObject player;


	// Use this for initialization
	void Start () 
	{
		player = GameObject.Find ("Player");
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (passed) 
		{

		}
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject == GameObject.Find ("Player")) 
		{
			Debug.Log ("Yas");
			passed = true;
		} 
	}

	void OnTriggerStay(Collider other)
	{
			
	}

	void OnTriggerExit(Collider other)
	{
		Vector3 difference = player.transform.position - GameObject.Find ("OldWall").transform.position;
		
		Debug.Log (Mathf.Abs(difference.x));

		if (!GameObject.Find ("Selected").GetComponent<Renderer> ().isVisible) 
		{
			//Teleport Player Back
			Debug.Log(Vector3.Distance(player.transform.position, GameObject.Find("OldWall").transform.position));
			player.transform.position = new Vector3(Mathf.Abs(difference.x) + newWallX, 1.262f, -146.81f);
		}
			
	}
}
