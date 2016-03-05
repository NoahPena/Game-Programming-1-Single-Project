using UnityEngine;
using System.Collections;

public class FlipOrientation : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		bool grounded = gameObject.GetComponent<RigidBodyFPSWalker> ().grounded;
		Ray topLeft = Camera.main.ViewportPointToRay (new Vector3(0, 0, 0));
		Ray topRight = Camera.main.ViewportPointToRay (new Vector3(1, 0, 0));
		Ray botRight = Camera.main.ViewportPointToRay (new Vector3(1, 1, 0));
		Ray botLeft = Camera.main.ViewportPointToRay (new Vector3(0, 1, 0));
		Vector3 cameraCenter = Camera.main.ScreenToWorldPoint (new Vector3 (Screen.width / 2, Screen.height / 2, Camera.main.nearClipPlane));

		RaycastHit topLeftHit;
		RaycastHit topRightHit;
		RaycastHit botRightHit;
		RaycastHit botLeftHit;
		RaycastHit middle;

		if (Physics.Raycast (cameraCenter, Camera.main.transform.forward, out middle, 100)
		    && Physics.Raycast (topLeft, out topLeftHit) && Physics.Raycast (topRight, out topRightHit)
		    && Physics.Raycast (botLeft, out botLeftHit) && Physics.Raycast (botRight, out botRightHit)) {
			Debug.Log (Camera.main.transform.forward.y);

			if ((Camera.main.transform.forward.y >= .9) && grounded && gameObject.GetComponent<RigidBodyFPSWalker>().gravity == 10f) {
				GameObject topLeftObject = topLeftHit.transform.gameObject;
				GameObject topRightObject = topRightHit.transform.gameObject;
				GameObject botRightObject = botRightHit.transform.gameObject;
				GameObject botLeftObject = botLeftHit.transform.gameObject;
				GameObject middleObject = middle.transform.gameObject;

				if (topLeftObject == topRightObject && topRightObject == botRightObject && botRightObject == botLeftObject && botLeftObject == middleObject) {
					gameObject.GetComponent<RigidBodyFPSWalker> ().gravity = -10f;

					//middleObject.GetComponent<Renderer> ().material.color = Color.blue;
					gameObject.transform.position = new Vector3 (gameObject.transform.position.x, (middleObject.transform.position.y - (gameObject.GetComponent<CapsuleCollider>().height/2) - 
						gameObject.transform.position.y) + gameObject.transform.position.y, gameObject.transform.position.z);
				}
			} else if ((Camera.main.transform.forward.y <= -.9) && grounded && gameObject.GetComponent<RigidBodyFPSWalker>().gravity == -10f) {
				GameObject topLeftObject = topLeftHit.transform.gameObject;
				GameObject topRightObject = topRightHit.transform.gameObject;
				GameObject botRightObject = botRightHit.transform.gameObject;
				GameObject botLeftObject = botLeftHit.transform.gameObject;
				GameObject middleObject = middle.transform.gameObject;

				if (topLeftObject == topRightObject && topRightObject == botRightObject && botRightObject == botLeftObject && botLeftObject == middleObject) {
					gameObject.GetComponent<RigidBodyFPSWalker> ().gravity = 10f;

					//middleObject.GetComponent<Renderer> ().material.color = Color.blue;
					gameObject.transform.position = new Vector3 (gameObject.transform.position.x, (gameObject.transform.position.y + (gameObject.GetComponent<CapsuleCollider>().height/2) +
						middleObject.transform.position.y) - gameObject.transform.position.y, gameObject.transform.position.z);
				}
			}
		}
	}
}
