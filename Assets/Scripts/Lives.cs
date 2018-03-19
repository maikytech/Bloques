using UnityEngine;
using UnityEngine.UI;						//Libreria para el manejo de elementos de UI.
using System.Collections;

public class Lives : MonoBehaviour
{
	public static int countLives = 3;						//Variable estatica o de clase que referencia las vidas del jugador.
	public Text textLabelLives;								//Referencia al texto del label Lives.
	public ControlPlayer controlPlayerClassReference;		//Referencia a la clase "ControlPlayer".
	public ControlBall controlBallClassReference;			//Referencia a la clase "ControlBall".
	public GameObject gameoverGameObject;					//Referencia al game object del objeto GameOver.
	public Next nextClassReference;							//Referencia a la clase Next.
	public Sounds SoundsClassReference;						//Referencia a la clase GameOverSounds.

	void updateLives()
	{
		textLabelLives.text = "Lives: " + Lives.countLives;		//Se cambia el texto del lable Lives.
	}

	public void loseLive()
	{
		/*Con esta forma de colocar el if, si la condicion se cumple, el programa ejecutara todo el codigo debajo, si no, simplemente se
		 * saldra del metodo loseLive. */
		if (Lives.countLives <= 0)
			return;
		Lives.countLives--;									//Disminuye en uno la cantidad de vidas del game.
		updateLives ();										//Se llama al metodo updateLives.

		if (Lives.countLives <= 0)							//Si countLives es cero, entonces mostraremos el objeto GameOver.
		{					
			gameoverGameObject.SetActive (true);			//Activamos el objeto GameOver.
			controlBallClassReference.FinalLevel();			//Se llama al metodo FinalLevel de la clase ControlBall.
			controlPlayerClassReference.enabled = false;	//Se desactiva el script que contiene la clase ControlPlayer.
			nextClassReference.levelLoad = "Intro";
			nextClassReference.ActivateLoad();				//Se carga el metodo publico de la clase Next que cargara la Introduccion.
			SoundsClassReference.GameOverAudio();			//Se coloca el audio de Game Over.

		} else 												//De lo contrario, seguira jugando.
			{												
				controlPlayerClassReference.Reset ();		//Se llama al metodo publico "Reset" de la clase "ControlPlayer".
				controlBallClassReference.Reset ();			//Se llama al metodo publico "Reset" de la clase "ControlBall".
			}
	}

	void Start()
	{
		updateLives ();								//Se llama al metodo que actualiza el contador de vidas.
	}
}
