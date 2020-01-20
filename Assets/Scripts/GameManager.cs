
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

  bool gameHasEnded = false;

  public GameObject completeLevelUI;

  public float restartDelay = 1f;

  public void CompleteLevel()
  {
    completeLevelUI.SetActive(true);

  }
  public void EndGame()
  {
    if (gameHasEnded == false)
    {
      gameHasEnded = true;
      Debug.Log("GAME OVER");
      //Restart Game + Adds Slight Delay
      Invoke("Restart", restartDelay);

    }
  }

  void Restart()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().name); //* Gets Name of Scene
  }
}
