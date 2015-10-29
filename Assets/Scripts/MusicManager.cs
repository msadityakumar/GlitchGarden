using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {

	// Use this for initialization
	public AudioClip [] levelMusicArray;

	void Awake ()
	{
		DontDestroyOnLoad (gameObject);
	
	}
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnLevelWasLoaded(int level)
	{
		AudioClip audio = levelMusicArray [level];
		AudioSource audioSource = gameObject.GetComponent<AudioSource> ();

		if (audio) {
			audioSource.clip = audio;
			audioSource.loop = true;
			audioSource.Play();
		}


	}
}
