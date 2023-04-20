using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float delay = 1;
    [SerializeField] ParticleSystem finishEffect;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            finishEffect.Play();
            PlaySound();
            Invoke("RestartLevel", delay);
        }
    }

    void RestartLevel()
    {
        SceneManager.LoadScene(0);
    }

    void PlaySound()
    {
        GetComponent<AudioSource>().Play();
    }
}
