﻿using UnityEngine;
using System.Collections;

public class Goal : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D( Collision2D Col )
	{
		if( Col.transform.name == "Physi" )
		{
			Application.LoadLevel( "Clear" );
		}
	}

}
