using UnityEngine;
using System.Collections;

public class PickUp : MonoBehaviour {

	void OnCollisionEnter(Collision other) {
		if (other.collider.tag.Equals("Player")){
			Destroy(gameObject);
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}
}
