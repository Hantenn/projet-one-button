using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collider : MonoBehaviour
{
    public GameObject origine;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if ((collider.tag == "destroyable") && origine.GetComponent<saaaaaa>().cbon == true)
        {
            collider.GetComponent<DestroyableObject>().lamort = true;
            Debug.Log(collider.GetComponent<DestroyableObject>().lamort);
        }
        else if ((collider.tag == "bomb") && origine.GetComponent<saaaaaa>().cbon == true)
        {
            SceneManager.LoadScene("death");
        }
        else if (collider.tag == "death")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
