using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle_Player : MonoBehaviour
{
    public ParticleSystem[] particles;
    
    void PlayParticles()
    {
        foreach (var particle in particles)
        {
            particle.Play();
        }
    }
}
