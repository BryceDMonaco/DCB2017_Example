/*
 *	Author: Bryce Monaco
 *	Last Updated: 6/4/17
 *
 *	Description: Simple script to unlock a locked door, needs a corresponding key object
 *
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Door : MonoBehaviour 
{
	public Image keyImage;
	public bool keyFound = false;
	public ParticleSystem confetti;

	void Start () 
	{
		
	}
	
	void Update () 
	{

	}

	public void KeyFound (bool state)
	{
		keyFound = state;

	}

	void OnTriggerEnter (Collider col)
	{
		if (col.CompareTag("Player") && keyFound)
		{
			gameObject.SetActive (false);
			keyImage.enabled = false;

			confetti.Emit (Random.Range (100, 300));

		}
	}
}
