

using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
  
  bool gameHasEnded = false;
  public float restartDelay = 1f;
   
public GameObject completeLevelUI;

  public void CompleteLevel(){
    completeLevelUI.SetActive(true);
  }

  public void EndGame () {
    if(gameHasEnded == false){
      gameHasEnded = true;
     Debug.Log("Game Over");
     Invoke("Restart", restartDelay); //Invoke (method name, time delay)
    }
}
void Restart ()
{
SceneManager.LoadScene(SceneManager.GetActiveScene().name); // level01 created (tu tao cho minh 1 level)
}
}