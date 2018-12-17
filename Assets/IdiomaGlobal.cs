using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class IdiomaGlobal : MonoBehaviour {
	public static string IdiomaActual = "Español";
	public Toggle toggleEspañol;
	public Toggle toggleIngles;
	
	public bool EsEscenaMenu=true;

	public string RetornaIdioma(){
		return(IdiomaActual);
	}
	void Start(){
		CambiarIdioma (IdiomaActual);
	}
	public void CambiarIdioma(string idioma){
		IdiomaActual = idioma;
		NotificationCenter.DefaultCenter ().PostNotification (this, "CambiarIdioma_"); 

		if (EsEscenaMenu) {
			if (idioma == "Español") {
			
				toggleEspañol.isOn = true;

			} else if (idioma == "Ingles") {
				
				toggleIngles.isOn = true;
			} 
		}

	}

}
