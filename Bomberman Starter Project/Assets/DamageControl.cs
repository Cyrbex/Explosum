using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DamageControl : MonoBehaviour
{

    public GameObject player;
    public float hp = 100;

    public Text hp1;
    public Text hp2;
    public Text hp3;
    public Text hp4;

    public void TakeDmg(float amount)
    {
        hp -= amount;
    }

    public void GetHp()
    {
        if(gameObject.tag == "Player")
        {
            hp1.text = "Player1: \n" + (int)Mathf.Round(hp) + " hp";
        }

        if (gameObject.tag == "Player2")
        {
            hp2.text = "Player2: \n" + (int)Mathf.Round(hp) + " hp";
        }

        if (gameObject.tag == "Player3")
        {
            hp3.text = "Player3: \n" + (int)Mathf.Round(hp) + " hp";
        }

        if (gameObject.tag == "Player4")
        {
            hp4.text = "Player4: \n" + (int)Mathf.Round(hp) + " hp";
        }

        if (hp <= 0)
        {
            Destroy(player);

            if (gameObject.tag == "Player")
            {
                hp1.text = "DEAD";
            }

            if (gameObject.tag == "Player2")
            {
                hp2.text = "DEAD";
            }

            if (gameObject.tag == "Player3")
            {
                hp3.text = "DEAD";
            }

            if (gameObject.tag == "Player4")
            {
                hp4.text = "DEAD";
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("NormalExplosion")) //Damage from normal explosions.
        {
            TakeDmg(33.333334f);
            GetHp();
        }

        if (collision.CompareTag("FireWall")) //Sudden Death, player dies if it's directly under the fire.
        {
            Destroy(player);
        }
    }
}
