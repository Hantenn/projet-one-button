using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class activationn : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnClick()
    {
        ChangeScene();
    }
    public void ChangeScene()
    {
        SceneManager.LoadScene("Ld1");
    }
}
