using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class StarLine : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LineRenderer lineRenderer = this.GetComponent<LineRenderer>();
        Material whiteDiffuseMat = new Material(Shader.Find("Unlit/Texture"));
        lineRenderer.material = whiteDiffuseMat;
        lineRenderer.startWidth = 5f;
        lineRenderer.endWidth = 5f;

        Vector3 posGO = this.transform.position;
        Vector3 posZero = Vector3.zero;
        lineRenderer.SetPosition(0, posZero);
        lineRenderer.SetPosition(1, posGO);
        Debug.Log(this.name + " " + posGO);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
