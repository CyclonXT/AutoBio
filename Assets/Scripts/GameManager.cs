using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
  public bool GrabPacteGrabbed = false;
  public bool GrabQuestProustGrabbed = false;        // Prevents the grabbed to trigger twice
  public bool GrabPortraitChinoisGrabbed = false;
  public bool GrabJaimeJaimepasGrabbed = false;
  public bool GrabJeMeSouviensGrabbed = false;
  public bool GrabMomentQuotidienGrabbed = false;
  public bool GrabEnfanceGrabbed = false;
  public bool GrabAutoportraitGrabbed = false;
  public bool GrabFeticheGrabbed = false;
  public bool GrabFedererGrabbed = false;
  public bool GrabCauseGrabbed = false;
  public AudioSource playSound;
  public int Grabbed = 0;
  public Animator anim;
  public void GrabQuestProust ()
  {
    Debug.Log("GrabQuestProust has triggered"); // Questionnaire de Proust
    if (GrabQuestProustGrabbed == false)
    {
       Grabbed = Grabbed + 1;
       GrabQuestProustGrabbed = true;
       playSound.Play();
    }
  }
  public void GrabPortraitChinois () // Portrait Chinois
  {
    Debug.Log("GrabPortraitChinois has triggered");
    if (GrabPortraitChinoisGrabbed == false)
    {
       Grabbed = Grabbed + 1;
       GrabPortraitChinoisGrabbed = true;
       playSound.Play();
    }
  }
  public void GrabJaimeJaimepas () // J'aime / Je n'aime pas
  {
    Debug.Log("GrabJaimeJaimepas has triggered");
    if (GrabJaimeJaimepasGrabbed == false)
    {
       Grabbed = Grabbed + 1;
       GrabJaimeJaimepasGrabbed = true;
       playSound.Play();
    }
  }
  public void GrabJeMeSouviens () // Série de "Je me souviens"
  {
    Debug.Log("GrabJeMeSouviens has triggered");
    if (GrabJeMeSouviensGrabbed == false)
    {
      Grabbed = Grabbed + 1;
      playSound.Play();
      GrabJeMeSouviensGrabbed = true;
    }
  }
  public void GrabMomentQuotidien () // Moment du quotidien
  {
    Debug.Log("GrabMomentQuotidien has triggered");
    if (GrabMomentQuotidienGrabbed == false)
    {
      Grabbed = Grabbed + 1;
      GrabMomentQuotidienGrabbed = true;
      playSound.Play();
    }
   }

   public void GrabEnfance () // Souvenir d'Enfance
   {
    Debug.Log("GrabEnfance has triggered");
    if (GrabEnfanceGrabbed == false)
    {
      Grabbed = Grabbed + 1;
      GrabEnfanceGrabbed = true;
      playSound.Play();
    }
   }

   public void GrabAutoportrait ()
   {
     Debug.Log("GrabAutoportrait has triggered");
     if (GrabAutoportraitGrabbed == false)
     {
       Grabbed = Grabbed + 1;
       GrabAutoportraitGrabbed = true;
       playSound.Play();
     }
   }
   public void GrabFetiche ()
   {
     Debug.Log("GrabFetiche has triggered");
     if (GrabFeticheGrabbed == false)
     {
       Grabbed = Grabbed + 1;
       GrabFeticheGrabbed = true;
       playSound.Play();
     }
   }
   public void GrabFederer ()
   {
     Debug.Log("GrabFederer has triggered");
     if (GrabFedererGrabbed == false)
     {
       Grabbed = Grabbed + 1;
       GrabFedererGrabbed = true;
       playSound.Play();
     }
   }
   public void GrabCause ()
   {
     Debug.Log("GrabCause has triggered");
     if (GrabCauseGrabbed == false)
     {
       Grabbed = Grabbed + 1;
       GrabCauseGrabbed = true;
       playSound.Play();
     }
   }
   public void GrabPacte ()
   {
     if (GrabPacteGrabbed == false)
     {
       Grabbed = Grabbed + 1;
       GrabPacteGrabbed = true;
       playSound.Play();
     }

   }

   void Update ()
   {
     if (Grabbed == 10)
     {
       Invoke("EndMenu", 1);
       anim.Play("WinBlack");
     }
   }
   public void EndMenu ()
   {
     SceneManager.LoadScene(2);
     Cursor.lockState = CursorLockMode.None;
   }
}
