using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

  public PlayerMovement movement;



  void OnCollisionEnter(Collision collisionInfo)
  {
    if (collisionInfo.collider.tag == "Obstacle")
    {
      movement.enabled = false;

      //! References GameManager Obj - Because Player Will Die 
      FindObjectOfType<GameManager>().EndGame();
    }

  }
}