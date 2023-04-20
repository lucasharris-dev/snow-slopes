using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem snowTrailEffect;

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Level")
        {
            snowTrailEffect.Play();
        }
    }

    void OnCollisionExit2D()
    {
        snowTrailEffect.Stop();
    }
}
