using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPressMethods : MonoBehaviour {

    public AudioClip[] clips;
    public AudioSource audioSource;

	public void PlayAudio(int index)
    {
        audioSource.clip = clips[index];
        audioSource.Play();
    }
  
}
