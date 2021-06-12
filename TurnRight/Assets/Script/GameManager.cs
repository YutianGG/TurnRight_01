using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    [Header("移動步數")]
    public int move;
    [Header("星星數量")]
    public GameObject[] stars;
    public GameObject[] winstar;
    [Header("減星步數")]
    public int[] nostar;
    [Header("移動文字")]
    public Text MoveText;
    [Header("勝利介面")]
    public GameObject win;
    [Header("玩家物件")]
    public GameObject play;
    

    public static int star = 3;
    
    private void Start()
    {
        move = 0;
    }
    private void Update()
    {
        
        SetStar();
        WalkText();
    }
    /// <summary>
    /// 減少移動步數
    /// </summary>
    public void Walk()
    {
        move++;
    }
    /// <summary>
    /// 星星顯示數量
    /// </summary>
    private void SetStar()
    {
        for (int i = 0; i < stars.Length; i++)
        {
            if (nostar[i] < move)
            {
                stars[i].SetActive(false);
                winstar[i].SetActive(false);
                star = i;
            }
           
                
        }
        
    }
    /// <summary>
    /// 移動步數顯示
    /// </summary>
    private void WalkText()
    {
        MoveText.text = move.ToString();
    }
    /// <summary>
    /// 遊戲過關紀錄星星
    /// </summary>
    public void GameWIN()
    {
        if (PlayerPrefs.GetInt("L") <= SceneManager.GetActiveScene().buildIndex)
        {
            
            PlayerPrefs.SetInt("L", SceneManager.GetActiveScene().buildIndex);
            print(PlayerPrefs.GetInt("L"));
        }
        win.SetActive(true);
        play.SetActive(false);
       
    }

    
 
}
