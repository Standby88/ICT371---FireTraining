using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flammable : MonoBehaviour {

    public ParticleSystem partSystem;
    int count;
    private void Start()
    {
        count = 0;
        //print("test");
    }

    private void OnParticleCollision(GameObject other)
    {
        count++;
        //print("particle collision detected " + count);
        if (count >= 100)
        {
            print("emissionrate dropped");
            partSystem.emissionRate = partSystem.emissionRate - 1.0f;

            count = 0;
        }

    }
}
