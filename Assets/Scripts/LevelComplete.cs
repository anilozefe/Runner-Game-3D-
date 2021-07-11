using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
   private void Start()
   {
      
      StartCoroutine(NextLevel());
      
   }
   
   
       IEnumerator NextLevel()
      {
         if (Input.GetMouseButtonDown(0))
         {
            yield return new WaitForSeconds(1f);
            LoadNextLevel();
         }

      }
   

   public void LoadNextLevel()
   {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   }
}
