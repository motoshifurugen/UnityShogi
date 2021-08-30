using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasScript : MonoBehaviour
{
    void Start() {
        // わかりやすいように駒の名前をつける
        string b_Ou = "shogi_0";
        string b_Hi = "shogi_1";
        string b_Ka = "shogi_2";
        string b_Ki = "shogi_3";
        string b_Gi = "shogi_4";
        string b_Ke = "shogi_5";
        string b_Ky = "shogi_6";
        string b_Fu = "shogi_7";
        string b_Hi_n = "shogi_9";
        string b_Ka_n = "shogi_10";
        string b_Gi_n = "shogi_11";
        string b_Ke_n = "shogi_12";
        string b_Ky_n = "shogi_13";
        string b_Fu_n = "shogi_14";
        string w_Ou = "shogi_15";
        string w_Hi = "shogi_16";
        string w_Ka = "shogi_17";
        string w_Ki = "shogi_18";
        string w_Gi = "shogi_19";
        string w_Ke = "shogi_20";
        string w_Ky = "shogi_21";
        string w_Fu = "shogi_22";
        string w_Hi_n = "shogi_24";
        string w_Ka_n = "shogi_25";
        string w_Gi_n = "shogi_26";
        string w_Ke_n = "shogi_27";
        string w_Ky_n = "shogi_28";
        string w_Fu_n = "shogi_29";

        // 自陣駒配置
        createKomaObj(b_Ou, 5, 9); // 5九に王
        createKomaObj(b_Hi, 2, 8); // 2八に飛車
        createKomaObj(b_Ka, 8, 8); // 8八に角
        createKomaObj(b_Ki, 4, 9); // 4九に金
        createKomaObj(b_Ki, 6, 9); // 6九に金
        createKomaObj(b_Gi, 3, 9); // 3九に銀
        createKomaObj(b_Gi, 7, 9); // 7九に銀
        createKomaObj(b_Ke, 2, 9); // 2九に桂
        createKomaObj(b_Ke, 8, 9); // 8九に桂
        createKomaObj(b_Ky, 1, 9); // 1九に香
        createKomaObj(b_Ky, 9, 9); // 9九に香
        createKomaObj(b_Fu, 1, 7); // 1七に歩
        createKomaObj(b_Fu, 2, 7); // 2七に歩
        createKomaObj(b_Fu, 3, 7); // 3七に歩
        createKomaObj(b_Fu, 4, 7); // 4七に歩
        createKomaObj(b_Fu, 5, 7); // 5七に歩
        createKomaObj(b_Fu, 6, 7); // 6七に歩
        createKomaObj(b_Fu, 7, 7); // 7七に歩
        createKomaObj(b_Fu, 8, 7); // 8七に歩
        createKomaObj(b_Fu, 9, 7); // 9七に歩
        // 敵陣駒配置
        createKomaObj(w_Ou, 5, 1); // 5一に王
        createKomaObj(w_Hi, 2, 2); // 2二に飛車
        createKomaObj(w_Ka, 8, 2); // 8二に角
        createKomaObj(w_Ki, 4, 1); // 4一に金
        createKomaObj(w_Ki, 6, 1); // 6一に金
        createKomaObj(w_Gi, 3, 1); // 3一に銀
        createKomaObj(w_Gi, 7, 1); // 7一に銀
        createKomaObj(w_Ke, 2, 1); // 2一に桂
        createKomaObj(w_Ke, 8, 1); // 8一に桂
        createKomaObj(w_Ky, 1, 1); // 1一に香
        createKomaObj(w_Ky, 9, 1); // 9一に香
        createKomaObj(w_Fu, 1, 3); // 1三に歩
        createKomaObj(w_Fu, 2, 3); // 2三に歩
        createKomaObj(w_Fu, 3, 3); // 3三に歩
        createKomaObj(w_Fu, 4, 3); // 4三に歩
        createKomaObj(w_Fu, 5, 3); // 5三に歩
        createKomaObj(w_Fu, 6, 3); // 6三に歩
        createKomaObj(w_Fu, 7, 3); // 7三に歩
        createKomaObj(w_Fu, 8, 3); // 8三に歩
        createKomaObj(w_Fu, 9, 3); // 9三に歩
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
        gameObj.AddComponent<KomaScript>(); // コマのScriptをアタッチする
    }

    void Update() {
        
    }
}
