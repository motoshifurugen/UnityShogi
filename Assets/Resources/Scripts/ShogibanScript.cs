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
                    GameObject obj = transform.parent.Find("koma_able" + i).gameObject;
                    Destroy(obj);
                    i++;
                }
            }
            chooseflg = false;
        }
    }
}
