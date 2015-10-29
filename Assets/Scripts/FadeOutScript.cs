using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FadeOutScript : MonoBehaviour {

	public float fadeTime;
	private Image fadePannel;
	private Color currColor = Color.black;
	// Use this for initialization
	void Start () {
		fadePannel = GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.timeSinceLevelLoad < fadeTime) {

			float changeAlpha =Time.deltaTime/fadeTime;
			currColor.a -= changeAlpha;
			fadePannel.color = currColor;
		} else {
			gameObject.SetActive(false);
		}
	}
}
