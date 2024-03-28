using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyableObject : MonoBehaviour
{
    public GameObject plat;
    public GameObject detruit;
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
        }
    }
}
