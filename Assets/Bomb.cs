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
            musique.Play();
            son.GetComponent<AudioSource>().Stop();
            musique2.Stop();
            musique3.Stop();
            musique4.Stop();
        }
        else if (Checkpointb.GetComponent<Checkpoint>().musiqueact == true)
        {
            musique2.Play();
            son.GetComponent<AudioSource>().Stop();
            musique.Stop();
            musique3.Stop();
            musique4.Stop();
        }
        else if (Checkpointc.GetComponent<Checkpoint>().musiqueact == true)
        {
            musique3.Play();
            son.GetComponent<AudioSource>().Stop();
            musique.Stop();
            musique2.Stop();
            musique4.Stop();
        }
        else if (Checkpointd.GetComponent<Checkpoint>().musiqueact == true)
        {
            musique4.Play();
            son.GetComponent<AudioSource>().Stop();
            musique.Stop();
            musique3.Stop();
            musique2.Stop();
        }
        else
        {
            son.GetComponent<AudioSource>().Play();
        }
    }
}
