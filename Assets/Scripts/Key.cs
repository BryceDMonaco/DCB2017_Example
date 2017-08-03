/*
 *	Author: Bryce Monaco
 *	Last Updated: 6/4/17
 *
 *	Description: A simple script added to a key object, needs an accompanying door object
 *
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Key : MonoBehaviour 
{
	public Door targetDoor;
	bool keyFound = false;
	public Image keyImage;
	public KeyFinder finder;

	public Transform[] spawnPoints;

	void Start () 
	{
		transform.position = spawnPoints [Random.Range (0, spawnPoints.Length)].position;

	}
	
	void Update () 
	{

	}

	void OnTriggerEnter (Collider col)
	{
		keyFound = true;
		targetDoor.KeyFound (true);

		keyImage.enabled = true;
		gameObject.SetActive(false);

		finder.KeyFound ();

	}
}
