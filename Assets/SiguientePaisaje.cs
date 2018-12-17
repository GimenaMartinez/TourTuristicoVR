using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SiguientePaisaje : MonoBehaviour {
	public GameObject Panel;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnMouseUp()
	{
		Application.Quit();
		Debug.Log("Saliendo");
	}
	
	public void SalirdelaApp()
	{
		Application.Quit();
		Debug.Log("Saliendo");
	}
	public void EscenaMenuPrincipal()
	{

		SceneManager.LoadScene("MenuPrincipal");

	}
	public void EscenaElNihuil()
	{

		SceneManager.LoadScene("NihuilEscena2");

	}
	public void EscenaLosReyunos()
	{

		SceneManager.LoadScene("LosReyunosEscena1");

	}
	public void EscenaElNihuilVolver()
	{

		SceneManager.LoadScene("NihuilEscena1");

	}
	public void EscenaLosReyunosVolver()
	{

		SceneManager.LoadScene("LosReyunosEscena2");

	}
	public void EscenaValleGrandeVolver()
	{

		SceneManager.LoadScene("ValleEscena1");

	}
	public void EscenaValle()
	{

		SceneManager.LoadScene("ValleGrandeEscena2");

	}
	public void Continuar()
	{

		Panel.SetActive(false);

	}
}
