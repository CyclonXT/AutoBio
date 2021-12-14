using UnityEngine;

public class Quit : MonoBehaviour
{
  public void QuitFunction ()
  {
    Application.Quit();
    Debug.Log("QUIT");
  }
}
