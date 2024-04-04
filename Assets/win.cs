using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class win : MonoBehaviour
{

    public Image winning;
    // Start is called before the first frame update
    void Start()
    {
        winning.enabled = false;
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            winning.enabled = true;
        }
    }
}
