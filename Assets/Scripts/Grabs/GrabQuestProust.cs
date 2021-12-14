using UnityEngine;

public class GrabQuestProust : MonoBehaviour
{
  public GameManager gameManager;

  void OnTriggerEnter ()
  {
    gameManager.GrabQuestProust();
  }
}
