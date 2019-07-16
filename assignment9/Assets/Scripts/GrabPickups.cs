﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GrabPickups : MonoBehaviour
{

    private AudioSource pickupSoundSource;

    void Awake()
    {
        pickupSoundSource = DontDestroy.instance.GetComponents<AudioSource>()[1];
    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag == "Pickup")
        {
            pickupSoundSource.Play();
            // AS8.3 - Keeping track of level count
            PlayerStats.level += 1;
            SceneManager.LoadScene("Play");
        }
    }
}