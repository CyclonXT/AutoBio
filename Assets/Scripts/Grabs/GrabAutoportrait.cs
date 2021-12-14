using UnityEngine;

public class GrabAutoportrait : MonoBehaviour
{
  public GameManager gameManager;
  void OnTriggerEnter ()
  {
    gameManager.GrabAutoportrait();
  }
}
