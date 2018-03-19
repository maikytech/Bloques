using UnityEngine;
using System.Collections;

public class SoundsBall : MonoBehaviour
{
	public AudioSource bounceSound;				//Referencia al sonido de rebote;
	public AudioSource destroyBlockSound;		//Referencia al sonido al destruir los bloques.
	public AudioSource loseLiveSound;			//Referencia al sonido de perder una vida.

	void OnCollisionEnter(Collision other)		//Collision es un objeto de una clase que describe los parametros de colision del objeto que colisiona.
	{
		if (other.gameObject.CompareTag ("Blocks")) 	//Si el objeto con el que colsiono Ball tiene la etiqueta "Blocks"...
		{												//CompareTag devuelve un objeto tipo bool.	
			destroyBlockSound.Play();						//Reproduce el audio de destruccion de los bloques.

		} else
			{
				bounceSound.Play();						//Reproduce el audio de destruccion de los bloques.
			}
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("floor")) 		//Si el objeto con el que colsiono Ball tiene la etiqueta "floor"...
		{												//CompareTag devuelve un objeto tipo bool.	
			loseLiveSound.Play();						
		}
	}
}
