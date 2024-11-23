using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Colluation : MonoBehaviour
{
    [FormerlySerializedAs("Score")] public Score score;
    [FormerlySerializedAs("GameManager")] public GameManager gameManager;


    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Collision"))
        {
            if(score != null)
                score.AddScore(10);
            
        } else if (other.gameObject.CompareTag("FinishTigger"))
        {
            gameManager?.EndGame();         
        }
    }          
}
