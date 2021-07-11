using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScreen : MonoBehaviour
{
    public GameObject EndScrn;
     
    private void OnTriggerEnter(Collider other)
    {
        PlayerMovement player = other.GetComponent<PlayerMovement>();
        if (player)
        {
            player.speed = 0;
            
            EndScrn.gameObject.SetActive(true);
            
        }
    }
}
