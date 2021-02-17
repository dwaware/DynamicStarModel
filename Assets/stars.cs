using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stars : MonoBehaviour
{
    public int seed;
    public List<GameObject> star = new List<GameObject>();

    Vector3 starScale = new Vector3(0.2f, 0.2f, 0.2f);

    void Awake()
    {
        float halfCubeSize = 100f;

        for (int i = 0; i < 32; i++)
        {
            GameObject go = Instantiate(star[i], new Vector3(Random.Range(-halfCubeSize, halfCubeSize), Random.Range(-halfCubeSize, halfCubeSize), Random.Range(-halfCubeSize, halfCubeSize)), Quaternion.identity);
            go.name = "Star "+i;
            go.transform.localScale = starScale;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Random.InitState(seed);
    }

    void Update()
    {
        Camera mainCam = GameObject.Find("Main Camera").GetComponent<Camera>();
        mainCam.transform.RotateAround(Vector3.zero, transform.up, 0.05f);
    }
}