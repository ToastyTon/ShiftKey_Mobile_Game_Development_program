using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour {
    public Transform hoursTransform;
    public Transform minutesTransform;
    public Transform secondsTransform;
    // Use this for initialization

    void Awake()
    {
        Debug.Log(Time.time); 
    }
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
