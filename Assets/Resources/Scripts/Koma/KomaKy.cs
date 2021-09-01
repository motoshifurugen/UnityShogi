using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KomaKy : KomaBase
{
    // 香車の移動可能マスリスト
    public List<KomaMove> GetMoves(bool reverse = false) {

        // 相手の場合は、逆にする
        int reversenum = 1;
        if (reverse) {
            reversenum = -1;
        }

        List<KomaMove> moves = new List<KomaMove>();
        for (int i = 1; i <= 8; i++) {
            // 上方向
            KomaMove move6 = new KomaMove();
            move6.x = 0;
            move6.y = -1 * i * reversenum;
            moves.Add(move6);
        }

        return moves;
    }
}
