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
            GameObject shogibanObj = GameObject.Find("Shogiban");
            ShogibanScript shogibanScript = shogibanObj.GetComponent<ShogibanScript>();
            GameObject clickedGameObject = null;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit2d = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);

            if (shogibanScript.chooseflg) {
                // 選択状態だった場合は移動可能マス表示を消す
                shogibanScript.DelChooseMoves();
            } else {
                // クリックされたgameObjectを取得して、その駒に応じた移動可能マスを取得するスクリプトを実行する。
                if (hit2d) {
                    clickedGameObject = hit2d.transform.gameObject; // クリックされたgameObjectを取得
                    string komaname = clickedGameObject.name;
                    List<KomaMove> moves = new List<KomaMove>();
                    if (komaname.Equals(KomaInit.KomaOu) || komaname.Equals(KomaInit.KomaOu2)) {
                        KomaOu koma = new KomaOu();
                        moves = koma.GetMoves();
                    } else if (komaname.Equals(KomaInit.KomaHi) || komaname.Equals(KomaInit.KomaHi2)) {
                        KomaHi koma = new KomaHi();
                        moves = koma.GetMoves();
                    } else if (komaname.Equals(KomaInit.KomaKa) || komaname.Equals(KomaInit.KomaKa2)) {
                        KomaKa koma = new KomaKa();
                        moves = koma.GetMoves();
                    } else if (komaname.Equals(KomaInit.KomaKi)) {
                        KomaKi koma = new KomaKi();
                        moves = koma.GetMoves();
                    } else if (komaname.Equals(KomaInit.KomaGi)) {
                        KomaGi koma = new KomaGi();
                        moves = koma.GetMoves();
                    } else if (komaname.Equals(KomaInit.KomaKe)) {
                        KomaKe koma = new KomaKe();
                        moves = koma.GetMoves();
                    } else if (komaname.Equals(KomaInit.KomaKy)) {
                        KomaKy koma = new KomaKy();
                        moves = koma.GetMoves();
                    } else if (komaname.Equals(KomaInit.KomaFu)) {
                        KomaFu koma = new KomaFu();
                        moves = koma.GetMoves();
                    } else if (komaname.Equals(KomaInit.KomaKi2)) {
                        KomaKi koma = new KomaKi();
                        moves = koma.GetMoves(true);
                    } else if (komaname.Equals(KomaInit.KomaGi2)) {
                        KomaGi koma = new KomaGi();
                        moves = koma.GetMoves(true);
                    } else if (komaname.Equals(KomaInit.KomaKe2)) {
                        KomaKe koma = new KomaKe();
                        moves = koma.GetMoves(true);
                    } else if (komaname.Equals(KomaInit.KomaKy2)) {
                        KomaKy koma = new KomaKy();
                        moves = koma.GetMoves(true);
                    } else if (komaname.Equals(KomaInit.KomaFu2)) {
                        KomaFu koma = new KomaFu();
                        moves = koma.GetMoves(true);
                    }
                    // CanvasScriptのメソッドを呼び出す
                    GameObject refObj = GameObject.Find("Canvas");
                    CanvasScript canvas = refObj.GetComponent<CanvasScript>(); // CanvasScriptを取得
                    GameObject komaObj = clickedGameObject;
                    KomaScript sc = komaObj.GetComponent<KomaScript>();
                    canvas.RefreshHits(sc, moves);
                }
            }
        }
    }
}
