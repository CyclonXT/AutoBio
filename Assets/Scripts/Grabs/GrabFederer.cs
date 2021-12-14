using UnityEngine;

public class GrabFederer : MonoBehaviour
{
  public GameManager gameManager;
  void OnTriggerEnter ()
  {
    gameManager.GrabFederer();
  }
}
