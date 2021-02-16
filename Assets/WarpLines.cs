using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class WarpLines : MonoBehaviour
{
    public List<GameObject> warpLine = new List<GameObject>();

    void Start()
    {
        List<GameObject> starList = new List<GameObject>();
        foreach (GameObject star in GameObject.FindGameObjectsWithTag("Star"))
        {
            starList.Add(star);
            int starIndex = starList.Count - 1;
            Vector3 starPos = star.transform.position;
            for (int i = 0; i < starList.Count -1 ; i++)
            {
                Vector3 targetPos = starList[i].transform.position;
                float distance = Vector3.Distance(starPos, targetPos);

                Debug.Log("si: " + starIndex + " i: " + i + " Distance: "+distance);

                if (distance < 200f)
                {
                    DrawWarpLine(starPos, targetPos);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    void DrawWarpLine (Vector3 sP, Vector3 tP)
    {
        GameObject go = Instantiate(warpLine[0], new Vector3(0f, 0f, 0f), Quaternion.identity);
        go.name = "WarpLine " + " ";

        LineRenderer lineRenderer = go.GetComponent<LineRenderer>();
        lineRenderer.positionCount = 2;
        Material whiteDiffuseMat = new Material(Shader.Find("Unlit/Texture"));
        lineRenderer.material = whiteDiffuseMat;
        lineRenderer.startWidth = 2f;
        lineRenderer.endWidth = 2f;

        lineRenderer.SetPosition(0, sP);
        lineRenderer.SetPosition(1, tP);
    }
}
