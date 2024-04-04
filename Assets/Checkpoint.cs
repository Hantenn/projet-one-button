using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public GameObject GameManager;
    private Vector2 pointupdate;
    public bool musiqueact = false;
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Player") 
        {
            pointupdate = new Vector2(transform.position.x, transform.position.y);
            GameManager.GetComponent<Bomb>()._respawnPoint = pointupdate;
            musiqueact = true;
            Debug.Log(musiqueact);
        }
    }
}