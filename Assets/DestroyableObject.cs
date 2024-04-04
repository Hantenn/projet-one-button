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
    public ParticleSystem particule;
    public bool particuleoui = true;
    public AudioSource Slash;
    public AudioSource SlashDestroy;
    public void Start()
    {
        plat.SetActive(false);
    }
    public void Update()
    {
        if (reset.GetComponent<Bomb>().reset == true)
        {
            lamort = false;
            Debug.Log(lamort);
        }

        if (lamort == true)
        {
            detruit.GetComponent<SpriteRenderer>().enabled = false;
            plat.SetActive(true);
            objet.GetComponent<BoxCollider2D>().enabled = false;        
            if (particuleoui == true)
            {
                Debug.Log("marche");
                particule.Play();
                particuleoui = false;
                Slash.Stop();
                SlashDestroy.Play();
            }
            Invoke("test", 3);
        }

    }
    void test()
    {
        lamort = false;
        detruit.GetComponent<SpriteRenderer>().enabled = true;
        plat.SetActive(false);
        objet.GetComponent<BoxCollider2D>().enabled = true;
        particuleoui = true;
    }
}
