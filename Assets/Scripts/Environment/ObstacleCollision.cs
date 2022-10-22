using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject charModel;
    public AudioSource CollisionSound;
    public GameObject boundaryRange;

    void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        thePlayer.GetComponent<playerMove>().enabled = false;
        charModel.GetComponent<Animator>().Play("Falling");
        CollisionSound.Play();
        boundaryRange.GetComponent<EndRunScript>().enabled = true;
    }
}
