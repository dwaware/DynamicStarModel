using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stars : MonoBehaviour
{
    public List<GameObject> star = new List<GameObject>();

    //Vector3 starScale = new Vector3(5, 5, 5);

    void Awake()
    {
        float max = 250.0f;

        for (int i = 0; i < 8; i++)
        {
            GameObject go = Instantiate(star[i], new Vector3(Random.Range(-max, max), Random.Range(-max, max), Random.Range(-max, max)), Quaternion.identity);
            go.name = "Star "+i;
            //go.transform.localScale = starScale;
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        Camera mainCam = GameObject.Find("Main Camera").GetComponent<Camera>();
        mainCam.transform.RotateAround(Vector3.zero, transform.up, 0.1f);
    }
}