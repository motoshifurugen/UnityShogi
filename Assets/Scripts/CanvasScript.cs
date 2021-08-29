using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasScript : MonoBehaviour
{
    void Start() {
        string komaOu = "w_ou";
        string komaHi = "w_hisya";
        string komaKa = "w_kaku";
        string komaKi = "w_kin";
        string komaGi = "w_gin";
        string komaKe = "w_kei";
        string komaKy = "w_kyou";
        string komaFu = "w_fu";

        float per1x = 0.67f;  // 1マス分の横の長さ
        float per1y = 0.67f;  // 1マス分の縦の長さ
        float basex = 2.68f + per1x;
        float basey = 2.67f + per1y;
        Vector3 komaScale = new Vector3(1.38f, 1.38f, 0); // 大きさを指定
        // transform.Findで子オブジェクトを検索できる。
        Transform komaOuTrans = transform.Find(komaOu).gameObject.transform;
        Transform komaHiTrans = transform.Find(komaHi).gameObject.transform;
        Transform komaKaTrans = transform.Find(komaKa).gameObject.transform;
        Transform komaKiTrans = transform.Find(komaKi).gameObject.transform;
        Transform komaGiTrans = transform.Find(komaGi).gameObject.transform;
        Transform komaKeTrans = transform.Find(komaKe).gameObject.transform;
        Transform komaKyTrans = transform.Find(komaKy).gameObject.transform;
        Transform komaFuTrans = transform.Find(komaFu).gameObject.transform;

        // 位置と大きさを代入
        komaOuTrans.position = new Vector3(basex - per1x * 5, basey - per1y * 9, 2); // 5九に王
        komaOuTrans.localScale = komaScale;
        komaHiTrans.position = new Vector3(basex - per1x * 2, basey - per1y * 8, 2); // 2八に飛車
        komaHiTrans.localScale = komaScale;
        komaKaTrans.position = new Vector3(basex - per1x * 8, basey - per1y * 8, 2); // 8八に角
        komaKaTrans.localScale = komaScale;
        komaKiTrans.position = new Vector3(basex - per1x * 4, basey - per1y * 9, 2); // 4九に金
        komaKiTrans.localScale = komaScale;
        komaGiTrans.position = new Vector3(basex - per1x * 3, basey - per1y * 9, 2); // 3九に銀
        komaGiTrans.localScale = komaScale;
        komaKeTrans.position = new Vector3(basex - per1x * 2, basey - per1y * 9, 2); // 2九に桂
        komaKeTrans.localScale = komaScale;
        komaKyTrans.position = new Vector3(basex - per1x * 1, basey - per1y * 9, 2); // 1九に香
        komaKyTrans.localScale = komaScale;
        komaFuTrans.position = new Vector3(basex - per1x * 5, basey - per1y * 7, 2); // 5七に歩
        komaFuTrans.localScale = komaScale;
    }

    void Update() {
        
    }
}
