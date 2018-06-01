﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fractal : MonoBehaviour {

    public int maxDepth;
    public float childScale;

    private int depth;

    public Mesh mesh;
    public Material material;
	// Use this for initialization
	void Start () {
        gameObject.AddComponent<MeshFilter>().mesh = mesh;
        gameObject.AddComponent<MeshRenderer>().material = material;
        if (depth<maxDepth)
        {
            StartCoroutine(CreateChildren());
            //new GameObject("Fractral Child").AddComponent<Fractal>().Initialiaze(this,Vector3.up);
           // new GameObject("Fractal Child").AddComponent<Fractal>().Initialiaze(this, Vector3.right);
        }
       
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private static Vector3[] childDirections =
    {
        Vector3.up,Vector3.right,Vector3.left,Vector3.forward,Vector3.back
    };

    private static Quaternion[] childOrientations =
    {
        Quaternion.identity,
        Quaternion.Euler(0f,0f,-90f),
        Quaternion.Euler(0f,0f,90f),
        Quaternion.Euler(90f,0f,0f),
        Quaternion.Euler(-90f,0f,0f)
    };

    private IEnumerator CreateChildren()
    {
        for (int i = 0; i < childDirections.Length; i++)
        {
            yield return new WaitForSeconds(Random.Range(0.1f,0.5f));
            new GameObject("Fractal Child").
                AddComponent<Fractal>().Initialiaze(this, i);
        }
        /*
        yield return new WaitForSeconds(0.5f);
        new GameObject("Fractal Child").
            AddComponent<Fractal>().Initialiaze(this, Vector3.up,Quaternion.identity);
        yield return new WaitForSeconds(0.5f);
        new GameObject("Fractal Child").
            AddComponent<Fractal>().Initialiaze(this, Vector3.right,Quaternion.Euler(0f,0f,-90f));
        yield return new WaitForSeconds(0.5f);
        new GameObject("Fractal Child").
            AddComponent<Fractal>().Initialiaze(this, Vector3.left,Quaternion.Euler(0f,0f,90f));
        */

    }
    private void Initialiaze(Fractal parent,int childIndex)
    {
        mesh = parent.mesh;
        material = parent.material;
        maxDepth = parent.maxDepth;
        depth = parent.depth + 1;
        childScale = parent.childScale;
        transform.parent = parent.transform;
        transform.localScale = Vector3.one * childScale;
        transform.localPosition = Vector3.up * (0.5f + 0.5f * childScale);
        transform.localPosition = childDirections[childIndex] * (0.5f + 0.5f * childScale);
        transform.localRotation = childOrientations[childIndex];

    }
}
