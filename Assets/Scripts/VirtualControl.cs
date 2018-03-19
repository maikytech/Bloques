using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;			//Libreria para el manejo de eventos.

//IPointerDownHandler y IPointerUpHandler son una interfaces para el manejo de eventos.
public class VirtualControl : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
	public bool isPressed;

	//Implementacion de una de las funciones de la interface.
	public void  OnPointerDown(PointerEventData eventData)
	{
		isPressed = true;				//Es true si el usuario pulso el boton.
	}

	public void OnPointerUp(PointerEventData eventData)
	{
		isPressed = false;
	}
}
	