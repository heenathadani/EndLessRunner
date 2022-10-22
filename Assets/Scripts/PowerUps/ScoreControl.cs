using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreControl : MonoBehaviour
{
    public static int coinCount;
    public TextMeshProUGUI coinCountDisplay;
    public TextMeshProUGUI coinEndDisplay;


    // Update is called once per frame
    void Update()
    {
        coinCountDisplay.GetComponent<TextMeshProUGUI>().text = "" + coinCount;
        coinEndDisplay.GetComponent<TextMeshProUGUI>().text = "" + coinCount;        
    }
}
