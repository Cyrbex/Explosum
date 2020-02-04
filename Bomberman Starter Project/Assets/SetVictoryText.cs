using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetVictoryText : MonoBehaviour
{
    public int num;
    public Text uiText;

    public GameObject lastManStanding;

    void Start()
    {
        lastManStanding = GameObject.Find("LastManStanding");
        if (lastManStanding)
        {
            num = lastManStanding.GetComponent<LastManStanding>().num;
            uiText.text = "Congratulations Player" + num + ", You May Ascend.";
            Destroy(lastManStanding);
        }
       
    }
}
