using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.ParticleSystem;

public class resaut : MonoBehaviour
{
    public GameObject gameobject;
    public GameObject cible;
    public GameObject particule;
    public GameObject GameManager;
    // Start is called before the first frame update
    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        cible.SetActive(true);
        particule.SetActive(false);
    }
}
