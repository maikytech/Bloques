using UnityEngine;
using UnityEngine.SceneManagement;					//Libreria para el manejo de escenas.
using System.Collections;

public class BeginGame : MonoBehaviour
{
	public VirtualControl touchScreenReference;		//Referncia a la clase "VirtualControl" que controla el elemento de UI "TouchScreen". 

	void Update ()
	{
		if(Input.GetButtonDown("Fire1") || touchScreenReference.isPressed)	//Si se presiona la tecla de disparo o se toca la pantalla tactil....
		{
			//Resetamos los valores de puntos y vidas.
			Lives.countLives = 4;
			Score.score = 0;	

			SceneManager.LoadScene ("Level1");		//Se carga el nivel 1.

		}

	
	}
}
