using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Vector3 v;
    // Start is called before the first frame update
    void Start()
    {
        v = new Vector3(0, 0, 1);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Input.mousePosition.y / 100 - 5, 0, 0);
    }
}

