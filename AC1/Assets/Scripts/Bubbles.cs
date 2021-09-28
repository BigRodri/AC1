using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubbles : MonoBehaviour {

    ParticleSystem particle;

	void Start () {
        particle = GetComponent<ParticleSystem>();
        InvokeRepeating("Play", 0, Random.Range(2, 5));
	}
	
	void Play()
    {
        particle.Play();
    }
}
