using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMat : MonoBehaviour
{
    private GameObject cam;
    public Material mat1;
    public Material mat2;

    // Start is called before the first frame update
    void Start()
    {
        cam = GameObject.Find("Main Camera");
        gameObject.GetComponent<MeshRenderer>().material = mat1;
    }

    // Update is called once per frame
    void Update()
    {
        if (cam.GetComponent<Score>().score >= 50)
        {
            gameObject.GetComponent<MeshRenderer>().material = mat2;
        }
    }
}
