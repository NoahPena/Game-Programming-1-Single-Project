using UnityEngine;
using System.Collections;

public class ChangeColorIfLookedAt : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{

	}

	// Update is called once per frame
	void Update () 
	{
		Vector3 moveDirection = Camera.main.transform.forward;

		Debug.Log (moveDirection);

		RaycastHit hit;
		Vector3 CameraCenter = Camera.main.ScreenToWorldPoint (new Vector3 (Screen.width / 2, Screen.height / 2, Camera.main.nearClipPlane));
		if (Physics.Raycast(CameraCenter,  Camera.main.transform.forward, out hit, 100))
		{
			if(Camera.main.transform.forward.y >= .9)
			{
				GameObject hitObject = hit.transform.gameObject;
					
				if(hitObject == gameObject)
				{
					gameObject.GetComponent<Renderer> ().material.color = Color.blue;
				}
			}
			else
			{
				gameObject.GetComponent<Renderer>().material.color = Color.white;
			}
		}

	}
}
