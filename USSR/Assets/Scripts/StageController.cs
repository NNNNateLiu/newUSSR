﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// temp code for testing purpose... allows teleport
public class StageController : MonoBehaviour
{
    public static StageController instance;

    public GameObject level1Additive;
    public GameObject level2Additive;

    public GameObject player;
    public GameObject gravityPlane;
    public GameObject level2GravityPivot;

    public Transform level2Start;

    private void Awake()
    {
        instance = this;
    }
    public void OnLevel1Finish()
    {
        player.transform.position = level2Start.position;
        player.transform.parent = level2GravityPivot.transform;
        level1Additive.SetActive(false);
        level2Additive.SetActive(true);
    }

    public void OnLevel2Finish()
    {

    }
}
