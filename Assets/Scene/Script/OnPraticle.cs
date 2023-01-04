using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnPraticle : MonoBehaviour
{

    private Rigidbody body;
    private int Rock;



    private void OnParticleCollision(GameObject other)
    {
        if(other.tag == "Rock")
        {
            Rock--;
            body = other.GetComponent<Rigidbody>();
            randomWaterForce(body);
            body.useGravity = true;

        }
    }

    private void randomWaterForce(Rigidbody body)
    {
        int ran = Random.Range(50, 60);
        body.AddForce(0, ran * 3.5f, -ran);
    }
}
