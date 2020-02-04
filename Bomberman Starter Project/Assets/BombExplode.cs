using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombExplode : MonoBehaviour
{
    
    public float countdown = 2f;
    public int keissi = 1; 

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;

        if(countdown <= 0f)
        {
            FindObjectOfType<MapDestroyer>().keissi = keissi;   //tells which "case" or rather how much range does the exploding bomb have from BombSpawner script.
            FindObjectOfType<MapDestroyer>().Explode(transform.position);
            FindObjectOfType<AudioManager>().Play("Explosion");
            Destroy(gameObject);
        }
    }
}
