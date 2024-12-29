using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerHp : MonoBehaviour
{
  public List<GameObject> Hearts;
  
  private void Start()
  {
    for (int i = 0; i < Hearts.Count; i++)
    {
      if (PlayerPrefs.GetInt("hp") >= i)
      {
        Hearts[i].gameObject.SetActive(false);

      }
      else
      {
        Hearts[i].gameObject.SetActive(true);
      }
    }
  }
  public void damage()
  {
    for (int i = 0; i < Hearts.Count; i++)
    {
      if (Hearts[i].activeInHierarchy)
      {
        Hearts[i].gameObject.SetActive(false);
        PlayerPrefs.SetInt("hp", Hearts.FindAll(x => x.activeInHierarchy).Count);
        return;


      }
      if (Hearts.Exists(x => x.activeInHierarchy))
      {
        SceneManager.LoadScene(2);
      }
    }

  }
}
