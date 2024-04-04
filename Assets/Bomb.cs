using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bomb : MonoBehaviour
{
    public Vector2 _respawnPoint;
    public GameObject player;
    public GameObject son;
    public bool reset = false;
    public AudioSource musique;
    public AudioSource musique2;
    public GameObject Checkpointa;
    public GameObject Checkpointb;
    public AudioSource musique3;
    public AudioSource musique4;
    public GameObject Checkpointc;
    public GameObject Checkpointd;
    public void Start()
    {
        _respawnPoint = player.transform.position;
        reset = false;
    }
    public void Update()
    {
        if (reset = true)
        {
            reset = false;
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player") // filter the objects that collide with the checkpoint. You can assign the tag in the inspector
        {
            OnPlayerDeath();
        }
    }
    public void OnPlayerDeath()
    {
        player.transform.position = _respawnPoint;
        reset = true;
        if (Checkpointa.GetComponent<Checkpoint>().musiqueact == true)
        {
            son.GetComponent<AudioSource>().Stop();
            musique.enabled = true;
            musique.Play();
            Checkpointa.GetComponent<Checkpoint>().musiqueact = false;
        }
        if (Checkpointb.GetComponent<Checkpoint>().musiqueact == true)
        {
            son.GetComponent<AudioSource>().Stop();
            musique.Stop();
            musique.enabled = false;
            musique2.enabled = true;
            musique2.Play();
  
            
            Checkpointb.GetComponent<Checkpoint>().musiqueact = false;
        }
        if (Checkpointc.GetComponent<Checkpoint>().musiqueact == true)
        {
            son.GetComponent<AudioSource>().Stop();
            musique2.Stop();
            musique2.enabled = false;
            musique3.enabled = true;
            musique3.Play();

            Checkpointc.GetComponent<Checkpoint>().musiqueact = false;
        }
        if (Checkpointd.GetComponent<Checkpoint>().musiqueact == true)
        {
            son.GetComponent<AudioSource>().Stop();
            musique3.Stop();
            musique3.enabled = false;
            musique4.Play();
            musique4.enabled = true;

            Checkpointd.GetComponent<Checkpoint>().musiqueact = false;
        }
        else
        {
            son.GetComponent<AudioSource>().Play();
        }
    }
}
