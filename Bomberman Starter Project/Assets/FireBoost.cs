using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FireBoost : MonoBehaviour
{

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<BombSpawner>().firepower1++;
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Player2")
        {
            collision.gameObject.GetComponent<BombSpawner>().firepower2++;
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Player3")
        {
            collision.gameObject.GetComponent<BombSpawner>().firepower3++;
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Player4")
        {
            collision.gameObject.GetComponent<BombSpawner>().firepower4++;
            Destroy(gameObject);
        }
    }

}
