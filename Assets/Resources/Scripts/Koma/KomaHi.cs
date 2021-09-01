using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KomaHi : KomaBase
{
    // 飛車の移動可能マスリスト
    public List<KomaMove> GetMoves() {
        List<KomaMove> moves = new List<KomaMove>();
        for (int i = 1; i <= 8; i++) {
            // 下方向
            KomaMove move2 = new KomaMove();
            move2.x = 0;
            move2.y = i;
            moves.Add(move2);
        }
        for (int i = 1; i <= 8; i++) {
            // 左方向
            KomaMove move4 = new KomaMove();
            move4.x = -1 * i;
            move4.y = 0;
            moves.Add(move4);
        }
        for (int i = 1; i <= 8; i++) {
            // 上方向
            KomaMove move6 = new KomaMove();
            move6.x = 0;
            move6.y = -1 * i;
            moves.Add(move6);
        }
        for (int i = 1; i <= 8; i++) {
            // 右方向
            KomaMove move8 = new KomaMove();
            move8.x = i;
            move8.y = 0;
            moves.Add(move8);
        }

        return moves;
    }
}
