using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mortel : MonoBehaviour
{
    public Vector2 _respawnPoint;
    public GameObject player;
    public GameObject son;
    public bool reset = false;
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
        son.GetComponent<AudioSource>().Stop();
        son.GetComponent<AudioSource>().Play();
    }
}
