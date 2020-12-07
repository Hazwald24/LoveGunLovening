using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour
{

    private bool BotADead = false;
    private bool BotBDead = false;
    private bool BotCDead = false;
    public AudioSource playSound;
    public ScoreSystem scoreSystemref;


    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindWithTag("Bot A") == null)
           { BotADead = true; }
        if (GameObject.FindWithTag("Bot B") == null)
        { BotBDead = true; }
        if (GameObject.FindWithTag("Bot C") == null)
        { BotCDead = true; }

        if (BotADead && BotBDead && BotCDead)
        {
            StaticStatTracker.sts_checkpoints = StaticStatTracker.sts_checkpoints + 5;
            scoreSystemref.UpdateScore();
            Destroy(GameObject.FindWithTag("Door1"));
            playSound.Play();
            playSound.Play();
        }
    }
    
    
}
