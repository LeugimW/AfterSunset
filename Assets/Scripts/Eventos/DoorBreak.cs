using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBreak : MonoBehaviour
{
    public AudioClip breakDoor;
    public GameObject doorBlock;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "MonsterE")
        {
            AudioSource.PlayClipAtPoint(breakDoor, transform.position, 1);
            doorBlock.SetActive(false);
        }
    }
}
