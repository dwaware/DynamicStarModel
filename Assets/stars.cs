using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stars : MonoBehaviour
{
    public GameObject star;

    public List<GameObject> starList = new List<GameObject>();

    Vector3 starScale = new Vector3(1, 1, 1);

    // Start is called before the first frame update
    void Start()
    {
        GameObject go = Instantiate(star, new Vector3(0, 0, 0), Quaternion.identity);
        go.name = "Star";
        go.transform.localScale = starScale;
    }

    void Update()
    {

    }
}