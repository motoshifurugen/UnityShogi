using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KomaKe : KomaBase
{
    // 桂馬の移動可能マスリスト
    public List<KomaMove> GetMoves(bool reverse = false) {

        // 相手の場合は、逆にする
        int reversenum = 1;
        if (reverse) {
            reversenum = -1;
        }

        List<KomaMove> moves = new List<KomaMove>();
        // 左上
        KomaMove move5 = new KomaMove();
        move5.x = -1;
        move5.y = -2 * reversenum;
        moves.Add(move5);
        // 右上
        KomaMove move7 = new KomaMove();
        move7.x = 1;
        move7.y = -2 * reversenum;
        moves.Add(move7);

        return moves;
    }
}
