using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectibles : MonoBehaviour
{
    public AudioSource cSFX;
    void OnTriggerEnter(Collider other)
    {
        cSFX.Play();
        ScoreControl.coinCount += 1;
        this.gameObject.SetActive(false);
    }
}
