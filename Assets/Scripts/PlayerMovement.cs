using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
  public Rigidbody rb;

  public float forwardForce = 2000f; //* Defining Decimal Variable - Unity Editor Can Change 
  public float horizontalForce = 500f;

  // Start is called before the first frame update
  // Update is called once per frame

  void FixedUpdate() //* FixedUpdate() Use For Physics 
  {
    // Adding Forward Force
    rb.AddForce(0, 0, forwardForce * Time.deltaTime); //? Time.deltaTime makes cube const all platforms

    //! Should be using Update() to register player input then use boolean in FixedUpdate() to initiate movement
    if (Input.GetKey("d"))
    {
      rb.AddForce(horizontalForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange); //* 4th Param cntrls force direction
    }

    if (Input.GetKey("a"))
    {
      rb.AddForce(-horizontalForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange); //? ForceMode - Ignores Mass of Obj
    }

    if (rb.position.y < -1f)
    {
      FindObjectOfType<GameManager>().EndGame();
    }
  }
}
