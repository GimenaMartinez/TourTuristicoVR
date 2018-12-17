using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Opciones : MonoBehaviour {

public	GameObject Panel;
	public GameObject Ubicacion;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void panel()
	{
		Panel.SetActive(true);
	}

	public void ubicacion()
	{
		Ubicacion.SetActive(true);
	}
	public void ubicacionExit()
	{
		Ubicacion.SetActive(false);
	}
}
