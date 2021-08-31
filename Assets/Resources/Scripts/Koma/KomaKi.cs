using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KomaKi : KomaBase
{
    // 王将の移動可能マスリスト
    public List<KomaMove> GetMoves() {
        List<KomaMove> moves = new List<KomaMove>();
        // 下
        KomaMove move2 = new KomaMove();
        move2.x = 0;
        move2.y = 1;
        moves.Add(move2);
        // 左
        KomaMove move4 = new KomaMove();
        move4.x = -1;
        move4.y = 0;
        moves.Add(move4);
        // 左上
        KomaMove move5 = new KomaMove();
        move5.x = -1;
        move5.y = -1;
        moves.Add(move5);
        // 上
        KomaMove move6 = new KomaMove();
        move6.x = 0;
        move6.y = -1;
        moves.Add(move6);
        // 右上
        KomaMove move7 = new KomaMove();
        move7.x = 1;
        move7.y = -1;
        moves.Add(move7);
        // 右
        KomaMove move8 = new KomaMove();
        move8.x = 1;
        move8.y = 0;
        moves.Add(move8);

        return moves;
    }
}
