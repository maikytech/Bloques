using UnityEngine;
using UnityEngine.SceneManagement;			//Libreria para el manejo de escenas.
using System.Collections;


public class GetOut : MonoBehaviour
{
	public bool getOut;					//Variable que referencia si queremos salir del juego, sera verdadero si estamos en Intro y falso si estamos en otro nivel.

	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Escape))		//Si se presiona la tecla "Escape" del teclado....
		{	
			if (getOut)								//Si getOut es true...
			{
				Debug.Log ("Salir del game");
				Application.Quit ();					//Salir del game.

			} else {

				SceneManager.LoadScene ("Intro");	//Se carga la escena de Introduccion.

			}

		}

	
	}
}
