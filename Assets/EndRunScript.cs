using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndRunScript : MonoBehaviour
{
    public GameObject coins;
    public GameObject endScreen;

    public GameObject fadeOut;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EndSequence());
    }
    IEnumerator EndSequence()
    {
        yield return new WaitForSeconds(5);
        coins.SetActive(false);
        endScreen.SetActive(true);
        yield return new WaitForSeconds(5);
        fadeOut.SetActive(true);
    }
}
