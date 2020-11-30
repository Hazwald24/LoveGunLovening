using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door2 : MonoBehaviour
{

    private bool BotDDead = false;
    private bool BotEDead = false;
    private bool BotFDead = false;
    public AudioSource playSound;


    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindWithTag("Bot D") == null)
        { BotDDead = true; }
        if (GameObject.FindWithTag("Bot E") == null)
        { BotEDead = true; }
        if (GameObject.FindWithTag("Bot F") == null)
        { BotFDead = true; }

        if (BotDDead && BotEDead && BotFDead)
        { Destroy(GameObject.FindWithTag("Door2"));
            playSound.Play();
        }
    }

}
