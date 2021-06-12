using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ButtonManager : MonoBehaviour
{
    public void PLAY()
    {
        SceneManager.LoadScene("LEVEL");
    }
    public void HOME()
    {
        SceneManager.LoadScene("HOME");
    }
    public void INFOR()
    {
        SceneManager.LoadScene("Information");
    }
}
