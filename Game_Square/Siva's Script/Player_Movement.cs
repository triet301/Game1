

using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 1500f;
    public float sidewaysForce = 1000f;
   
  
    void FixedUpdate()
    {
        
        if(Input.GetKey("d"))
        {
           rb.AddForce(sidewaysForce* Time.deltaTime, 0 , 0);
        }
          if(Input.GetKey("a"))
        {
           rb.AddForce(-sidewaysForce * Time.deltaTime, 0 , 0);
        }
         if(Input.GetKey("w"))
        {
           rb.AddForce(0, 0 , forwardForce  * Time.deltaTime);
        }
         if(Input.GetKey("s"))
        {
           rb.AddForce(0, 0 , -forwardForce * Time.deltaTime);
        }
        if(rb.position.y + 10 < -1f){
           FindObjectOfType<GameManager>().EndGame();  //khi rot, se bi chet
        }
         if(rb.position.z + 83 < -1f){
           FindObjectOfType<GameManager>().EndGame();  //khi di nguoc se bi chet
        }
        
    }
}
