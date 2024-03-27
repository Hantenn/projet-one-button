using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyableObject : MonoBehaviour
{
    public GameObject plat;
    public void Start()
    {
        plat.SetActive(false);
    }
    private void OnDestroy()
    {
        plat.SetActive(true);
    }
}
