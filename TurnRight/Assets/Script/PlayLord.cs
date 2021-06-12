using UnityEngine;

public class PlayLord : MonoBehaviour
{
    [Header("關卡數量")]
    public GameObject[] level;
    [Header("關卡進度")]
    private int lv;

    private void Awake()
    {
       //PlayerPrefs.DeleteAll();
        lv = PlayerPrefs.GetInt("L");
        print(lv);
    }
    private void Start()
    {
        Lordlv();
    }
    private void Lordlv()
    {
        for(int i = 0; i < level.Length; i++)
        {
            if(i > lv)
            {
                level[i].SetActive(false);
            }
        }
    }
}
