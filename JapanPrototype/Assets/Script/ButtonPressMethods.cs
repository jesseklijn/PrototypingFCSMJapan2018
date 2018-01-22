using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonPressMethods : MonoBehaviour {

    public AudioClip[] clips;
    public AudioSource audioSource;

	public void PlayAudio(int index)
    {
        audioSource.clip = clips[index];
        audioSource.Play();
    }

    public void SwitchScene(int i)
    {
        if(i == 2)
        {
            SceneManager.LoadScene("_AppMainScreen");
        }
        
        else if(i == 3)
        {
            SceneManager.LoadScene("_HomeMenu");
        }
        else if(i == 4)
        {
            SceneManager.LoadScene("_Profile");
        }
        else if(i == 5)
        {
            SceneManager.LoadScene("_Level");
        }
        else if(i == 6)
        {
            SceneManager.LoadScene("_ResearchMenu");
        }
        else if(i == 7)
        {
            SceneManager.LoadScene("_UniverseMenu");
        }
        else if(i == 8)
        {
            SceneManager.LoadScene("_Topic");
        }
    }
  
}
