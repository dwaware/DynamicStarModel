using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class WarpLines : MonoBehaviour
{
    public List<GameObject> warpLine = new List<GameObject>();
    public int numLines;

    void Start()
    {
        List<GameObject> starList = new List<GameObject>();
        numLines = 0;
        foreach (GameObject star in GameObject.FindGameObjectsWithTag("Star"))
        {
            starList.Add(star);
            int starIndex = starList.Count - 1;
            Vector3 starPos = star.transform.position;
            for (int i = 0; i < starList.Count -1 ; i++)
            {
                Vector3 targetPos = starList[i].transform.position;
                float distance = Vector3.Distance(starPos, targetPos);

                //Debug.Log("si: " + starIndex + " i: " + i + " Distance: "+distance);

                if (distance < 60f)
                {
                    CreateWarpLine(starPos, targetPos, starIndex, i);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    void CreateWarpLine (Vector3 sP, Vector3 tP, int sSys, int eSys)
    {
        GameObject go = Instantiate(warpLine[numLines], new Vector3(0f, 0f, 0f), Quaternion.identity);
        go.name = "WarpLine " + sSys + "__" + eSys;

        WarpLine scriptInstance = go.GetComponent<WarpLine>();
        scriptInstance.startIndex = sSys;
        scriptInstance.endIndex = eSys;

        LineRenderer lineRenderer = go.GetComponent<LineRenderer>();
        lineRenderer.positionCount = 2;
        Material whiteDiffuseMat = new Material(Shader.Find("Unlit/Texture"));
        lineRenderer.material = whiteDiffuseMat;
        lineRenderer.startWidth = 0.2f;
        lineRenderer.endWidth = 0.2f;

        lineRenderer.SetPosition(0, sP);
        lineRenderer.SetPosition(1, tP);

        numLines++;
    }
}