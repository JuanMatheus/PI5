using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using admob;

public class MenuScene : MonoBehaviour 
{
	private CanvasGroup fadeGroup;
	private float fadeInSpeed = 0.33f;

	// Use this for initialization
	private void Start () 
	{
		fadeGroup = FindObjectOfType<CanvasGroup> ();

		//fadeGroup.alpha = 1;
	}
	
	// Update is called once per frame
	private void Update () 
	{
		//fadeGroup.alpha = 1 - Time.timeSinceLevelLoad * fadeInSpeed;
		
	}
	public void OnPlayClick()
	{
		SceneManager.LoadScene ("cena1");
        //Admana.Instance.ShowVideo();
	}
	public void OptionClick()
	{

		SceneManager.LoadScene ("Option");
        //AdMenager.Instance.ShowBanner();
    }
	public void ExitClick()
	{
		Application.Quit ();
	}
}
