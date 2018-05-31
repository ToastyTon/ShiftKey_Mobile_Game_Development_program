using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Clock : MonoBehaviour {
    public Transform hoursTransform;
    public Transform minutesTransform;
    public Transform secondsTransform;

    public bool continuous;
   

    const float degreesPerHour = 30f, degreesPerMinute = 6f, degreesPersecond = 6f;
    void Awake()
    {
        //Debug.Log(DateTime.Now);
        DateTime time = DateTime.Now;
        hoursTransform.localRotation=Quaternion.Euler(0f, DateTime.Now.Hour* 30f, 0f);
        minutesTransform.localRotation = Quaternion.Euler(0f, DateTime.Now.Minute * degreesPerMinute,0f);
        secondsTransform.localRotation = Quaternion.Euler(0f, DateTime.Now.Second * degreesPersecond, 0f);
    }
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (continuous)
        {
            UpdateContinuous();
        }
        else
        {
            UpdateDiscreate();
        }

        /*DateTime time = DateTime.Now;
        hoursTransform.localRotation =  Quaternion.Euler(0f, time.Hour * degreesPerHour, 0f);
        minutesTransform.localRotation = Quaternion.Euler(0f, time.Minute * degreesPerMinute, 0f);
        secondsTransform.localRotation = Quaternion.Euler(0f, time.Second * degreesPersecond, 0f);
        */
    }

    void UpdateContinuous()
    {
        TimeSpan time = DateTime.Now.TimeOfDay;
        hoursTransform.localRotation = Quaternion.Euler(0f, (float)time.TotalHours * degreesPerHour, 0f);
        minutesTransform.localRotation = Quaternion.Euler(0f, (float)time.TotalMinutes * degreesPerMinute, 0f);
        secondsTransform.localRotation = Quaternion.Euler(0f, (float)time.TotalSeconds * degreesPersecond, 0f);
    }

    void UpdateDiscreate()
    {
        DateTime time = DateTime.Now;
        hoursTransform.localRotation = Quaternion.Euler(0f, time.Hour * degreesPerHour, 0f);
        minutesTransform.localRotation = Quaternion.Euler(0f, time.Minute * degreesPerMinute, 0f);
        secondsTransform.localRotation = Quaternion.Euler(0f, time.Second * degreesPersecond, 0f);
    }
}
