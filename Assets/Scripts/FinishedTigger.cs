using System;
using UnityEngine;
using UnityEngine.Serialization;

public class FinishedTigger : MonoBehaviour
{
   [FormerlySerializedAs("GameManager")] public GameManager gameManager;

   private void OnTriggerEnter(Collider other)
   {
      Debug.Log("tigger");
      if (other.gameObject.CompareTag("Player"))
      {
         Debug.Log("------------------------");
         gameManager?.FinishedLevel();
      }
   }
}
