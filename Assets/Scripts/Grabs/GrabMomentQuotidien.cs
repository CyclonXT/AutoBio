using UnityEngine;

public class GrabMomentQuotidien : MonoBehaviour
{
  public GameManager gameManager;
  void OnTriggerEnter ()
  {
    gameManager.GrabMomentQuotidien();
  }
}
