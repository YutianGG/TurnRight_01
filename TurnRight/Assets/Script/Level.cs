using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Level : MonoBehaviour
{
   public void ChangeLevel()
    {
        SceneManager.LoadScene(int.Parse(gameObject.name));
    }
}
