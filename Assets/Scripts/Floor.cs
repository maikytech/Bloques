using UnityEngine;
using System.Collections;

public class Floor : MonoBehaviour
{
	public Lives liveClassReference;				//Referencia a la Clase Lives.

	void OnTriggerEnter()
	{
		liveClassReference.loseLive ();				//Se llama al metodo publico "loseLive" de la clase "Lives".
	}
}
