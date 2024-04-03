using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyableObject : MonoBehaviour
{
    public GameObject plat;
    public GameObject detruit;
    public GameObject objet;
    public bool lamort = false;
    public GameObject reset;
    public void Start()
    {
        plat.SetActive(false);
    }
    public void Update()
    {
        if (lamort == true)
        {
            detruit.SetActive(false);
            plat.SetActive(true);
            objet.GetComponent<BoxCollider2D>().enabled = false;
        }
        if (reset.GetComponent<Bomb>().reset == true)
        {
            lamort = false;
            detruit.SetActive(true);
            plat.SetActive(false);
            objet.GetComponent<BoxCollider2D>().enabled = true;
        }

    }
}
