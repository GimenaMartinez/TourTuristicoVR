using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using UnityEngine.SceneManagement;

public class ApplicationTest {

	[UnityTest]
	public IEnumerator CargarEscena()
	{

		if (Application.CanStreamedLevelBeLoaded("ValleEscena1"))
		{
			yield return new WaitForSeconds(3);

			SceneManager.LoadScene("ValleEscena1");
			Debug.Log("La escena se cargo corectamente");

			yield break;

		}
		Assert.Fail("La escena no fue cargada correctamente");
	}

	[UnityTest]
	public IEnumerator Posicion()
	{
		SetupScene2();
		Vector3 myVector = new Vector3(0f, 1f, 0f);
		Vector3 pos = GameObject.Find("Bote(Clone)").transform.position;
		
		if (pos == myVector)
		{
			Debug.Log("Posicion del objeto Correcta");
			yield break;
		}

		Assert.Fail("Posicion del objeto Incorrecta");
	}
	void SetupScene2()
	{
		MonoBehaviour.Instantiate(Resources.Load<GameObject>("Bote"));
	}

	[UnityTest]
	public IEnumerator ExistenciaDeObjetos()
	{
		SetupScene();

		SceneManager.LoadScene("ValleEscena1");

		var bote = GameObject.FindGameObjectWithTag("Bote");
		//string myPath = AssetDatabase.GetAssetPath(esfera);
		//Debug.Log(esfera.tag);
		if (bote && bote.activeSelf)
		{
			Debug.Log("Existe" + bote.tag);
			Debug.Log("Esta Activo: " + bote.activeSelf);
		
			yield break;
		}
		else if (bote == null || !bote.activeSelf)
		{

			Assert.Fail("El objeto puede que no este activo o no exista en la escena");
			yield break;
		}
		yield break;
	}
	void SetupScene()
	{
		MonoBehaviour.Instantiate(Resources.Load<GameObject>("Bote"));
		
	}



	[UnityTest]
	public IEnumerator Colision()
	{
		SetupScene4();
		GameObject.Find("Main Camera(Clone)").transform.position = new Vector3(0.002569723f, 0.01298145f, 0.06540383f);
		GameObject.Find("Main Camera(Clone)").transform.rotation = Quaternion.Euler(-10.2f, 2.25f, 0f);

		yield return new WaitForSeconds(5);
		GameObject boton = GameObject.Find("Boton(Clone");
		yield return new WaitForSeconds(5);
		if (boton != null)
		{
			Debug.Log("Paso de escena");
			yield break;

		}

		Assert.Fail("Error al pasar de escena");

	}
	void SetupScene4()
	{
		MonoBehaviour.Instantiate(Resources.Load<GameObject>("Boton"));
		MonoBehaviour.Instantiate(Resources.Load<Camera>("Main Camera"));

	}

}




