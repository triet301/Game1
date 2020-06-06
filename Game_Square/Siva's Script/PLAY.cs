
using UnityEngine;
using UnityEngine.SceneManagement;
public class PLAY : MonoBehaviour
{
   public void Play(){
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
   }
}
