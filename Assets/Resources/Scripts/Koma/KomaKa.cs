using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KomaKa : KomaBase
{
    // 角行の移動可能マスリスト
    public List<KomaMove> GetMoves() {
        List<KomaMove> moves = new List<KomaMove>();
        for (int i = 1; i <= 8; i++) {
            // 右下方向
            KomaMove move = new KomaMove();
            move.x = i;
            move.y = i;
            moves.Add(move);
        }
        for (int i = 1; i <= 8; i++) {
            // 左下方向
            KomaMove move3 = new KomaMove();
            move3.x = -1 * i;
            move3.y = i;
            moves.Add(move3);
        }
        for (int i = 1; i <= 8; i++) {
            // 左上方向
            KomaMove move5 = new KomaMove();
            move5.x = -1 * i;
            move5.y = -1 * i;
            moves.Add(move5);
        }
        for (int i = 1; i <= 8; i++) {
            // 右上
            KomaMove move7 = new KomaMove();
            move7.x = i;
            move7.y = -1 * i;
            moves.Add(move7);
        }

        return moves;
    }
}
