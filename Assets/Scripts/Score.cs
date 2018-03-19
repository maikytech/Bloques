using UnityEngine;
using UnityEngine.UI;						//Libreria para el manejo de elementos de UI.
using System.Collections;

public class Score : MonoBehaviour
{
	public static int score = 0;							//Variable estatica o de clase que referencia el puntaje.
	public Text textLabelScore;								//Referencia al texto del label Score.
	public GameObject LevelCompleteGameObject;				//Referencia al game object del objeto LevelComplete.
	public GameObject GameCompleteGameObject;				//Referencia al game object del objeto GameComplete.
	public Next nextClassReference;							//Referencia a la clase Next.
	public ControlBall controlBallClassReference;			//Referencia a la clase "ControlBall".
	public Transform BlocksTransformReference;				//Referencia al Transform del objeto que contiene todos los bloques.
	public ControlPlayer controlPlayerClassReference;		//Referencia a la clase "ControlPlayer".	
	public Sounds SoundsClassReference;						//Referencia a la clase GameOverSounds.

	void UpdateScore()
	{
		textLabelScore.text = "Score: " + Score.score;
	}

	public void EarnPoints()			//Metodo publico para sumar los puntos.
	{
		Score.score++;					//Suma un punto.
		UpdateScore();					//Se llama al metodo UpdateScore.

		if(BlocksTransformReference.childCount <= 0)				//Si la cantidad de bloques es menor o igual a cero.
		{
			controlBallClassReference.FinalLevel();					//Se llama al metodo FinalLevel de la clase ControlBall.
			controlPlayerClassReference.enabled = false;			//Se desactiva el script que contiene la clase ControlPlayer.
			SoundsClassReference.GameCompleteAudio();		//Se coloca el audio de nivel completado.

			if (nextClassReference.LastLevel ())			//Se comprueba si el siguiente nivel es el ultimo.
			{
				GameCompleteGameObject.SetActive (true);	//Activamos el objeto GameComplete.
			}else
			{
				LevelCompleteGameObject.SetActive (true);				//Activamos el objeto LevelComplete.
			}

			nextClassReference.ActivateLoad ();				//Carga el siguiente nivel o la introduccion.
		}
	}

	void Start ()
	{
		UpdateScore ();					//Se llama al metodo "UpdateScore".
	}
	

}
