using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graph : MonoBehaviour {
    public Transform pointPrefab;
    // Use this for initialization
    void Awake()
    {
        for (int i = 0; i < 10; i++)
        {
            //i = i + 1;
            Transform point = Instantiate(pointPrefab);
            point.localPosition = Vector3.right*i;
            point.localScale = Vector3.one / 5f;
        }
       
       // point.localPosition = Vector3.right * 2f;
    }
    void Start () {
		
	}
	
	
	void Update () {
		
	}
}
