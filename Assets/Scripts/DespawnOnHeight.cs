using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * This is attached to the FPS controller, and monitors the 
 * player's y position in comparison to the floor position.
 * If the Player falls through a hole, the game over scene loads.
 */
public class DespawnOnHeight : MonoBehaviour 
{

	// Update is called once per frame
	void Update () 
	{
		// check if player position is below ground
		if (transform.GetChild(0).transform.position.y < -1) 
		{
			SceneManager.LoadScene("GameOver");
			DontDestroy.currentLevel = 1;
		}
	}
}