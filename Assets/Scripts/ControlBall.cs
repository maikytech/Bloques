using UnityEngine;
using System.Collections;

public class ControlBall : MonoBehaviour
{
	public Rigidbody rigidbodyBall;					//Referencia al rigidbody del Ball.
	public float initialSpeed = 600f;				//Velocidad inicial.
	public Transform playerTransform;				//Referencia al GameObject del player
	public VirtualControl touchScreenReference;		//Referncia a la clase "VirtualControl" que controla el elemento de UI "TouchScreen". 

	private bool activeGame;
	private Vector3 initialPositionBall;		//Referencia a la posicion inicial del Ball.


	public void startGameBall()
	{
		initialPositionBall = transform.position;		//Posicion inicial.
	}

	void beginGame()
	{
		//Si el game no esta activo y se oprime la tecla "Fire1" o se toca la pantalla tactil...
		if (!activeGame && (Input.GetButtonDown ("Fire1") || touchScreenReference.isPressed))	
		{
			activeGame = true;								//Se activa el juego.
			transform.SetParent(null);						//Se quita la herencia a Ball.
			rigidbodyBall.isKinematic = false;				//Se quita la cualidad kinematic a Ball.
			rigidbodyBall.AddForce(new Vector3(initialSpeed, initialSpeed, 0));		//Se adiciona una fuerza al Ball.
		}

	}

	public void FinalLevel()							//Metodo publico que configura el final del nivel.
	{
		rigidbodyBall.isKinematic = true;				//Se agrega la cualidad kinematic a Ball.
		rigidbodyBall.velocity = Vector3.zero;			//Velocity modifica la velocidad instantaneamente.
	}
		
	public void Reset()
	{
		transform.position = initialPositionBall;		//Se hace reset a la posicion inicial.
		transform.SetParent (playerTransform);			//Ball se hace hija de Player.
		activeGame = false;								//Colocamos activeGame a false.
		FinalLevel();									//Se llama al metodo FinalLevel.

	}

	void Awake()		//Metodo para colocar las referencias a los componentes.
	{
		rigidbodyBall = GetComponent<Rigidbody> ();		//Se asigna el componente Rigidbody.
		playerTransform = transform.parent;				//Referenciamos el componente Transform del Player
	}

	void Start ()
	{
		startGameBall ();
	}


	void Update ()
	{
		beginGame ();
	
	}
}
	