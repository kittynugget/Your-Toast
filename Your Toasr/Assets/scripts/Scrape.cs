using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrape : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Crumbs")
        {
            Debug.Log("BUH");
            Destroy(collision.gameObject);
        }
    }
}
