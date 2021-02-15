using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stars : MonoBehaviour
{
    public List<GameObject> star = new List<GameObject>();

    Vector3 starScale = new Vector3(5, 5, 5);

    // Start is called before the first frame update
    void Start()
    {
        float max = 250.0f;

        for (int i = 0; i < 10; i++)
        {
            GameObject go = Instantiate(star[i], new Vector3(Random.Range(-max, max), Random.Range(-max, max), Random.Range(-max, max)), Quaternion.identity);
            go.name = "Star "+i;
            //go.transform.localScale = starScale;
        }
    }

    void Update()
    {

    }
}