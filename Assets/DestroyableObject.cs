using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyableObject : MonoBehaviour
{
    public GameObject plat;
    public GameObject detruit;
    public void Start()
    {
        plat.SetActive(false);
    }
    private OnTriggerEnter
    private void OnDestroy()
    {
        plat.SetActive(true);
    }
}
