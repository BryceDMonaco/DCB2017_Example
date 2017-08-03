/*
 *	Author: Bryce Monaco
 *	Last Updated: 6/4/17
 *
 *	Description: A simple distance script, acts like a visual metal detector
 *
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyFinder : MonoBehaviour 
{
	public float maxDistance = 50f;
	public Slider slider;
	public bool keyFound = false;

	public Transform target; //Should be the key

	void Start () 
	{
		
	}
	
	void Update () 
	{
		
	}

	void FixedUpdate ()
	{
		if (!keyFound)
		{
			slider.value = 1 - CalculateDistance ();

		}
	}

	float CalculateDistance ()
	{
		Vector3 distVector = target.position - transform.position;
		float distance = distVector.magnitude;

		return (distance / maxDistance);

	}

	public void KeyFound ()
	{
		slider.value = 0f;

		keyFound = true;

	}
}
