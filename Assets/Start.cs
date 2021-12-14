using UnityEngine;
using UnityEngine.SceneManagement;
public class Start : MonoBehaviour
{
  public Animator anim;
  public GameObject BlackedOut;
  public void StartGame ()
  {
    if (SceneManager.GetActiveScene().name == "End")
    {
      BlackedOut.SetActive(true);
    }
    anim.Play("LoadGameBlack");
    Invoke("LoadGame", 1);
    Debug.Log("game start");
  }
  public void LoadGame ()
  {
    SceneManager.LoadScene(1);
  }
}
