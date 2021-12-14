using UnityEngine;

public class GrabEnfance : MonoBehaviour
{
  public GameManager gameManager;
  void OnTriggerEnter ()
  {
    gameManager.GrabEnfance();
  }
}
