using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour {

    Vector3 startingPosition;

    void Start()
    {
        startingPosition = gameObject.transform.position;    
    }

    // Update is called once per frame
    void Update () {
        float timeValue = Time.time;
        transform.position = new Vector3(startingPosition.x, Mathf.PingPong(timeValue, 16) + 7.5f, startingPosition.z);
    }
}
