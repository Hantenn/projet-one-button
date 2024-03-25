using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lvl1 : MonoBehaviour
{
    // Start is called before the first frame update
    void OnClick()
    {
        Debug.Log("Bouton");
        SceneManager.LoadScene("SampleScene");
    }
}
