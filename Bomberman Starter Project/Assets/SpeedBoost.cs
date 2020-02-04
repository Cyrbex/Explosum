using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player"){
            collision.gameObject.GetComponent<GladiatorController>().speed1++;
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Player2")
        {
            collision.gameObject.GetComponent<GladiatorController>().speed2++;
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Player3")
        {
            collision.gameObject.GetComponent<GladiatorController>().speed3++;
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Player4")
        {
            collision.gameObject.GetComponent<GladiatorController>().speed4++;
            Destroy(gameObject);
        }
    }
    
}
