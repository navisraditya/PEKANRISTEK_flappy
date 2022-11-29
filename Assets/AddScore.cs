using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{
    [SerializeField] private AudioSource scoreEffect;

    void OnTriggerEnter2D(Collider2D collision)
    {
        ScoringSystem.score++;
        scoreEffect.Play();
    }
}
