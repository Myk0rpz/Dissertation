﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour
{
    public GameObject scoreText;
    public static int score = SpawnKeys.maxKeys;

    void Update()
    {
        scoreText.GetComponent<Text>().text = "KEYS LEFT: " + score;

    }
}
