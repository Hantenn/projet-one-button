using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nouveauscript : MonoBehaviour
{
    public GameObject gameobject;
    public GameObject cible;
    // Start is called before the first frame update
    void Start()
    {
        cible.SetActive(true);
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        cible.SetActive(false);
    }
}
