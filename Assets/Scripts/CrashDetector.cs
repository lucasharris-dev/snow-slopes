using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float delay = 0.5f;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip crashSFX;

    bool bHasCrashed = false;


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Level" && bHasCrashed == false)
        {
            bHasCrashed = true;
            // calling a public method from the player controller script
            FindObjectOfType<PlayerController>().DisableControls();
            crashEffect.Play();
            PlayCrashSound();
            Invoke("RestartLevel", delay);
        }
    }

    void RestartLevel()
    {
        SceneManager.LoadScene(0);
    }

    void PlayCrashSound()
    {
        GetComponent<AudioSource>().PlayOneShot(crashSFX);
    }
}
