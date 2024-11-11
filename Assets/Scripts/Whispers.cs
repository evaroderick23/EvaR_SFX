using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Whispers : MonoBehaviour
{
    public AudioSource PSPSPSPSPS;

    private void OnTriggerEnter(Collider other)
    {
        PSPSPSPSPS.Play();
    }

    private void OnTriggerExit(Collider other)
    {
        PSPSPSPSPS.Stop();
    }
}
