using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graph : MonoBehaviour {
    public Transform pointPrefab;
    // Use this for initialization
    void Awake()
    {
     Transform point =   Instantiate(pointPrefab);
        point.localPosition = Vector3.right;
    }
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
