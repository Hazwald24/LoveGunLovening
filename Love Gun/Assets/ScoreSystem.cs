using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    public static int scoreAmount;
    public Text scoreText;


    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score: " + scoreAmount;
        
        scoreAmount = 0;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScore()
    {
        scoreAmount = StaticStatTracker.sts_enemieskilled + StaticStatTracker.sts_checkpoints + StaticStatTracker.sts_cookiespickedup;
        scoreText.text = "Score: " + scoreAmount;

    }
}
