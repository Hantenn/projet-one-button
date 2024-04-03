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
    public GameObject Checkpointa;
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
        }
        else
        {
            son.GetComponent<AudioSource>().Play();
        }
    }
}
