using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graph : MonoBehaviour {
    public Transform pointPrefab;
    Transform[] points;

    [Range(10,100)]
    public int resolution = 10;

    Vector3 position;
    // Use this for initialization
    void Awake()
    {
        float step = 2f / resolution;
        
        points = new Transform[resolution];
       
        Vector3 scale = Vector3.one *step;
        
        position.x = 0f;
        position.z = 0f;

        for (int i = 0; i < points.Length; i++)
        {
            //i = i + 1;
            Transform point = Instantiate(pointPrefab);
            //point.localPosition = Vector3.right*((i+0.5f)/5f-1f);
            position.x = (i + 0.5f) *step - 1f;
           
            point.localPosition = position;
            //point.localScale = Vector3.one / 5f;
            point.localScale = scale;
            point.SetParent(transform,false);

            points[i] = point;
        }
       
       // point.localPosition = Vector3.right * 2f;
    }
    void Start () {
		
	}
	
	
	void Update () {

        position.y = Mathf.Sin(position.x);
        position.z = 0f;


        for (int i = 0; i < points.Length; i++)
        {

            Transform point = points[i];
            Vector3 position = point.localPosition;
            position.y = Mathf.Sin(Mathf.PI * (position.x + Time.time));
            point.localPosition = position;
        }
	}
}
