using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject door;
    public int bodiesNeeded;
    // Update is called once per frame
    void Update()
    {
        if(StaticStatTracker.sts_enemieskilled >= bodiesNeeded && door != null)
        {
            Destroy(door);
        }
        Debug.Log(StaticStatTracker.sts_enemieskilled);
    }
}
