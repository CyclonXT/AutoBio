using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
  public GameManager gameManager;
  public Text scoreText;
  string score;
  void Update ()
  {
    score = gameManager.Grabbed + "/10";
    scoreText.text = score;
  }
}
