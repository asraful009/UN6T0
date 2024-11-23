using System;
using UnityEngine;
using UnityEngine.Serialization;

public class Colluation : MonoBehaviour
{
    [FormerlySerializedAs("score")] 
    public Score Score;

    
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Collision"))
        {
            if(Score != null)
                Score.AddScore(10);
            
        }
    }         
}
