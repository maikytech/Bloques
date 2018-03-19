using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Next : MonoBehaviour
{
	public string levelLoad;					//Referencia al nivel cargado.
	public float delayTime;						//Tiempo de retraso.

	[ContextMenu ("ActivateLoad")]				//ContextMenu coloca una opcion en el menu del script (click derecho) en el inspector.
	public void ActivateLoad()
	{
		Invoke("LoadLevel", delayTime);			//Invoca un metodo con un tiempo de retraso.

	}

	void LoadLevel()							//Carga un nivel.
	{
		SceneManager.LoadScene (levelLoad);	

		if(!LastLevel())							//Aumenta un vida cuando se carga el nuevo nivel.
		{
			Lives.countLives++;
		}
	}

	public bool LastLevel()						//Metodo que nos indica si es el ultimo nivel.
	{
		return levelLoad == "Intro";			//Si levelLoad es igual a "Intro", el metodo retorna "true", de lo contrario retorna "false".
	}


}
