using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

  public Transform player; //* gets x,y,z coords of player
  public Vector3 offset; //* vector3 type stores 3 floats
  // Update is called once per frame
  void Update()
  {
    //! Adding two vectors together (x_1+x_2, y_1+y_2, z_1+z_2)
    transform.position = player.position + offset; //*Referring to position of camera - lowercase t
  }
}
