using UnityEngine;
using System.Collections;

public class Sounds : MonoBehaviour
{
	public AudioSource audioSourceReference;		//Referencia al componente Audiosource.
	public AudioClip gameComplete;					//Referencia al audio de Game Complete.
	public AudioClip gameOver;						//Referencia al audio de Game Over.

	public void  GameOverAudio()
	{
		PlaySound (gameOver);						//Se llama al metodo PlaySound con el audioclip correspondiente como parametro.
	}

	public void  GameCompleteAudio()
	{
		PlaySound (gameComplete);					
	}

	void PlaySound(AudioClip sound)
	{
		audioSourceReference.clip = sound;		//Se asigna el audio correspondiente.
		audioSourceReference.loop = false;		//Se quita la opcion loop.
		audioSourceReference.Play ();
	}
}
