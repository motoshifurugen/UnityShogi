using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShogibanScript : MonoBehaviour
{
    public bool chooseflg = false;
    public List<KomaMove> choosemoves = new List<KomaMove>();

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    // 選択可能マスの表示を消す
    public void DelChooseMoves() {
        if (chooseflg) {
            int i = 0;
            if (choosemoves != null && choosemoves.Count > 0) {
                foreach (KomaMove move in choosemoves) {
                    Debug.Log("koma_able" + i);
                    GameObject obj = transform.Find("Canvas/koma_able" + i).gameObject; // エラー起きる
                    if (obj = null) {
                        Debug.Log("koma_ableが取れてないよ");
                    } else {
                        Debug.Log("koma_ableはある");
                        Destroy (obj);
                    }
                    i++;
                }
            }
            chooseflg = false;
        }
    }
}
