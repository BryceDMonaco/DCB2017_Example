/*
 *	Author:
 *	Last Updated:
 *
 *	Description:
 *
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleScript : MonoBehaviour 
{

	void Start () 
	{
		Renderer myRenderer = GetComponent<Renderer> ();

		myRenderer.material.color = Color.red;

	}
	
	void Update () 
	{
		
	}
}
