using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LastManStanding : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;
    public GameObject player3;
    public GameObject player4;

    public int num = 0;

    void Awake() //transfering the player number by not destroying the this is attached to empty gameobject.
    {
        DontDestroyOnLoad(this);
    }

    void Update() //checking when only one is left and loads the ending scene.
    {
        if(player1 != null && player2 == null && player3 == null && player4 == null)
        {
            num = 1;
            SceneManager.LoadScene(2);
        }

        if (player2 != null && player1 == null && player3 == null && player4 == null)
        {
            num = 2;
            SceneManager.LoadScene(2);
        }

        if (player3 != null && player1 == null && player2 == null && player4 == null)
        {
            num = 3;
            SceneManager.LoadScene(2);
        }

        if (player4 != null && player1 == null && player2 == null && player3 == null)
        {
            num = 4;
            SceneManager.LoadScene(2);
        }
    }
}
