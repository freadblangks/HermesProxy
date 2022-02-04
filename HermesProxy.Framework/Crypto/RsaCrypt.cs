﻿using System.Security.Cryptography;

namespace HermesProxy.Framework.Crypto;

public class RsaCrypt
{
    public static RSACryptoServiceProvider RSA;

    static RsaCrypt()
    {
        RSA = new RSACryptoServiceProvider(2048);
        RSA.ImportParameters(RsaStore.RSAParameters);
    }
}

public class RsaStore
{
    public static RSAParameters RSAParameters = new()
    {
        Modulus = new byte[] { 0xee, 0xb3, 0xdc, 0xd4, 0xd3, 0xc3, 0xb4, 0x54, 0x51, 0xce, 0x66, 0x5b, 0xcb, 0x32, 0xb8, 0xf0, 0xf7, 0x92, 0x53, 0xc6, 0x19, 0xf2, 0x0c, 0x85, 0x2f, 0x8a, 0x26, 0xa9, 0x7a, 0x45, 0x9f, 0x60, 0xc4, 0xeb, 0xcd, 0xea, 0x7f, 0x8d, 0x59, 0xd8, 0x57, 0xb2, 0x60, 0x7b, 0x09, 0x4c, 0x9b, 0x68, 0xb8, 0xc7, 0xed, 0xef, 0x1e, 0x80, 0x0d, 0xe6, 0x6b, 0x37, 0x5b, 0x53, 0x90, 0xeb, 0x18, 0x13, 0x0d, 0x7f, 0x43, 0x64, 0x83, 0xda, 0x98, 0xe6, 0xac, 0xc2, 0x30, 0xa2, 0x82, 0xa5, 0xc6, 0xcb, 0xc7, 0xfb, 0x86, 0x9f, 0x9f, 0xa9, 0x02, 0x6a, 0x03, 0x49, 0xc5, 0x38, 0xfb, 0xc0, 0xc8, 0x55, 0xcc, 0xc0, 0xce, 0x25, 0x91, 0xbe, 0x85, 0xcf, 0xd1, 0xd1, 0x37, 0xce, 0xcc, 0x83, 0xd2, 0xea, 0x30, 0x80, 0x07, 0x7b, 0x80, 0x9f, 0x9d, 0x44, 0x54, 0x22, 0x29, 0xbe, 0x86, 0xda, 0xdb, 0x48, 0xc5, 0xa9, 0xf9, 0x13, 0x36, 0x95, 0x23, 0x76, 0xf1, 0x0e, 0xdc, 0x84, 0x0d, 0x94, 0x02, 0x12, 0xa8, 0x97, 0xf3, 0x3b, 0x14, 0xee, 0xaa, 0x6f, 0x98, 0x05, 0x27, 0x4e, 0x1f, 0xa3, 0x60, 0xa5, 0xa9, 0xda, 0xd8, 0x17, 0xdf, 0x33, 0xcb, 0xe2, 0x13, 0x54, 0x8b, 0x18, 0xb0, 0xca, 0xb9, 0xbb, 0x88, 0x64, 0x06, 0xdf, 0x75, 0xa6, 0xd7, 0x61, 0x00, 0xbb, 0xb0, 0x5a, 0x0e, 0x7a, 0xd4, 0x77, 0x08, 0x4d, 0x15, 0xe2, 0x10, 0x83, 0xb0, 0x04, 0xaa, 0x9e, 0x8b, 0x77, 0xa9, 0x06, 0x89, 0x5d, 0x08, 0x5d, 0x0f, 0xb8, 0x2e, 0x6b, 0xc1, 0xcb, 0x64, 0xcf, 0x6e, 0x5c, 0xdb, 0x4f, 0x58, 0x65, 0x08, 0x51, 0xfb, 0x0d, 0x48, 0x1a, 0x6f, 0xb6, 0x3d, 0x1f, 0x0b, 0xdd, 0xfe, 0x1b, 0x1d, 0xf0, 0xbf, 0xb0, 0x27, 0x6b, 0xf5, 0x8e, 0xbc, 0xc7, 0x40, 0x01, 0xff, 0xa7, 0x0b, 0x80, 0xd6, 0x5f },
        Exponent = new byte[] { 0x01, 0x00, 0x01 },
        P = new byte[] { 0xf3, 0xb3, 0x59, 0x68, 0x6f, 0x5a, 0xf3, 0xf3, 0x28, 0x6f, 0xa1, 0xa0, 0x63, 0x80, 0x55, 0x2c, 0x72, 0x55, 0x39, 0x2c, 0xf3, 0x15, 0xd3, 0x72, 0x30, 0x0f, 0xb8, 0x2d, 0xf4, 0x9b, 0xb7, 0x38, 0x0e, 0x37, 0x64, 0x52, 0x67, 0x27, 0x83, 0xd0, 0x9a, 0x43, 0xa3, 0x0c, 0x17, 0xb2, 0xcc, 0x39, 0x5c, 0xec, 0x94, 0x51, 0xcb, 0x63, 0xd9, 0xc2, 0xcb, 0x76, 0x53, 0x02, 0xa4, 0x37, 0xdd, 0xce, 0x4e, 0x05, 0xfc, 0xf1, 0x1a, 0x92, 0x5a, 0x03, 0x25, 0x6a, 0x5a, 0xb2, 0x89, 0xf7, 0x96, 0x6b, 0xab, 0xd3, 0xfe, 0x4e, 0xab, 0x74, 0xfd, 0xdf, 0xe7, 0xe7, 0x35, 0x49, 0x78, 0x77, 0x75, 0x0e, 0xb3, 0x58, 0xdc, 0x27, 0x5c, 0x86, 0x43, 0xf0, 0x5f, 0xad, 0x3c, 0x91, 0x4d, 0xc1, 0x28, 0x67, 0x1f, 0x0c, 0xbb, 0xd9, 0x89, 0xe2, 0x2b, 0x6e, 0x56, 0x42, 0xae, 0x2d, 0xe1, 0xb9, 0xbd, 0x7d },
        Q = new byte[] { 0xfa, 0xbf, 0xf0, 0x40, 0x12, 0x52, 0xea, 0x40, 0xf2, 0x40, 0xf8, 0xf5, 0x93, 0xf4, 0x8c, 0x0a, 0x55, 0x21, 0x5a, 0x1c, 0x80, 0x0f, 0x00, 0xe8, 0x77, 0x4d, 0xe1, 0x1d, 0x34, 0x07, 0x73, 0xd0, 0x65, 0x78, 0x9c, 0xa3, 0x5e, 0x65, 0x72, 0xfb, 0xfa, 0x56, 0x84, 0xde, 0xda, 0x10, 0xb8, 0x63, 0x80, 0xb6, 0xdf, 0xa3, 0xf1, 0xa6, 0xdd, 0xa2, 0x89, 0x8c, 0x2c, 0x52, 0xe2, 0xa0, 0x66, 0xa9, 0x42, 0xb0, 0x02, 0xf1, 0xa8, 0x49, 0x5b, 0xb1, 0xd4, 0x1a, 0x36, 0x66, 0x37, 0x1f, 0x17, 0xbb, 0x17, 0xf4, 0x15, 0xc1, 0x3a, 0x51, 0x53, 0x1b, 0xe6, 0xcf, 0x54, 0x26, 0x54, 0xa1, 0xa9, 0x2c, 0x4f, 0x25, 0xcd, 0x83, 0xb1, 0xac, 0x03, 0x57, 0xeb, 0x2a, 0x45, 0x96, 0x92, 0x04, 0x2e, 0x39, 0xe2, 0xb7, 0xa3, 0xfa, 0x7d, 0x21, 0x9a, 0x01, 0x97, 0xdd, 0xef, 0x12, 0x07, 0x13, 0x1a, 0x0b },
        DP = new byte[] { 0xbf, 0x9b, 0x9c, 0x08, 0x88, 0xc5, 0x32, 0x59, 0x54, 0xc9, 0xb0, 0x82, 0xb2, 0xb9, 0x0c, 0x3e, 0xce, 0x06, 0x43, 0xd6, 0x1b, 0xaa, 0x65, 0x7d, 0xba, 0x5c, 0x21, 0xab, 0xc0, 0x4f, 0x4e, 0x57, 0x3c, 0x96, 0x40, 0xc2, 0xa9, 0x68, 0x60, 0x33, 0x7b, 0x97, 0x02, 0x73, 0x57, 0x8e, 0xb5, 0x13, 0xc5, 0x04, 0x1d, 0xf9, 0xd1, 0xb8, 0xc8, 0x56, 0x68, 0x32, 0xb8, 0x41, 0xb3, 0x6c, 0x59, 0x71, 0x03, 0xd7, 0xa1, 0x70, 0xd0, 0x3b, 0x91, 0x9a, 0x37, 0xa8, 0xcf, 0x76, 0xe1, 0x13, 0x51, 0xa9, 0x86, 0x88, 0x3f, 0xc3, 0x0a, 0xfc, 0x09, 0x40, 0x2a, 0xcd, 0x97, 0x10, 0x15, 0x2f, 0x97, 0x51, 0xdf, 0xa1, 0x56, 0x37, 0x7c, 0x7f, 0xf4, 0x9a, 0xe2, 0x1f, 0x0b, 0x28, 0x13, 0xc2, 0x73, 0x49, 0xe1, 0x17, 0xd9, 0xfa, 0xc8, 0x76, 0x93, 0x3f, 0x45, 0x83, 0x57, 0xff, 0xab, 0x22, 0xa6, 0xe1 },
        DQ = new byte[] { 0xfa, 0xbc, 0x05, 0x44, 0x3c, 0x4e, 0x76, 0xf9, 0xbc, 0x84, 0x65, 0xae, 0x43, 0x65, 0x8c, 0xc7, 0x24, 0x3b, 0x36, 0x7d, 0x3b, 0x3c, 0x45, 0x7f, 0x2f, 0x15, 0x4c, 0x1e, 0x44, 0x91, 0x93, 0x28, 0x76, 0xde, 0xf5, 0x5a, 0x93, 0x20, 0xc4, 0xaa, 0xdc, 0xb7, 0xb9, 0x23, 0x92, 0x50, 0x97, 0xe0, 0xbf, 0xab, 0x9d, 0xd3, 0xb4, 0xe7, 0x53, 0xc6, 0x9c, 0xdd, 0xf2, 0xd0, 0x6a, 0xd7, 0x53, 0xf0, 0xba, 0xc3, 0x80, 0x1e, 0x1f, 0x56, 0x43, 0x7f, 0x7d, 0x85, 0x3c, 0x92, 0x57, 0x5a, 0x1b, 0x03, 0xb5, 0xbf, 0x18, 0x25, 0xe0, 0xe7, 0xc3, 0x40, 0x2a, 0x3b, 0x75, 0x7c, 0xe2, 0xb1, 0xc8, 0x95, 0x8b, 0x0b, 0x55, 0x06, 0xf4, 0x19, 0xfa, 0x39, 0xe6, 0xe8, 0x9d, 0x2f, 0x24, 0x11, 0x54, 0x1c, 0x03, 0xed, 0xf7, 0xe5, 0x99, 0x4c, 0x89, 0x50, 0x40, 0x88, 0xe6, 0xef, 0x52, 0xed, 0xb1, 0xe3 },
        InverseQ = new byte[] { 0x52, 0x02, 0x1b, 0x3a, 0x96, 0xc8, 0x6d, 0xcf, 0xeb, 0xa3, 0x47, 0x77, 0xe6, 0x73, 0x84, 0x2a, 0x25, 0x51, 0xaa, 0x79, 0x7b, 0xc4, 0x04, 0xf0, 0x15, 0x9b, 0xac, 0x98, 0xa0, 0xa6, 0x11, 0x2f, 0x05, 0x6c, 0xfe, 0xb1, 0x6f, 0xdd, 0x62, 0xcd, 0x2c, 0xec, 0x30, 0x05, 0x0e, 0xa5, 0xcf, 0xb3, 0xfd, 0x46, 0xa6, 0x18, 0x07, 0x9c, 0x15, 0x95, 0xa4, 0x6f, 0x12, 0x16, 0xfd, 0xfa, 0x50, 0xaf, 0x7b, 0xfc, 0x55, 0x73, 0x13, 0x1e, 0x67, 0x91, 0xa4, 0x38, 0x13, 0xf1, 0x57, 0x28, 0x18, 0x57, 0xd9, 0x7f, 0xc0, 0xd7, 0x44, 0xdb, 0x93, 0x73, 0x38, 0x76, 0x2d, 0x28, 0x6d, 0xc6, 0x2b, 0x71, 0x84, 0x70, 0x50, 0xf0, 0x65, 0x4d, 0x8b, 0x3c, 0x7a, 0xb6, 0xd4, 0x4a, 0xe8, 0x50, 0x07, 0x6d, 0x45, 0xf6, 0xeb, 0x27, 0x82, 0x96, 0xdb, 0x27, 0x3c, 0x8a, 0x0b, 0x57, 0x2b, 0x14, 0xc1, 0x63 },
        D = new byte[] { 0x22, 0x9a, 0xe6, 0xaf, 0xe0, 0x07, 0x66, 0x34, 0x37, 0x2b, 0xe2, 0x00, 0xfa, 0xc3, 0x5e, 0xb6, 0x68, 0x5d, 0xc9, 0x51, 0x55, 0xdf, 0x96, 0x5b, 0x14, 0x9a, 0x45, 0xa2, 0x9a, 0x3c, 0x4f, 0xaf, 0xba, 0xbc, 0xa8, 0xbc, 0x8f, 0x43, 0x51, 0xbc, 0x20, 0x72, 0x96, 0xb4, 0x1f, 0x94, 0x00, 0x8f, 0xbd, 0x02, 0x17, 0x07, 0x6c, 0x77, 0x8a, 0x0c, 0x56, 0x8c, 0xce, 0xeb, 0x9d, 0x7d, 0xc7, 0x9e, 0xb3, 0x7d, 0x38, 0xaa, 0xf0, 0xc6, 0x97, 0x16, 0x12, 0x03, 0x91, 0x03, 0x6e, 0x47, 0x54, 0x3b, 0xa4, 0xc1, 0x5d, 0x31, 0xf4, 0xf6, 0x8e, 0x88, 0x09, 0xf3, 0xfe, 0xe8, 0x94, 0xee, 0xcc, 0xdc, 0x4b, 0x73, 0xc4, 0x2f, 0x04, 0x23, 0x07, 0xc9, 0x2a, 0x14, 0xd7, 0xaf, 0x5e, 0x4c, 0xda, 0x1d, 0xe3, 0x6c, 0x1c, 0x29, 0x96, 0x6b, 0x0d, 0x64, 0xa3, 0x81, 0xd4, 0x65, 0x6f, 0xad, 0x78, 0xce, 0x9b, 0x52, 0xad, 0x39, 0x9e, 0x02, 0x4d, 0x33, 0x34, 0x5a, 0xb3, 0xda, 0x2d, 0x50, 0xd3, 0xf5, 0xac, 0x7c, 0xa7, 0x29, 0x23, 0x98, 0x5c, 0x35, 0xea, 0xf1, 0x8f, 0x8f, 0xf4, 0x79, 0x0e, 0x4c, 0xbd, 0x56, 0x96, 0x9b, 0xb5, 0xf6, 0x4e, 0xbb, 0xf0, 0x04, 0x5b, 0x6e, 0x7d, 0x5c, 0x31, 0x22, 0x42, 0x04, 0xeb, 0x07, 0x81, 0x20, 0xf9, 0x2e, 0x06, 0x26, 0x31, 0xea, 0x03, 0x33, 0xd9, 0x06, 0x63, 0x32, 0xff, 0x18, 0x65, 0x0c, 0xae, 0x28, 0x31, 0x77, 0x9f, 0xa9, 0x74, 0x9c, 0x7c, 0x3e, 0x30, 0xd1, 0x1c, 0x6e, 0xb8, 0x21, 0x6b, 0xea, 0x5c, 0x4b, 0x3d, 0x9c, 0xf4, 0x4b, 0x7e, 0x41, 0x2b, 0x59, 0x08, 0x5a, 0x62, 0x24, 0xba, 0xff, 0xbd, 0x79, 0x0b, 0x88, 0xe0, 0x7a, 0xf5, 0x0b, 0x25, 0x70, 0x72, 0x1e, 0x1f, 0x91, 0xfb, 0xeb, 0xa7, 0xce, 0x31, 0xf2, 0xdb, 0xc0, 0x16, 0x79 },
    };
}
