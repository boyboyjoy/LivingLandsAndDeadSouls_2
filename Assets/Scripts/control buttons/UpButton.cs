﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class UpButton : MonoBehaviour,IPointerUpHandler,IPointerDownHandler
{
    AudioSource Audio;
    GameObject player;
    PlayerController playerController;
    void Start()
    {
        Audio=GameObject.Find("AudioManager").GetComponent<AudioSource>();
        player = GameObject.Find("Player");
        playerController = player.GetComponent<PlayerController>();
    }
    public virtual void OnPointerDown(PointerEventData ped)
    {
        Audio.Play();
        print("UpPointerDown");
        playerController.needToGo = true;
        playerController.direction = 1;
    }
    public virtual void OnPointerUp(PointerEventData ped)
    {
        Audio.Stop();
        playerController.needToGo = false;
        print("UpPointerUp");
    }

}
