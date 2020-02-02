using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float lastYPos;

    private Vector3 v;
    // Start is called before the first frame update
    void Start()
    {
        v = new Vector3(0, 0, 1);
        InvokeRepeating("PlayScrapeSound", 0.5f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(0, Input.mousePosition.y / 10-50 , 0);
    }

    void PlayScrapeSound()
    {


        if (Mathf.Abs(lastYPos - transform.position.y) > 6f)
        {
            //float rando = Random.Range(0f, 10f);
            //audioSources[(rando > 5) ? 0 : 1].Play();
            gameObject.GetComponent<AudioSource>().Play();
        }

        lastYPos = transform.position.y;
    }
}

