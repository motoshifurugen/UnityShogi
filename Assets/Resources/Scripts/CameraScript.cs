using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            Vector2 tap = Camera.main.ScreenToWorldPoint(Input.mousePosition); // マウスがクリックされた位置を取得する
            Collider2D collision = Physics2D.OverlapPoint(tap);
            GameObject shogibanObj = GameObject.Find("Shogiban");
            ShogibanScript shogibanScript = shogibanObj.GetComponent<ShogibanScript>();
            if (shogibanScript.chooseflg) {
                // 選択状態だった場合は移動可能マス表示を消す
                shogibanScript.DelChooseMoves();
            } else {
                if (collision) {
                    string name = collision.transform.gameObject.name;
                    string[] names = name.Split(new char[]{'_'});
                    string komaname = "shogi_" + names[1];
                    Debug.Log(komaname);
                    List<KomaMove> moves = new List<KomaMove>();
                    if (komaname.Equals(KomaInit.KomaOu)) {
                        KomaOu koma = new KomaOu();
                        moves = koma.GetMoves();
                    } else if (komaname.Equals(KomaInit.KomaKi)) {
                        KomaKi koma = new KomaKi();
                        moves = koma.GetMoves();
                    }

                    // CanvasScriptのメソッドを呼び出す
                    GameObject refObj = GameObject.Find("Canvas");
                    CanvasScript canvas = refObj.GetComponent<CanvasScript>(); // CanvasScriptを取得
                    GameObject komaObj = GameObject.Find(name);
                    KomaScript sc = komaObj.GetComponent<KomaScript>();
                    canvas.RefreshHits(sc, moves);
                }
            }
        }
    }
}
