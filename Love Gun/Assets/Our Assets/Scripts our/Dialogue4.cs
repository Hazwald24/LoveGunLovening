using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue4 : MonoBehaviour
{
    public AudioSource playSound;

    void OnTriggerEnter(Collider other)
    {
        playSound.Play();
        Destroy(GameObject.FindWithTag("Trig4"));
    }
}
