using UnityEngine;
using System.Collections;

public class VisibleWallToInvisible : MonoBehaviour 
{

	public GameObject lookObject;
	public GameObject actionObject;
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

		RaycastHit hit;
		Vector3 cameraCenter = Camera.main.ScreenToWorldPoint (new Vector3 (Screen.width / 2, Screen.height / 2, Camera.main.nearClipPlane));

		if (Physics.Raycast (cameraCenter, moveDirection, out hit, 100)) 
		{
			if (hit.transform.gameObject == lookObject && !once && player.transform.position.x < actionObject.transform.position.x) 
			{
				once = true;

				actionObject.SetActive (false);
			}
		}
	}
}
