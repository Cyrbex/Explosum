using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraBomb : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<BombSpawner>().bombcount1++;
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Player2")
        {
            collision.gameObject.GetComponent<BombSpawner>().bombcount2++;
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Player3")
        {
            collision.gameObject.GetComponent<BombSpawner>().bombcount3++;
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Player4")
        {
            collision.gameObject.GetComponent<BombSpawner>().bombcount4++;
            Destroy(gameObject);
        }
    }
}
