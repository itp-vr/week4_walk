using UnityEngine;
using System.Collections;

public class FaceObject: MonoBehaviour {
	public Transform targetObj;
	//set this to true if you need to orient in the opposite dir.
	public bool flipY = true;

	
	// Use this for initialization
	void Start () {
		if (targetObj == null) {
			GameObject player = GameObject.FindGameObjectWithTag ("Player");
			if (player != null) {
				targetObj = player.transform;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (flipY) {
			transform.rotation = Quaternion.LookRotation (transform.position - targetObj.transform.position);
		} else {
			transform.LookAt (targetObj);
		}
	}
}