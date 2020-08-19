using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayerOnContact : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            collision.GetComponent<PlayerController>().GameOver();
        }
    }
}
