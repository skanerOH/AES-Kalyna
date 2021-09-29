using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace crypto_lab1
{
    public class Kalyna
    {
        private KalynaBlock Key { get; }
        private List<KalynaBlock> RoundsKeys { get; } = new List<KalynaBlock>();

        public Kalyna(byte[] key)
        {
            Key = new KalynaBlock(key);
            GenerateRoundsKeys();
        }

        private KalynaBlock GenerateKt()
        {
            var kt = new KalynaBlock
            {
                Data = new List<byte>
                {
                    0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5
                }
            };

            kt.AddRoundKey(Key);

            kt.SubBytes(StaticTables.kalynaForwardSBoxes);

            kt.ShiftRows();

            kt.MixColumns(StaticTables.Mds);

            kt.Xor(Key);

            kt.SubBytes(StaticTables.kalynaForwardSBoxes);

            kt.ShiftRows();

            kt.MixColumns(StaticTables.Mds);

            kt.AddRoundKey(Key);

            kt.SubBytes(StaticTables.kalynaForwardSBoxes);

            kt.ShiftRows();

            kt.MixColumns(StaticTables.Mds);

            return kt;
        }

        public void GenerateRoundsKeys()
        {
            for (var i = 0; i <= 10; i++)
                RoundsKeys.Add(new KalynaBlock());

            var kt = GenerateKt();

            for (var i = 0; i <= 10; i += 2)
            {
                var roundKey = RoundsKeys[i];
                roundKey.Data = new List<byte>(StaticTables.V);
                roundKey.ShiftLeft(i / 2);

                var keyCopy = new KalynaBlock(Key);
                keyCopy.RotateRight(32 * i);

                roundKey.AddRoundKey(kt);
                var copy = new KalynaBlock(roundKey);

                roundKey.AddRoundKey(keyCopy);

                roundKey.SubBytes(StaticTables.kalynaForwardSBoxes);

                roundKey.ShiftRows();

                roundKey.MixColumns(StaticTables.Mds);

                roundKey.Xor(copy);

                roundKey.SubBytes(StaticTables.kalynaForwardSBoxes);

                roundKey.ShiftRows();

                roundKey.MixColumns(StaticTables.Mds);

                roundKey.AddRoundKey(copy);

                RoundsKeys[i] = roundKey;
            }

            for (var i = 1; i <= 9; i += 2)
            {
                RoundsKeys[i].Data = RoundsKeys[i - 1].Data;
                RoundsKeys[i].RotateLeft(56);
            }
        }

        public KalynaBlock Encrypt(KalynaBlock plainText)
        {
            var cipherText = new KalynaBlock(plainText);
            cipherText.AddRoundKey(RoundsKeys[0]);

            for (var i = 1; i <= 9; i++)
            {

                cipherText.SubBytes(StaticTables.kalynaForwardSBoxes);

                cipherText.ShiftRows();

                cipherText.MixColumns(StaticTables.Mds);

                cipherText.Xor(RoundsKeys[i]);
            }

            cipherText.SubBytes(StaticTables.kalynaForwardSBoxes);

            cipherText.ShiftRows();

            cipherText.MixColumns(StaticTables.Mds);

            cipherText.AddRoundKey(RoundsKeys[10]);

            return cipherText;
        }

        public KalynaBlock Decrypt(KalynaBlock cipherText)
        {
            var plainText = new KalynaBlock(cipherText);

            plainText.SubRoundKey(RoundsKeys[10]);

            plainText.MixColumns(StaticTables.MdsRev);

            plainText.ShiftRowsRev();

            plainText.SubBytes(StaticTables.kalynaInverseSBoxes);

            for (var i = 9; 1 <= i; --i)
            {
                plainText.Xor(RoundsKeys[i]);

                plainText.MixColumns(StaticTables.MdsRev);

                plainText.ShiftRowsRev();

                plainText.SubBytes(StaticTables.kalynaInverseSBoxes);
            }

            plainText.SubRoundKey(RoundsKeys[0]);
            return plainText;
        }
    }
}
