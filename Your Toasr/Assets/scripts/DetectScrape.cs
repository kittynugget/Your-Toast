using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectScrape : MonoBehaviour
{

    public float dist = 0f;
    public Vector3 startPos;
    private GameObject cam;
    private bool countedScore = false; 

    // Start is called before the first frame update
    void Start()
    {
        cam = GameObject.Find("Main Camera");
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        dist = Vector3.Distance(Vector3.zero, transform.position);
        if (dist > 80f && !countedScore)
        {
            countedScore = true;
            cam.GetComponent<Score>().score++;
        }
    }
}
