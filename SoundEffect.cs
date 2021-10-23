//自分で書いた
using UnityEngine;
using System.Collections;

public class SoundEffect : MonoBehaviour
{

	private AudioSource sound01;

	void Start()
	{
		sound01 = GetComponent<AudioSource>();
	}

	public void soundSE01()
	{
		sound01.PlayOneShot(sound01.clip);
	}
}