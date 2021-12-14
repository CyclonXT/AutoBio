using UnityEngine;

public class GrabJeMeSouviens : MonoBehaviour
{
  public GameManager gameManager;

  void OnTriggerEnter ()
  {
    gameManager.GrabJeMeSouviens();
  }
}
