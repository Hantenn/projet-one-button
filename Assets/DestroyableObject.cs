using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyableObject : MonoBehaviour
{
    public GameObject plat;
    public GameObject detruit;
    public GameObject objet;
    public GameObject orig;
    public bool lamort = false; 
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
    }
    private void OnTriggerStay2D(Collider2D collider)
    {
        if ((collider.tag == "destroyable") && orig.GetComponent<saaaaaa>().cbon == true)
        {
            lamort = true;
        }
    }
