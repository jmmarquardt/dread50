using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneOnInput : MonoBehaviour 
{
	private Scene currentScene;
	private Scene titleScene;

	void Start () {
		currentScene = SceneManager.GetActiveScene();
		titleScene = SceneManager.GetSceneByName("Title");
	}
	
	// Update is called once per frame
	void Update () {
		currentScene = SceneManager.GetActiveScene();
		
		if (Input.GetAxis("Submit") == 1) 
		{
			if (currentScene == titleScene) 
			{
				SceneManager.LoadScene("Play");
			}
			else
			{
				SceneManager.LoadScene("Title");
			}
		}
	}
}
