using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cronometro : MonoBehaviour {

	public float tiempo_start = 0.0f;
	public float tiempo_end = 0.0f;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		tiempo_start += Time.deltaTime;
		if (tiempo_start >= tiempo_end) //Si pasan los segundos que hemos puesto antes...
		{
			SceneManager.LoadScene("MenuPrincipal"); //Iremos a la escena que hemos puesto anteriormente.
		}
	}
}
