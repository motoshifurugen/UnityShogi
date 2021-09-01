using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KomaGi : KomaBase
{
    // 銀将の移動可能マスリスト
    public List<KomaMove> GetMoves(bool reverse = false) {

        // 相手の場合は、逆にする
        int reversenum = 1;
        if (reverse) {
            reversenum = -1;
        }

        List<KomaMove> moves = new List<KomaMove>();
        // 右下
        KomaMove move = new KomaMove();
        move.x = 1;
        move.y = 1 * reversenum;
        moves.Add(move);
        // 左下
        KomaMove move3 = new KomaMove();
        move3.x = -1;
        move3.y = 1 * reversenum;
        moves.Add(move3);
        // 左上
        KomaMove move5 = new KomaMove();
        move5.x = -1;
        move5.y = -1 * reversenum;
        moves.Add(move5);
        // 上
        KomaMove move6 = new KomaMove();
        move6.x = 0;
        move6.y = -1 * reversenum;
        moves.Add(move6);
        // 右上
        KomaMove move7 = new KomaMove();
        move7.x = 1;
        move7.y = -1 * reversenum;
        moves.Add(move7);

        return moves;
    }
}
