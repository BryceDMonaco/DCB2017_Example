/*
 *	Author: Bryce Monaco
 *	Last Updated: 6/4/17
 *
 *	Description: A simple script to respawn the player if they reach a certain boundary
 *
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour 
{
	public int heightLimit = -10; //If the player goes lower than this teleport them back
	public Transform spawnPoint; 
	public Transform myPlayer;

	void Start () 
	{
		
	}
	
	void Update () 
	{
		if (myPlayer.position.y < heightLimit)
		{
			myPlayer.transform.position = spawnPoint.position;

		}

	}

	void OnTriggerEnter (Collider player)
	{
		player.transform.position = spawnPoint.position;

	}
}
