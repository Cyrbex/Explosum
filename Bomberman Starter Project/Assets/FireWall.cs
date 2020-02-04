using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FireWall : MonoBehaviour
{
    public GameObject fire;
    public GameObject devil;

    GameObject cloneDevil;

    public float width = 3.5f;
    public float heigth = 4.5f;

    public float timer = 90f;
    public int minutes = 0;
    public int seconds = 0;

    public bool timerActive = false;

    public Text uiText;
   
    void Start()
    {
        timerActive = true;
    }

    void Update()
    {
        if (timerActive == true)
        {
            timer -= Time.deltaTime;
            minutes = GetLeftMinutes();
            seconds = GetLeftSeconds();

            if(timer >= 7.98888f && timer <= 8.00000f) //spawns the devin when time is 8f
            {
                SpawnDevil();
            }

            if (timer > 0f) //shows timer. else triggers Sudden Death, firewall.
            {
                uiText.text = "Time: 0" + minutes + ":" + seconds.ToString("00");
            }
            else
            {
                uiText.text = "SUDDEN DEATH";
                StartCoroutine(Spawn());
                timerActive = false;
                Destroy(cloneDevil, 2f);
            }
        }
    }

    private void SpawnDevil()
    {
        cloneDevil = Instantiate(devil);
    }

    private float GetInitialTime()
    {
        return minutes * 60f + seconds;
    }

    private int GetLeftMinutes()
    {
        return Mathf.FloorToInt(timer / 60f);
    }

    private int GetLeftSeconds()
    {
        return Mathf.FloorToInt(timer % 60f);
    }

    IEnumerator Spawn() //Spawns the Sudden Death, firewalls one direction at a time towards the center.
    {
        //FIRST ROUND
        for (float y = -4.5f; y < heigth; y++)
        {
            float x = -4.5f;
            yield return new WaitForSeconds(0.5f);
            Instantiate(fire, new Vector3(x, y, 0), Quaternion.identity);
        }

        for (float x = -3.5f; x < width+1; x++)
        {
            float y = 3.5f;
            yield return new WaitForSeconds(0.5f);
            Instantiate(fire, new Vector3(x, y, 0), Quaternion.identity);
        }

        for (float y = 2.5f; y >= -heigth; y--)
        {
            float x = 3.5f;
            yield return new WaitForSeconds(0.5f);
            Instantiate(fire, new Vector3(x, y, 0), Quaternion.identity);
        }

        for (float x = 3.5f; x >= -width; x--)
        {
            float y = -4.5f;
            yield return new WaitForSeconds(0.5f);
            Instantiate(fire, new Vector3(x, y, 0), Quaternion.identity);
        }

        //SECOND ROUND
        for (float y = -3.5f; y < heigth-1; y++)
        {
            float x = -3.5f;
            yield return new WaitForSeconds(0.5f);
            Instantiate(fire, new Vector3(x, y, 0), Quaternion.identity);
        }

        for (float x = -3.5f; x < width; x++)
        {
            float y = 2.5f;
            yield return new WaitForSeconds(0.5f);
            Instantiate(fire, new Vector3(x, y, 0), Quaternion.identity);
        }

        for (float y = 2.5f; y >= -heigth + 1; y--)
        {
            float x = 2.5f;
            yield return new WaitForSeconds(0.5f);
            Instantiate(fire, new Vector3(x, y, 0), Quaternion.identity);
        }

        for (float x = 2.5f; x >= -width + 1; x--)
        {
            float y = -3.5f;
            yield return new WaitForSeconds(0.5f);
            Instantiate(fire, new Vector3(x, y, 0), Quaternion.identity);
        }

        //THIRD ROUND
        for (float y = -2.5f; y < heigth - 2; y++)
        {
            float x = -2.5f;
            yield return new WaitForSeconds(1f);
            Instantiate(fire, new Vector3(x, y, 0), Quaternion.identity);
        }

        for (float x = -2.5f; x < width - 1; x++)
        {
            float y = 1.5f;
            yield return new WaitForSeconds(1f);
            Instantiate(fire, new Vector3(x, y, 0), Quaternion.identity);
        }

        for (float y = 1.5f; y >= -heigth + 2; y--)
        {
            float x = 1.5f;
            yield return new WaitForSeconds(1f);
            Instantiate(fire, new Vector3(x, y, 0), Quaternion.identity);
        }

        for (float x = 1.5f; x >= -width + 2; x--)
        {
            float y = -2.5f;
            yield return new WaitForSeconds(1f);
            Instantiate(fire, new Vector3(x, y, 0), Quaternion.identity);
        }
    }
}

