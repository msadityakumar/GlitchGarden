using UnityEngine;
using System.Collections;


public class LevelManager : MonoBehaviour {

	public float loadGameAfter;

	public void Start()
	{
		Debug.Log("level manager started");
		if (loadGameAfter == 0) {
		} else {
			Invoke ("loadNextLevel", loadGameAfter);
		}

	
	}

	public void LoadMenuScreen()
	{
		Application.LoadLevel ("01_Start Menu");
	
	}

	public void startGame(string Level)
	{
//		print ("\n game abt to start......");
		Application.LoadLevel (Level);
	}

	public void PlayGameAgain(string level)
	{
		print("play game again");
		Application.LoadLevel (level);
	}

	public void gameOver(string level)
	{
		Application.LoadLevel (level);

	}
	public void loadLevel(string level)
	{
		Debug.Log ("loadlevel " + level);
		Application.LoadLevel (level);

	}
	public void loadNextLevel()
	{
		Debug.Log ("loadNextlevel");
		Application.LoadLevel (Application.loadedLevel+1);
	}


}
