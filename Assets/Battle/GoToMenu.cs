using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoToMenu : MonoBehaviour
{
  public void GoToMainMenu () 
   {
	   //MapSystem.yourLocation=0;
	   SceneManager.LoadScene (sceneName:"menu", LoadSceneMode.Single);
   }
}