using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 

public class ActivacionDeAudio : MonoBehaviour {

    public GameObject ButtonImage;
    public AudioClip Entrar2;
    public AudioClip Salir;
    public AudioSource AudioControl;
	public Collision colision;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void EscenaValleGrande()
    {
		
		SceneManager.LoadScene("ValleEscena1");
       
    }

    public void EscenaElNihuil()
    {
        
        SceneManager.LoadScene("NihuilEscena1");
       

    }
	public void EscenaLosReyunos()
	{

		SceneManager.LoadScene("LosReyunosEscena2");


	}

	public void AudioEntrar()
    {
        AudioControl.clip = Entrar2;
        AudioControl.Play();
    }

    public void AudioSalir()
    {
        AudioControl.clip = Salir;
        AudioControl.Play();
    }
}
