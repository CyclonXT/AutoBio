using UnityEngine;

public class GrabPacte : MonoBehaviour
{
    public GameManager gameManager;
    void OnTriggerEnter ()
    {
      gameManager.GrabPacte();
    }
}
