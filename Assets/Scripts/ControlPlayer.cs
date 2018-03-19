using UnityEngine;
using System.Collections;


public class ControlPlayer : MonoBehaviour
{
	public VirtualControl RightButtonReference;			//Referencia a la clase VirtualControl para el control derecho.
	public VirtualControl LeftButtonReference;			//Referencia a la clase VirtualControl para el control izquierdo.

	private Vector3 initialPosition;

	void startGame()		//Condiciones iniciales del game.
	{
		initialPosition = transform.position;		//Posicion inicial.
	}

	void Movement ()		//Funcion que controla los movimientos del Player.
	{
		float speed = 20f;

//		float direction;			//Variable que controla la direccion hacia donde el Player quiere mover la barra.
//
//		if (RightButtonReference.isPressed)
//		{
//			
//			direction = 1;				//Se movera hacia la derecha
//
//		} else if (LeftButtonReference.isPressed)
//			{
//
//				direction = -1;				//Se movera hacoa la izquierda.
//
//			} else
//				{
//			
//					direction = Input.GetAxisRaw ("Horizontal");
//
//				}

		//Este codigo resumen todo el codigo anterior comentado.
		//Se le da prioridad a los controles virtuales.
		//"direction" controla la direccion hacia donde el Player quiere mover la barra.
		float direction = LeftButtonReference.isPressed ? -1 : (RightButtonReference.isPressed ? 1 : Input.GetAxisRaw ("Horizontal"));

		// GetAxisRaw tiene tres valores: -1, 0 y 1, a diferencia de GetAxis el cual de manera gradual llega a esos valores.
		//float keyRightLeft = Input.GetAxisRaw ("Horizontal");

		//deltaTime es el tiempo que transcurrido en el ultimo frame, obviamente es mucho menos de un segundo.
		float positionPlayer = transform.position.x + (direction * speed * Time.deltaTime);

		//Clamp limita el movimiento entre un valor minimo y un valor maximo.
		transform.position = new Vector3 (Mathf.Clamp(positionPlayer, -8, 8), transform.position.y, transform.position.z);
	}

	public void Reset()
	{
		transform.position = initialPosition;

	}


	void Start ()
	{
		startGame ();
	}
	

	void Update ()
	{
		Movement ();
	}
}
