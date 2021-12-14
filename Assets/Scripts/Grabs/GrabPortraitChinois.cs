using UnityEngine;

public class GrabPortraitChinois : MonoBehaviour
{
  public GameManager gameManager;

  void OnTriggerEnter ()
  {
    gameManager.GrabPortraitChinois();
  }
}
