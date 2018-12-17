using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Texto1 : MonoBehaviour {

	
	public AudioSource AudioControl;
	public AudioClip Español;
	public AudioClip Ingles;
	public AudioClip audio;
	public GameObject ButtonImage;


	public IdiomaGlobal idiomaGlobal;

	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter ().AddObserver (this, "CambiarIdioma_");
		CambiarIdioma_ ();
	}
	
	// Update is called once per frame
	void Awake () {
		idiomaGlobal = GameObject.Find ("Scripts").GetComponent<IdiomaGlobal>();
	}


	public void CambiarIdioma_(){
		if (idiomaGlobal.RetornaIdioma () == "Español") {

			AudioControl.clip = audio;
				AudioControl.Play();
			AudioEspañol();
		}
		if (idiomaGlobal.RetornaIdioma () == "Ingles") {

			AudioControl.clip = audio;
			AudioControl.Play();
			AudioIngles();


		}
	

	}
	public void AudioEspañol()
	{
		AudioControl.clip = Español;
		AudioControl.Play();
	}
	public void AudioIngles()
	{
		AudioControl.clip = Ingles;
		AudioControl.Play();
	}
}
