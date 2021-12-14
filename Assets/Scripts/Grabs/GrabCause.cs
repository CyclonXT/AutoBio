using UnityEngine;

public class GrabCause : MonoBehaviour
{
  public GameManager gameManager;
  void OnTriggerEnter ()
  {
    gameManager.GrabCause();
  }
}
