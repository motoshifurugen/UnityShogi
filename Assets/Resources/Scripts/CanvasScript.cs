using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasScript : MonoBehaviour
{
    void Start() {
        // 自陣駒配置
        createKomaObj(KomaInit.KomaOu, 5, 9); // 5九に王
        createKomaObj(KomaInit.KomaHi, 2, 8); // 2八に飛車
        createKomaObj(KomaInit.KomaKa, 8, 8); // 8八に角
        createKomaObj(KomaInit.KomaKi, 4, 9); // 4九に金
        createKomaObj(KomaInit.KomaKi, 6, 9); // 6九に金
        createKomaObj(KomaInit.KomaGi, 3, 9); // 3九に銀
        createKomaObj(KomaInit.KomaGi, 7, 9); // 7九に銀
        createKomaObj(KomaInit.KomaKe, 2, 9); // 2九に桂
        createKomaObj(KomaInit.KomaKe, 8, 9); // 8九に桂
        createKomaObj(KomaInit.KomaKy, 1, 9); // 1九に香
        createKomaObj(KomaInit.KomaKy, 9, 9); // 9九に香
        for (int i = 1; i <= 9; i++) {
            createKomaObj(KomaInit.KomaFu, i, 7);
        }
            // 敵陣駒配置
        createKomaObj(KomaInit.KomaOu2, 5, 1); // 5一に王
        createKomaObj(KomaInit.KomaHi2, 2, 2); // 2二に飛車
        createKomaObj(KomaInit.KomaKa2, 8, 2); // 8二に角
        createKomaObj(KomaInit.KomaKi2, 4, 1); // 4一に金
        createKomaObj(KomaInit.KomaKi2, 6, 1); // 6一に金
        createKomaObj(KomaInit.KomaGi2, 3, 1); // 3一に銀
        createKomaObj(KomaInit.KomaGi2, 7, 1); // 7一に銀
        createKomaObj(KomaInit.KomaKe2, 2, 1); // 2一に桂
        createKomaObj(KomaInit.KomaKe2, 8, 1); // 8一に桂
        createKomaObj(KomaInit.KomaKy2, 1, 1); // 1一に香
        createKomaObj(KomaInit.KomaKy2, 9, 1); // 9一に香
        for (int i = 1; i <= 9; i++) {
            createKomaObj(KomaInit.KomaFu2, i, 3);
        }
    }

    // Project/Assets/Resources配下からコマを取り出して盤面に配置するメソッド
    void createKomaObj(string name, int x, int y) {

        float per1x = 0.67f;  // 1マス分の横の長さ
        float per1y = 0.67f;  // 1マス分の縦の長さ
        float basex = 2.68f + per1x;
        float basey = 2.67f + per1y;
        Vector3 komaScale = new Vector3(1, 1, 0); // 大きさを指定

        Sprite[] sprites = Resources.LoadAll<Sprite>("Texture/koma");
        Sprite sp = System.Array.Find<Sprite>(sprites, (sprite) => (sprite.name == name));
        GameObject gameObj = new GameObject();
        SpriteRenderer spriteRenderer = gameObj.AddComponent<SpriteRenderer>();
        spriteRenderer.sprite = sp; // System.Array.Findで取得したspriteを貼り付ける
        gameObj.transform.parent = FindObjectOfType<Canvas>().transform;
        gameObj.transform.name = name; // オブジェクトに名前をつける
        gameObj.transform.localScale = komaScale; // コマの大きさを割り当てる
        gameObj.transform.position = new Vector3(basex - per1x * x, basey - per1y * y, 2); // コマの位置を割り当てる
        BoxCollider2D box = gameObj.AddComponent<BoxCollider2D>() as BoxCollider2D; // BoxCollider2Dをアタッチする
        KomaScript sc = gameObj.AddComponent<KomaScript>(); // コマのScriptをアタッチする
        sc.x = x;
        sc.y = y;
    }

    void Update() {
        
    }

    // 移動可能マスを表示する
    public void RefreshHits(KomaScript sc, List<KomaMove> moves) {
        GameObject refObj = GameObject.Find("Shogiban");
        ShogibanScript shogibanScript = refObj.GetComponent<ShogibanScript>();

        float per1x = 0.67f;  // 1マス分の横の長さ
        float per1y = 0.67f;  // 1マス分の縦の長さ
        float basex = 2.68f + per1x;
        float basey = 2.67f + per1y;

        if (!shogibanScript.chooseflg) {
            // 選択状態でなければ、移動可能マスを取得する
            int i = 0;
            foreach (KomaMove move in moves) {
                // // はみ出す移動可能マスの修正
                // if (((sc.x + move.x) > 9 || (sc.x + move.x) < 1) || ((sc.y + move.y) > 9 || (sc.y + move.y) < 1)) {
                //     continue;
                // }
                Sprite sp = Resources.Load<Sprite>("Texture/koma_able"); // 移動可能マスに貼り付ける画像を取得
                GameObject gameObj = new GameObject();
                SpriteRenderer spriteRenderer = gameObj.AddComponent<SpriteRenderer>();
                spriteRenderer.sprite = sp; // 移動可能マス用の画像を貼り付ける
                gameObj.transform.parent = FindObjectOfType<Canvas>().transform;
                gameObj.transform.localScale = new Vector3(0.50f, 0.50f, 0); // 大きさを調整する
                gameObj.transform.name = "koma_able" + i;
                gameObj.transform.position = new Vector3(basex - per1x * (sc.x + move.x), basey - per1y * (sc.y + move.y), 20);
                i++;
            }
            shogibanScript.chooseflg = true; // 選択中フラグを立てる
            shogibanScript.choosemoves = moves;
        }
    }
}
