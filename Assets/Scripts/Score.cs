using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

  public Transform player;

  public Text scoreText;

  // Update is called once per frame
  void Update()
  {
    //? How much distance player has moved
    scoreText.text = player.position.z.ToString("0"); //! Parameter - Zero makes sure only integer is displayed
  }
}
