using UnityEngine;
using System.Collections;

public class CratchCloud : MonoBehaviour {

	private Rigidbody2D RB;

	// Use this for initialization
	void Start () {
		RB = this.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

		RB.velocity /= 1.05f;
		RB.angularVelocity /= 1.05f;

	}
}
