 

using UnityEngine;

public class Player_Collision : MonoBehaviour
{
  
  public Player_Movement movement;
  
   void OnCollisionEnter(Collision collisionInfo) {
       
      if(collisionInfo.collider.tag == "Obstacle"){
          GetComponent<Player_Movement>().enabled = false;  // can use movement.enabled = false. 
          FindObjectOfType<GameManager>().EndGame();
          
      }
  }
}
