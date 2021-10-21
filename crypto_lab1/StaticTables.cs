﻿using System;
using System.Collections.Generic;
using System.Text;

namespace crypto_lab1
{
    public static class StaticTables
    {
        // Tables for AES

        public static readonly byte[] forwardSBox = new byte[256] {
            //0     1    2      3     4    5     6     7      8    9     A      B    C     D     E     F
            0x63, 0x7c, 0x77, 0x7b, 0xf2, 0x6b, 0x6f, 0xc5, 0x30, 0x01, 0x67, 0x2b, 0xfe, 0xd7, 0xab, 0x76, //0
            0xca, 0x82, 0xc9, 0x7d, 0xfa, 0x59, 0x47, 0xf0, 0xad, 0xd4, 0xa2, 0xaf, 0x9c, 0xa4, 0x72, 0xc0, //1
            0xb7, 0xfd, 0x93, 0x26, 0x36, 0x3f, 0xf7, 0xcc, 0x34, 0xa5, 0xe5, 0xf1, 0x71, 0xd8, 0x31, 0x15, //2
            0x04, 0xc7, 0x23, 0xc3, 0x18, 0x96, 0x05, 0x9a, 0x07, 0x12, 0x80, 0xe2, 0xeb, 0x27, 0xb2, 0x75, //3
            0x09, 0x83, 0x2c, 0x1a, 0x1b, 0x6e, 0x5a, 0xa0, 0x52, 0x3b, 0xd6, 0xb3, 0x29, 0xe3, 0x2f, 0x84, //4
            0x53, 0xd1, 0x00, 0xed, 0x20, 0xfc, 0xb1, 0x5b, 0x6a, 0xcb, 0xbe, 0x39, 0x4a, 0x4c, 0x58, 0xcf, //5
            0xd0, 0xef, 0xaa, 0xfb, 0x43, 0x4d, 0x33, 0x85, 0x45, 0xf9, 0x02, 0x7f, 0x50, 0x3c, 0x9f, 0xa8, //6
            0x51, 0xa3, 0x40, 0x8f, 0x92, 0x9d, 0x38, 0xf5, 0xbc, 0xb6, 0xda, 0x21, 0x10, 0xff, 0xf3, 0xd2, //7
            0xcd, 0x0c, 0x13, 0xec, 0x5f, 0x97, 0x44, 0x17, 0xc4, 0xa7, 0x7e, 0x3d, 0x64, 0x5d, 0x19, 0x73, //8
            0x60, 0x81, 0x4f, 0xdc, 0x22, 0x2a, 0x90, 0x88, 0x46, 0xee, 0xb8, 0x14, 0xde, 0x5e, 0x0b, 0xdb, //9
            0xe0, 0x32, 0x3a, 0x0a, 0x49, 0x06, 0x24, 0x5c, 0xc2, 0xd3, 0xac, 0x62, 0x91, 0x95, 0xe4, 0x79, //A
            0xe7, 0xc8, 0x37, 0x6d, 0x8d, 0xd5, 0x4e, 0xa9, 0x6c, 0x56, 0xf4, 0xea, 0x65, 0x7a, 0xae, 0x08, //B
            0xba, 0x78, 0x25, 0x2e, 0x1c, 0xa6, 0xb4, 0xc6, 0xe8, 0xdd, 0x74, 0x1f, 0x4b, 0xbd, 0x8b, 0x8a, //C
            0x70, 0x3e, 0xb5, 0x66, 0x48, 0x03, 0xf6, 0x0e, 0x61, 0x35, 0x57, 0xb9, 0x86, 0xc1, 0x1d, 0x9e, //D
            0xe1, 0xf8, 0x98, 0x11, 0x69, 0xd9, 0x8e, 0x94, 0x9b, 0x1e, 0x87, 0xe9, 0xce, 0x55, 0x28, 0xdf, //E
            0x8c, 0xa1, 0x89, 0x0d, 0xbf, 0xe6, 0x42, 0x68, 0x41, 0x99, 0x2d, 0x0f, 0xb0, 0x54, 0xbb, 0x16 }; //F

        public static readonly byte[] inverseSBox = new byte[256] {
            //0     1    2      3     4    5     6     7      8    9     A      B    C     D     E     F
            0x52, 0x09, 0x6A, 0xD5, 0x30, 0x36, 0xA5, 0x38, 0xBF, 0x40, 0xA3, 0x9E, 0x81, 0xF3, 0xD7, 0xFB, //0
            0x7C, 0xE3, 0x39, 0x82, 0x9B, 0x2F, 0xFF, 0x87, 0x34, 0x8E, 0x43, 0x44, 0xC4, 0xDE, 0xE9, 0xCB, //1
            0x54, 0x7B, 0x94, 0x32, 0xA6, 0xC2, 0x23, 0x3D, 0xEE, 0x4C, 0x95, 0x0B, 0x42, 0xFA, 0xC3, 0x4E, //2
            0x08, 0x2E, 0xA1, 0x66, 0x28, 0xD9, 0x24, 0xB2, 0x76, 0x5B, 0xA2, 0x49, 0x6D, 0x8B, 0xD1, 0x25, //3
            0x72, 0xF8, 0xF6, 0x64, 0x86, 0x68, 0x98, 0x16, 0xD4, 0xA4, 0x5C, 0xCC, 0x5D, 0x65, 0xB6, 0x92, //4
            0x6C, 0x70, 0x48, 0x50, 0xFD, 0xED, 0xB9, 0xDA, 0x5E, 0x15, 0x46, 0x57, 0xA7, 0x8D, 0x9D, 0x84, //5
            0x90, 0xD8, 0xAB, 0x00, 0x8C, 0xBC, 0xD3, 0x0A, 0xF7, 0xE4, 0x58, 0x05, 0xB8, 0xB3, 0x45, 0x06, //6
            0xD0, 0x2C, 0x1E, 0x8F, 0xCA, 0x3F, 0x0F, 0x02, 0xC1, 0xAF, 0xBD, 0x03, 0x01, 0x13, 0x8A, 0x6B, //7
            0x3A, 0x91, 0x11, 0x41, 0x4F, 0x67, 0xDC, 0xEA, 0x97, 0xF2, 0xCF, 0xCE, 0xF0, 0xB4, 0xE6, 0x73, //8
            0x96, 0xAC, 0x74, 0x22, 0xE7, 0xAD, 0x35, 0x85, 0xE2, 0xF9, 0x37, 0xE8, 0x1C, 0x75, 0xDF, 0x6E, //9
            0x47, 0xF1, 0x1A, 0x71, 0x1D, 0x29, 0xC5, 0x89, 0x6F, 0xB7, 0x62, 0x0E, 0xAA, 0x18, 0xBE, 0x1B, //A
            0xFC, 0x56, 0x3E, 0x4B, 0xC6, 0xD2, 0x79, 0x20, 0x9A, 0xDB, 0xC0, 0xFE, 0x78, 0xCD, 0x5A, 0xF4, //B
            0x1F, 0xDD, 0xA8, 0x33, 0x88, 0x07, 0xC7, 0x31, 0xB1, 0x12, 0x10, 0x59, 0x27, 0x80, 0xEC, 0x5F, //C
            0x60, 0x51, 0x7F, 0xA9, 0x19, 0xB5, 0x4A, 0x0D, 0x2D, 0xE5, 0x7A, 0x9F, 0x93, 0xC9, 0x9C, 0xEF, //D
            0xA0, 0xE0, 0x3B, 0x4D, 0xAE, 0x2A, 0xF5, 0xB0, 0xC8, 0xEB, 0xBB, 0x3C, 0x83, 0x53, 0x99, 0x61, //E
            0x17, 0x2B, 0x04, 0x7E, 0xBA, 0x77, 0xD6, 0x26, 0xE1, 0x69, 0x14, 0x63, 0x55, 0x21, 0x0C, 0x7D }; //F



        // Tables for Kalyna
        public static readonly List<byte> V = new List<byte>
        {
            0, 1, 0, 1, 0, 1, 0, 1,
            0, 1, 0, 1, 0, 1, 0, 1
        };

        public static readonly byte[][][] kalynaForwardSBoxes =
        {
            new [] {
                new byte[] { 0xA8, 0x43, 0x5F, 0x06, 0x6B, 0x75, 0x6C, 0x59, 0x71, 0xDF, 0x87, 0x95, 0x17, 0xF0, 0xD8, 0x09 },
                new byte[] { 0x6D, 0xF3, 0x1D, 0xCB, 0xC9, 0x4D, 0x2C, 0xAF, 0x79, 0xE0, 0x97, 0xFD, 0x6F, 0x4B, 0x45, 0x39 },
                new byte[] { 0x3E, 0xDD, 0xA3, 0x4F, 0xB4, 0xB6, 0x9A, 0x0E, 0x1F, 0xBF, 0x15, 0xE1, 0x49, 0xD2, 0x93, 0xC6 },
                new byte[] { 0x92, 0x72, 0x9E, 0x61, 0xD1, 0x63, 0xFA, 0xEE, 0xF4, 0x19, 0xD5, 0xAD, 0x58, 0xA4, 0xBB, 0xA1 },
                new byte[] { 0xDC, 0xF2, 0x83, 0x37, 0x42, 0xE4, 0x7A, 0x32, 0x9C, 0xCC, 0xAB, 0x4A, 0x8F, 0x6E, 0x04, 0x27 },
                new byte[] { 0x2E, 0xE7, 0xE2, 0x5A, 0x96, 0x16, 0x23, 0x2B, 0xC2, 0x65, 0x66, 0x0F, 0xBC, 0xA9, 0x47, 0x41 },
                new byte[] { 0x34, 0x48, 0xFC, 0xB7, 0x6A, 0x88, 0xA5, 0x53, 0x86, 0xF9, 0x5B, 0xDB, 0x38, 0x7B, 0xC3, 0x1E },
                new byte[] { 0x22, 0x33, 0x24, 0x28, 0x36, 0xC7, 0xB2, 0x3B, 0x8E, 0x77, 0xBA, 0xF5, 0x14, 0x9F, 0x08, 0x55 },
                new byte[] { 0x9B, 0x4C, 0xFE, 0x60, 0x5C, 0xDA, 0x18, 0x46, 0xCD, 0x7D, 0x21, 0xB0, 0x3F, 0x1B, 0x89, 0xFF },
                new byte[] { 0xEB, 0x84, 0x69, 0x3A, 0x9D, 0xD7, 0xD3, 0x70, 0x67, 0x40, 0xB5, 0xDE, 0x5D, 0x30, 0x91, 0xB1 },
                new byte[] { 0x78, 0x11, 0x01, 0xE5, 0x00, 0x68, 0x98, 0xA0, 0xC5, 0x02, 0xA6, 0x74, 0x2D, 0x0B, 0xA2, 0x76 },
                new byte[] { 0xB3, 0xBE, 0xCE, 0xBD, 0xAE, 0xE9, 0x8A, 0x31, 0x1C, 0xEC, 0xF1, 0x99, 0x94, 0xAA, 0xF6, 0x26 },
                new byte[] { 0x2F, 0xEF, 0xE8, 0x8C, 0x35, 0x03, 0xD4, 0x7F, 0xFB, 0x05, 0xC1, 0x5E, 0x90, 0x20, 0x3D, 0x82 },
                new byte[] { 0xF7, 0xEA, 0x0A, 0x0D, 0x7E, 0xF8, 0x50, 0x1A, 0xC4, 0x07, 0x57, 0xB8, 0x3C, 0x62, 0xE3, 0xC8 },
                new byte[] { 0xAC, 0x52, 0x64, 0x10, 0xD0, 0xD9, 0x13, 0x0C, 0x12, 0x29, 0x51, 0xB9, 0xCF, 0xD6, 0x73, 0x8D },
                new byte[] { 0x81, 0x54, 0xC0, 0xED, 0x4E, 0x44, 0xA7, 0x2A, 0x85, 0x25, 0xE6, 0xCA, 0x7C, 0x8B, 0x56, 0x80 }
            },
            new [] {
                new byte[] { 0xCE, 0xBB, 0xEB, 0x92, 0xEA, 0xCB, 0x13, 0xC1, 0xE9, 0x3A, 0xD6, 0xB2, 0xD2, 0x90, 0x17, 0xF8 },
                new byte[] { 0x42, 0x15, 0x56, 0xB4, 0x65, 0x1C, 0x88, 0x43, 0xC5, 0x5C, 0x36, 0xBA, 0xF5, 0x57, 0x67, 0x8D },
                new byte[] { 0x31, 0xF6, 0x64, 0x58, 0x9E, 0xF4, 0x22, 0xAA, 0x75, 0x0F, 0x02, 0xB1, 0xDF, 0x6D, 0x73, 0x4D },
                new byte[] { 0x7C, 0x26, 0x2E, 0xF7, 0x08, 0x5D, 0x44, 0x3E, 0x9F, 0x14, 0xC8, 0xAE, 0x54, 0x10, 0xD8, 0xBC },
                new byte[] { 0x1A, 0x6B, 0x69, 0xF3, 0xBD, 0x33, 0xAB, 0xFA, 0xD1, 0x9B, 0x68, 0x4E, 0x16, 0x95, 0x91, 0xEE },
                new byte[] { 0x4C, 0x63, 0x8E, 0x5B, 0xCC, 0x3C, 0x19, 0xA1, 0x81, 0x49, 0x7B, 0xD9, 0x6F, 0x37, 0x60, 0xCA },
                new byte[] { 0xE7, 0x2B, 0x48, 0xFD, 0x96, 0x45, 0xFC, 0x41, 0x12, 0x0D, 0x79, 0xE5, 0x89, 0x8C, 0xE3, 0x20 },
                new byte[] { 0x30, 0xDC, 0xB7, 0x6C, 0x4A, 0xB5, 0x3F, 0x97, 0xD4, 0x62, 0x2D, 0x06, 0xA4, 0xA5, 0x83, 0x5F },
                new byte[] { 0x2A, 0xDA, 0xC9, 0x00, 0x7E, 0xA2, 0x55, 0xBF, 0x11, 0xD5, 0x9C, 0xCF, 0x0E, 0x0A, 0x3D, 0x51 },
                new byte[] { 0x7D, 0x93, 0x1B, 0xFE, 0xC4, 0x47, 0x09, 0x86, 0x0B, 0x8F, 0x9D, 0x6A, 0x07, 0xB9, 0xB0, 0x98 },
                new byte[] { 0x18, 0x32, 0x71, 0x4B, 0xEF, 0x3B, 0x70, 0xA0, 0xE4, 0x40, 0xFF, 0xC3, 0xA9, 0xE6, 0x78, 0xF9 },
                new byte[] { 0x8B, 0x46, 0x80, 0x1E, 0x38, 0xE1, 0xB8, 0xA8, 0xE0, 0x0C, 0x23, 0x76, 0x1D, 0x25, 0x24, 0x05 },
                new byte[] { 0xF1, 0x6E, 0x94, 0x28, 0x9A, 0x84, 0xE8, 0xA3, 0x4F, 0x77, 0xD3, 0x85, 0xE2, 0x52, 0xF2, 0x82 },
                new byte[] { 0x50, 0x7A, 0x2F, 0x74, 0x53, 0xB3, 0x61, 0xAF, 0x39, 0x35, 0xDE, 0xCD, 0x1F, 0x99, 0xAC, 0xAD },
                new byte[] { 0x72, 0x2C, 0xDD, 0xD0, 0x87, 0xBE, 0x5E, 0xA6, 0xEC, 0x04, 0xC6, 0x03, 0x34, 0xFB, 0xDB, 0x59 },
                new byte[] { 0xB6, 0xC2, 0x01, 0xF0, 0x5A, 0xED, 0xA7, 0x66, 0x21, 0x7F, 0x8A, 0x27, 0xC7, 0xC0, 0x29, 0xD7 }
            },
            new [] {
                new byte[] { 0x93, 0xD9, 0x9A, 0xB5, 0x98, 0x22, 0x45, 0xFC, 0xBA, 0x6A, 0xDF, 0x02, 0x9F, 0xDC, 0x51, 0x59 },
                new byte[] { 0x4A, 0x17, 0x2B, 0xC2, 0x94, 0xF4, 0xBB, 0xA3, 0x62, 0xE4, 0x71, 0xD4, 0xCD, 0x70, 0x16, 0xE1 },
                new byte[] { 0x49, 0x3C, 0xC0, 0xD8, 0x5C, 0x9B, 0xAD, 0x85, 0x53, 0xA1, 0x7A, 0xC8, 0x2D, 0xE0, 0xD1, 0x72 },
                new byte[] { 0xA6, 0x2C, 0xC4, 0xE3, 0x76, 0x78, 0xB7, 0xB4, 0x09, 0x3B, 0x0E, 0x41, 0x4C, 0xDE, 0xB2, 0x90 },
                new byte[] { 0x25, 0xA5, 0xD7, 0x03, 0x11, 0x00, 0xC3, 0x2E, 0x92, 0xEF, 0x4E, 0x12, 0x9D, 0x7D, 0xCB, 0x35 },
                new byte[] { 0x10, 0xD5, 0x4F, 0x9E, 0x4D, 0xA9, 0x55, 0xC6, 0xD0, 0x7B, 0x18, 0x97, 0xD3, 0x36, 0xE6, 0x48 },
                new byte[] { 0x56, 0x81, 0x8F, 0x77, 0xCC, 0x9C, 0xB9, 0xE2, 0xAC, 0xB8, 0x2F, 0x15, 0xA4, 0x7C, 0xDA, 0x38 },
                new byte[] { 0x1E, 0x0B, 0x05, 0xD6, 0x14, 0x6E, 0x6C, 0x7E, 0x66, 0xFD, 0xB1, 0xE5, 0x60, 0xAF, 0x5E, 0x33 },
                new byte[] { 0x87, 0xC9, 0xF0, 0x5D, 0x6D, 0x3F, 0x88, 0x8D, 0xC7, 0xF7, 0x1D, 0xE9, 0xEC, 0xED, 0x80, 0x29 },
                new byte[] { 0x27, 0xCF, 0x99, 0xA8, 0x50, 0x0F, 0x37, 0x24, 0x28, 0x30, 0x95, 0xD2, 0x3E, 0x5B, 0x40, 0x83 },
                new byte[] { 0xB3, 0x69, 0x57, 0x1F, 0x07, 0x1C, 0x8A, 0xBC, 0x20, 0xEB, 0xCE, 0x8E, 0xAB, 0xEE, 0x31, 0xA2 },
                new byte[] { 0x73, 0xF9, 0xCA, 0x3A, 0x1A, 0xFB, 0x0D, 0xC1, 0xFE, 0xFA, 0xF2, 0x6F, 0xBD, 0x96, 0xDD, 0x43 },
                new byte[] { 0x52, 0xB6, 0x08, 0xF3, 0xAE, 0xBE, 0x19, 0x89, 0x32, 0x26, 0xB0, 0xEA, 0x4B, 0x64, 0x84, 0x82 },
                new byte[] { 0x6B, 0xF5, 0x79, 0xBF, 0x01, 0x5F, 0x75, 0x63, 0x1B, 0x23, 0x3D, 0x68, 0x2A, 0x65, 0xE8, 0x91 },
                new byte[] { 0xF6, 0xFF, 0x13, 0x58, 0xF1, 0x47, 0x0A, 0x7F, 0xC5, 0xA7, 0xE7, 0x61, 0x5A, 0x06, 0x46, 0x44 },
                new byte[] { 0x42, 0x04, 0xA0, 0xDB, 0x39, 0x86, 0x54, 0xAA, 0x8C, 0x34, 0x21, 0x8B, 0xF8, 0x0C, 0x74, 0x67 }
            },
            new [] {
                new byte[] {0x68, 0x8D, 0xCA, 0x4D, 0x73, 0x4B, 0x4E, 0x2A, 0xD4, 0x52, 0x26, 0xB3, 0x54, 0x1E, 0x19, 0x1F },
                new byte[] {0x22, 0x03, 0x46, 0x3D, 0x2D, 0x4A, 0x53, 0x83, 0x13, 0x8A, 0xB7, 0xD5, 0x25, 0x79, 0xF5, 0xBD },
                new byte[] {0x58, 0x2F, 0x0D, 0x02, 0xED, 0x51, 0x9E, 0x11, 0xF2, 0x3E, 0x55, 0x5E, 0xD1, 0x16, 0x3C, 0x66 },
                new byte[] {0x70, 0x5D, 0xF3, 0x45, 0x40, 0xCC, 0xE8, 0x94, 0x56, 0x08, 0xCE, 0x1A, 0x3A, 0xD2, 0xE1, 0xDF },
                new byte[] {0xB5, 0x38, 0x6E, 0x0E, 0xE5, 0xF4, 0xF9, 0x86, 0xE9, 0x4F, 0xD6, 0x85, 0x23, 0xCF, 0x32, 0x99 },
                new byte[] {0x31, 0x14, 0xAE, 0xEE, 0xC8, 0x48, 0xD3, 0x30, 0xA1, 0x92, 0x41, 0xB1, 0x18, 0xC4, 0x2C, 0x71 },
                new byte[] {0x72, 0x44, 0x15, 0xFD, 0x37, 0xBE, 0x5F, 0xAA, 0x9B, 0x88, 0xD8, 0xAB, 0x89, 0x9C, 0xFA, 0x60 },
                new byte[] {0xEA, 0xBC, 0x62, 0x0C, 0x24, 0xA6, 0xA8, 0xEC, 0x67, 0x20, 0xDB, 0x7C, 0x28, 0xDD, 0xAC, 0x5B },
                new byte[] {0x34, 0x7E, 0x10, 0xF1, 0x7B, 0x8F, 0x63, 0xA0, 0x05, 0x9A, 0x43, 0x77, 0x21, 0xBF, 0x27, 0x09 },
                new byte[] {0xC3, 0x9F, 0xB6, 0xD7, 0x29, 0xC2, 0xEB, 0xC0, 0xA4, 0x8B, 0x8C, 0x1D, 0xFB, 0xFF, 0xC1, 0xB2 },
                new byte[] {0x97, 0x2E, 0xF8, 0x65, 0xF6, 0x75, 0x07, 0x04, 0x49, 0x33, 0xE4, 0xD9, 0xB9, 0xD0, 0x42, 0xC7 },
                new byte[] {0x6C, 0x90, 0x00, 0x8E, 0x6F, 0x50, 0x01, 0xC5, 0xDA, 0x47, 0x3F, 0xCD, 0x69, 0xA2, 0xE2, 0x7A },
                new byte[] {0xA7, 0xC6, 0x93, 0x0F, 0x0A, 0x06, 0xE6, 0x2B, 0x96, 0xA3, 0x1C, 0xAF, 0x6A, 0x12, 0x84, 0x39 },
                new byte[] {0xE7, 0xB0, 0x82, 0xF7, 0xFE, 0x9D, 0x87, 0x5C, 0x81, 0x35, 0xDE, 0xB4, 0xA5, 0xFC, 0x80, 0xEF },
                new byte[] {0xCB, 0xBB, 0x6B, 0x76, 0xBA, 0x5A, 0x7D, 0x78, 0x0B, 0x95, 0xE3, 0xAD, 0x74, 0x98, 0x3B, 0x36 },
                new byte[] {0x64, 0x6D, 0xDC, 0xF0, 0x59, 0xA9, 0x4C, 0x17, 0x7F, 0x91, 0xB8, 0xC9, 0x57, 0x1B, 0xE0, 0x61 }
            }
        };

        public static readonly byte[][][] kalynaInverseSBoxes =
        {
            new[]
            {
                new byte[] {0xA4, 0xA2, 0xA9, 0xC5, 0x4E, 0xC9, 0x03, 0xD9, 0x7E, 0x0F, 0xD2, 0xAD, 0xE7, 0xD3, 0x27, 0x5B},
                new byte[] {0xE3, 0xA1, 0xE8, 0xE6, 0x7C, 0x2A, 0x55, 0x0C, 0x86, 0x39, 0xD7, 0x8D, 0xB8, 0x12, 0x6F, 0x28},
                new byte[] {0xCD, 0x8A, 0x70, 0x56, 0x72, 0xF9, 0xBF, 0x4F, 0x73, 0xE9, 0xF7, 0x57, 0x16, 0xAC, 0x50, 0xC0},
                new byte[] {0x9D, 0xB7, 0x47, 0x71, 0x60, 0xC4, 0x74, 0x43, 0x6C, 0x1F, 0x93, 0x77, 0xDC, 0xCE, 0x20, 0x8C},
                new byte[] {0x99, 0x5F, 0x44, 0x01, 0xF5, 0x1E, 0x87, 0x5E, 0x61, 0x2C, 0x4B, 0x1D, 0x81, 0x15, 0xF4, 0x23},
                new byte[] {0xD6, 0xEA, 0xE1, 0x67, 0xF1, 0x7F, 0xFE, 0xDA, 0x3C, 0x07, 0x53, 0x6A, 0x84, 0x9C, 0xCB, 0x02},
                new byte[] {0x83, 0x33, 0xDD, 0x35, 0xE2, 0x59, 0x5A, 0x98, 0xA5, 0x92, 0x64, 0x04, 0x06, 0x10, 0x4D, 0x1C},
                new byte[] {0x97, 0x08, 0x31, 0xEE, 0xAB, 0x05, 0xAF, 0x79, 0xA0, 0x18, 0x46, 0x6D, 0xFC, 0x89, 0xD4, 0xC7},
                new byte[] {0xFF, 0xF0, 0xCF, 0x42, 0x91, 0xF8, 0x68, 0x0A, 0x65, 0x8E, 0xB6, 0xFD, 0xC3, 0xEF, 0x78, 0x4C},
                new byte[] {0xCC, 0x9E, 0x30, 0x2E, 0xBC, 0x0B, 0x54, 0x1A, 0xA6, 0xBB, 0x26, 0x80, 0x48, 0x94, 0x32, 0x7D},
                new byte[] {0xA7, 0x3F, 0xAE, 0x22, 0x3D, 0x66, 0xAA, 0xF6, 0x00, 0x5D, 0xBD, 0x4A, 0xE0, 0x3B, 0xB4, 0x17},
                new byte[] {0x8B, 0x9F, 0x76, 0xB0, 0x24, 0x9A, 0x25, 0x63, 0xDB, 0xEB, 0x7A, 0x3E, 0x5C, 0xB3, 0xB1, 0x29},
                new byte[] {0xF2, 0xCA, 0x58, 0x6E, 0xD8, 0xA8, 0x2F, 0x75, 0xDF, 0x14, 0xFB, 0x13, 0x49, 0x88, 0xB2, 0xEC},
                new byte[] {0xE4, 0x34, 0x2D, 0x96, 0xC6, 0x3A, 0xED, 0x95, 0x0E, 0xE5, 0x85, 0x6B, 0x40, 0x21, 0x9B, 0x09},
                new byte[] {0x19, 0x2B, 0x52, 0xDE, 0x45, 0xA3, 0xFA, 0x51, 0xC2, 0xB5, 0xD1, 0x90, 0xB9, 0xF3, 0x37, 0xC1},
                new byte[] {0x0D, 0xBA, 0x41, 0x11, 0x38, 0x7B, 0xBE, 0xD0, 0xD5, 0x69, 0x36, 0xC8, 0x62, 0x1B, 0x82, 0x8F}
            },
            new[]
            {
                new byte[] {0x83, 0xF2, 0x2A, 0xEB, 0xE9, 0xBF, 0x7B, 0x9C, 0x34, 0x96, 0x8D, 0x98, 0xB9, 0x69, 0x8C, 0x29},
                new byte[] {0x3D, 0x88, 0x68, 0x06, 0x39, 0x11, 0x4C, 0x0E, 0xA0, 0x56, 0x40, 0x92, 0x15, 0xBC, 0xB3, 0xDC},
                new byte[] {0x6F, 0xF8, 0x26, 0xBA, 0xBE, 0xBD, 0x31, 0xFB, 0xC3, 0xFE, 0x80, 0x61, 0xE1, 0x7A, 0x32, 0xD2},
                new byte[] {0x70, 0x20, 0xA1, 0x45, 0xEC, 0xD9, 0x1A, 0x5D, 0xB4, 0xD8, 0x09, 0xA5, 0x55, 0x8E, 0x37, 0x76},
                new byte[] {0xA9, 0x67, 0x10, 0x17, 0x36, 0x65, 0xB1, 0x95, 0x62, 0x59, 0x74, 0xA3, 0x50, 0x2F, 0x4B, 0xC8},
                new byte[] {0xD0, 0x8F, 0xCD, 0xD4, 0x3C, 0x86, 0x12, 0x1D, 0x23, 0xEF, 0xF4, 0x53, 0x19, 0x35, 0xE6, 0x7F},
                new byte[] {0x5E, 0xD6, 0x79, 0x51, 0x22, 0x14, 0xF7, 0x1E, 0x4A, 0x42, 0x9B, 0x41, 0x73, 0x2D, 0xC1, 0x5C},
                new byte[] {0xA6, 0xA2, 0xE0, 0x2E, 0xD3, 0x28, 0xBB, 0xC9, 0xAE, 0x6A, 0xD1, 0x5A, 0x30, 0x90, 0x84, 0xF9},
                new byte[] {0xB2, 0x58, 0xCF, 0x7E, 0xC5, 0xCB, 0x97, 0xE4, 0x16, 0x6C, 0xFA, 0xB0, 0x6D, 0x1F, 0x52, 0x99},
                new byte[] {0x0D, 0x4E, 0x03, 0x91, 0xC2, 0x4D, 0x64, 0x77, 0x9F, 0xDD, 0xC4, 0x49, 0x8A, 0x9A, 0x24, 0x38},
                new byte[] {0xA7, 0x57, 0x85, 0xC7, 0x7C, 0x7D, 0xE7, 0xF6, 0xB7, 0xAC, 0x27, 0x46, 0xDE, 0xDF, 0x3B, 0xD7},
                new byte[] {0x9E, 0x2B, 0x0B, 0xD5, 0x13, 0x75, 0xF0, 0x72, 0xB6, 0x9D, 0x1B, 0x01, 0x3F, 0x44, 0xE5, 0x87},
                new byte[] {0xFD, 0x07, 0xF1, 0xAB, 0x94, 0x18, 0xEA, 0xFC, 0x3A, 0x82, 0x5F, 0x05, 0x54, 0xDB, 0x00, 0x8B},
                new byte[] {0xE3, 0x48, 0x0C, 0xCA, 0x78, 0x89, 0x0A, 0xFF, 0x3E, 0x5B, 0x81, 0xEE, 0x71, 0xE2, 0xDA, 0x2C},
                new byte[] {0xB8, 0xB5, 0xCC, 0x6E, 0xA8, 0x6B, 0xAD, 0x60, 0xC6, 0x08, 0x04, 0x02, 0xE8, 0xF5, 0x4F, 0xA4},
                new byte[] {0xF3, 0xC0, 0xCE, 0x43, 0x25, 0x1C, 0x21, 0x33, 0x0F, 0xAF, 0x47, 0xED, 0x66, 0x63, 0x93, 0xAA}
            },
            new[]
            {
                new byte[] {0x45, 0xD4, 0x0B, 0x43, 0xF1, 0x72, 0xED, 0xA4, 0xC2, 0x38, 0xE6, 0x71, 0xFD, 0xB6, 0x3A, 0x95},
                new byte[] {0x50, 0x44, 0x4B, 0xE2, 0x74, 0x6B, 0x1E, 0x11, 0x5A, 0xC6, 0xB4, 0xD8, 0xA5, 0x8A, 0x70, 0xA3},
                new byte[] {0xA8, 0xFA, 0x05, 0xD9, 0x97, 0x40, 0xC9, 0x90, 0x98, 0x8F, 0xDC, 0x12, 0x31, 0x2C, 0x47, 0x6A},
                new byte[] {0x99, 0xAE, 0xC8, 0x7F, 0xF9, 0x4F, 0x5D, 0x96, 0x6F, 0xF4, 0xB3, 0x39, 0x21, 0xDA, 0x9C, 0x85},
                new byte[] {0x9E, 0x3B, 0xF0, 0xBF, 0xEF, 0x06, 0xEE, 0xE5, 0x5F, 0x20, 0x10, 0xCC, 0x3C, 0x54, 0x4A, 0x52},
                new byte[] {0x94, 0x0E, 0xC0, 0x28, 0xF6, 0x56, 0x60, 0xA2, 0xE3, 0x0F, 0xEC, 0x9D, 0x24, 0x83, 0x7E, 0xD5},
                new byte[] {0x7C, 0xEB, 0x18, 0xD7, 0xCD, 0xDD, 0x78, 0xFF, 0xDB, 0xA1, 0x09, 0xD0, 0x76, 0x84, 0x75, 0xBB},
                new byte[] {0x1D, 0x1A, 0x2F, 0xB0, 0xFE, 0xD6, 0x34, 0x63, 0x35, 0xD2, 0x2A, 0x59, 0x6D, 0x4D, 0x77, 0xE7},
                new byte[] {0x8E, 0x61, 0xCF, 0x9F, 0xCE, 0x27, 0xF5, 0x80, 0x86, 0xC7, 0xA6, 0xFB, 0xF8, 0x87, 0xAB, 0x62},
                new byte[] {0x3F, 0xDF, 0x48, 0x00, 0x14, 0x9A, 0xBD, 0x5B, 0x04, 0x92, 0x02, 0x25, 0x65, 0x4C, 0x53, 0x0C},
                new byte[] {0xF2, 0x29, 0xAF, 0x17, 0x6C, 0x41, 0x30, 0xE9, 0x93, 0x55, 0xF7, 0xAC, 0x68, 0x26, 0xC4, 0x7D},
                new byte[] {0xCA, 0x7A, 0x3E, 0xA0, 0x37, 0x03, 0xC1, 0x36, 0x69, 0x66, 0x08, 0x16, 0xA7, 0xBC, 0xC5, 0xD3},
                new byte[] {0x22, 0xB7, 0x13, 0x46, 0x32, 0xE8, 0x57, 0x88, 0x2B, 0x81, 0xB2, 0x4E, 0x64, 0x1C, 0xAA, 0x91},
                new byte[] {0x58, 0x2E, 0x9B, 0x5C, 0x1B, 0x51, 0x73, 0x42, 0x23, 0x01, 0x6E, 0xF3, 0x0D, 0xBE, 0x3D, 0x0A},
                new byte[] {0x2D, 0x1F, 0x67, 0x33, 0x19, 0x7B, 0x5E, 0xEA, 0xDE, 0x8B, 0xCB, 0xA9, 0x8C, 0x8D, 0xAD, 0x49},
                new byte[] {0x82, 0xE4, 0xBA, 0xC3, 0x15, 0xD1, 0xE0, 0x89, 0xFC, 0xB1, 0xB9, 0xB5, 0x07, 0x79, 0xB8, 0xE1}
            },
            new[]
            {
                new byte[] {0xB2, 0xB6, 0x23, 0x11, 0xA7, 0x88, 0xC5, 0xA6, 0x39, 0x8F, 0xC4, 0xE8, 0x73, 0x22, 0x43, 0xC3},
                new byte[] {0x82, 0x27, 0xCD, 0x18, 0x51, 0x62, 0x2D, 0xF7, 0x5C, 0x0E, 0x3B, 0xFD, 0xCA, 0x9B, 0x0D, 0x0F},
                new byte[] {0x79, 0x8C, 0x10, 0x4C, 0x74, 0x1C, 0x0A, 0x8E, 0x7C, 0x94, 0x07, 0xC7, 0x5E, 0x14, 0xA1, 0x21},
                new byte[] {0x57, 0x50, 0x4E, 0xA9, 0x80, 0xD9, 0xEF, 0x64, 0x41, 0xCF, 0x3C, 0xEE, 0x2E, 0x13, 0x29, 0xBA},
                new byte[] {0x34, 0x5A, 0xAE, 0x8A, 0x61, 0x33, 0x12, 0xB9, 0x55, 0xA8, 0x15, 0x05, 0xF6, 0x03, 0x06, 0x49},
                new byte[] {0xB5, 0x25, 0x09, 0x16, 0x0C, 0x2A, 0x38, 0xFC, 0x20, 0xF4, 0xE5, 0x7F, 0xD7, 0x31, 0x2B, 0x66},
                new byte[] {0x6F, 0xFF, 0x72, 0x86, 0xF0, 0xA3, 0x2F, 0x78, 0x00, 0xBC, 0xCC, 0xE2, 0xB0, 0xF1, 0x42, 0xB4},
                new byte[] {0x30, 0x5F, 0x60, 0x04, 0xEC, 0xA5, 0xE3, 0x8B, 0xE7, 0x1D, 0xBF, 0x84, 0x7B, 0xE6, 0x81, 0xF8},
                new byte[] {0xDE, 0xD8, 0xD2, 0x17, 0xCE, 0x4B, 0x47, 0xD6, 0x69, 0x6C, 0x19, 0x99, 0x9A, 0x01, 0xB3, 0x85},
                new byte[] {0xB1, 0xF9, 0x59, 0xC2, 0x37, 0xE9, 0xC8, 0xA0, 0xED, 0x4F, 0x89, 0x68, 0x6D, 0xD5, 0x26, 0x91},
                new byte[] {0x87, 0x58, 0xBD, 0xC9, 0x98, 0xDC, 0x75, 0xC0, 0x76, 0xF5, 0x67, 0x6B, 0x7E, 0xEB, 0x52, 0xCB},
                new byte[] {0xD1, 0x5B, 0x9F, 0x0B, 0xDB, 0x40, 0x92, 0x1A, 0xFA, 0xAC, 0xE4, 0xE1, 0x71, 0x1F, 0x65, 0x8D},
                new byte[] {0x97, 0x9E, 0x95, 0x90, 0x5D, 0xB7, 0xC1, 0xAF, 0x54, 0xFB, 0x02, 0xE0, 0x35, 0xBB, 0x3A, 0x4D},
                new byte[] {0xAD, 0x2C, 0x3D, 0x56, 0x08, 0x1B, 0x4A, 0x93, 0x6A, 0xAB, 0xB8, 0x7A, 0xF2, 0x7D, 0xDA, 0x3F},
                new byte[] {0xFE, 0x3E, 0xBE, 0xEA, 0xAA, 0x44, 0xC6, 0xD0, 0x36, 0x48, 0x70, 0x96, 0x77, 0x24, 0x53, 0xDF},
                new byte[] {0xF3, 0x83, 0x28, 0x32, 0x45, 0x1E, 0xA4, 0xD3, 0xA2, 0x46, 0x6E, 0x9C, 0xDD, 0x63, 0xD4, 0x9D}
            }
        };

        public static readonly byte[][] Mds = {
            new byte[]{ 0x01, 0x01, 0x05, 0x01, 0x08, 0x06, 0x07, 0x04 },
            new byte[]{ 0x04, 0x01, 0x01, 0x05, 0x01, 0x08, 0x06, 0x07 },
            new byte[]{ 0x07, 0x04, 0x01, 0x01, 0x05, 0x01, 0x08, 0x06 },
            new byte[]{ 0x06, 0x07, 0x04, 0x01, 0x01, 0x05, 0x01, 0x08 },
            new byte[]{ 0x08, 0x06, 0x07, 0x04, 0x01, 0x01, 0x05, 0x01 },
            new byte[]{ 0x01, 0x08, 0x06, 0x07, 0x04, 0x01, 0x01, 0x05 },
            new byte[]{ 0x05, 0x01, 0x08, 0x06, 0x07, 0x04, 0x01, 0x01 },
            new byte[]{ 0x01, 0x05, 0x01, 0x08, 0x06, 0x07, 0x04, 0x01 }
        };


        public static readonly byte[][] MdsRev = {
            new byte[]{ 0xAD, 0x95, 0x76, 0xA8, 0x2F, 0x49, 0xD7, 0xCA },
            new byte[]{ 0xCA, 0xAD, 0x95, 0x76, 0xA8, 0x2F, 0x49, 0xD7 },
            new byte[]{ 0xD7, 0xCA, 0xAD, 0x95, 0x76, 0xA8, 0x2F, 0x49 },
            new byte[]{ 0x49, 0xD7, 0xCA, 0xAD, 0x95, 0x76, 0xA8, 0x2F },
            new byte[]{ 0x2F, 0x49, 0xD7, 0xCA, 0xAD, 0x95, 0x76, 0xA8 },
            new byte[]{ 0xA8, 0x2F, 0x49, 0xD7, 0xCA, 0xAD, 0x95, 0x76 },
            new byte[]{ 0x76, 0xA8, 0x2F, 0x49, 0xD7, 0xCA, 0xAD, 0x95 },
            new byte[]{ 0x95, 0x76, 0xA8, 0x2F, 0x49, 0xD7, 0xCA, 0xAD }
        };
    }
}
