using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bomb : MonoBehaviour
{
    private void OnCollisionEnter(Collider other)
    {
        SceneManager.LoadScene("SampleScene");
    }
}
