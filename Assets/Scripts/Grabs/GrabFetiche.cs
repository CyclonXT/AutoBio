using UnityEngine;

public class GrabFetiche : MonoBehaviour
{
  public GameManager gameManager;
  void OnTriggerEnter ()
  {
    gameManager.GrabFetiche();
  }
}
