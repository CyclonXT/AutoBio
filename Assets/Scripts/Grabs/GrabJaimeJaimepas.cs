using UnityEngine;

public class GrabJaimeJaimepas : MonoBehaviour
{
  public GameManager gameManager;

  void OnTriggerEnter ()
  {
    gameManager.GrabJaimeJaimepas();
  }
}
