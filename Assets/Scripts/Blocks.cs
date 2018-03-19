using UnityEngine;
using System.Collections;

public class Blocks : MonoBehaviour
{
	public GameObject particleSystemGameObject;			//Referencia publica al sistema de particulas.
	public Score scoreClassReference;					//Referencia a la clase Score.

	void OnCollisionEnter()								//Detecta si se genera una colision.
	{
		//Instanciamos el sistema de particulas y le colocamos la posicion y la rotacion del bloque.
		//Quaternion.identity nos configura la rotacion por defecto.
		Instantiate (particleSystemGameObject, transform.position, Quaternion.identity);

		//Se destruye el bloque, esta instruccion no importa donde se coloque, siempre se realiza al final del fotograma.
		Destroy (gameObject);
		transform.SetParent (null);						//El bloque deja de ser hijo de Blocks.
		scoreClassReference.EarnPoints ();				//Se llama al metodo que suma los puntos.



	}
		

}
