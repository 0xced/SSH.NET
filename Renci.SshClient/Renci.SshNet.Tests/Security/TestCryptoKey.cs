﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renci.SshNet.Security;

namespace Renci.SshNet.Tests.Security
{
    [TestClass]
    public class TestCryptoKey
    {
        [TestMethod]
        public void Test_Crypto_PrivateKey_RSA()
        {

            var key = new byte[] { 0x30, 0x82, 0x04, 0xa1, 0x02, 0x01, 0x00, 0x02, 0x82, 0x01, 0x01, 0x00, 0xb8, 0x3e, 0x52, 0x29, 0x23, 0x37, 0x44, 0x03, 0xbf, 0x87, 0xcc, 0xfd, 0xc7, 0x54, 0x41, 0xf5, 0xb8, 0x4b, 0x6c, 0x19, 0x28, 0xa6, 0x1a, 0xd8, 0x54, 0x76, 0x06, 0xf0, 0xc7, 0x4d, 0xc1, 0x07, 0x3f, 0x89, 0x76, 0xf8, 0x21, 0x9e, 0xcf, 0x94, 0xa4, 0x76, 0x65, 0x0a, 0x2f, 0x21, 0x8c, 0xc7, 0x74, 0xc2, 0x39, 0xcc, 0x61, 0x2e, 0x3a, 0xcc, 0x49, 0x9c, 0xb8, 0xf1, 0xa1, 0x5e, 0xcd, 0x49, 0x41, 0xe5, 0x1c, 0x4a, 0x06, 0x6d, 0x16, 0x17, 0xef, 0x6a, 0xd1, 0xdd, 0x2d, 0xd9, 0x39, 0x15, 0x00, 0xac, 0xb4, 0xc9, 0xf5, 0x3c, 0x06, 0x66, 0x14, 0x78, 0x4d, 0x94, 0x73, 0xb4, 0x9b, 0x68, 0xee, 0x5e, 0x0c, 0xe4, 0xb1, 0x83, 0x53, 0x2e, 0x18, 0x30, 0xd3, 0x7d, 0x92, 0x97, 0x32, 0x4f, 0xf6, 0xaa, 0xbf, 0xcb, 0xf7, 0x65, 0xc4, 0xc1, 0xd1, 0x4b, 0x61, 0x64, 0x35, 0xd4, 0x1e, 0xba, 0xe6, 0xae, 0x59, 0x2d, 0x3c, 0x00, 0xbe, 0x25, 0xa8, 0x14, 0x8e, 0x11, 0x12, 0x6e, 0xda, 0xbe, 0x14, 0x0b, 0xa2, 0x49, 0x45, 0x9d, 0xf7, 0xf4, 0x97, 0x9c, 0x09, 0x8b, 0xc9, 0xae, 0xcb, 0x91, 0x60, 0x0d, 0xc3, 0x64, 0x9c, 0x32, 0x97, 0x92, 0xc9, 0x79, 0x84, 0xbc, 0xb0, 0xfe, 0x5f, 0x47, 0x9a, 0xa4, 0xdb, 0x6e, 0xc1, 0x79, 0x6d, 0x8d, 0x15, 0xb8, 0x3e, 0x82, 0x92, 0xe5, 0xf5, 0x8c, 0x86, 0x25, 0xe7, 0x4f, 0xad, 0x4d, 0x5e, 0x68, 0x17, 0x0d, 0xc7, 0x2b, 0x50, 0x78, 0xd6, 0xac, 0xe6, 0xb5, 0xa1, 0xe3, 0x63, 0x9a, 0x13, 0xae, 0x20, 0x66, 0x83, 0xa6, 0x84, 0x6d, 0x90, 0x11, 0xfc, 0x94, 0x21, 0x50, 0x75, 0x17, 0x8f, 0x82, 0xf7, 0x01, 0x21, 0x19, 0xd4, 0xf4, 0x3e, 0xec, 0x8e, 0xe0, 0x63, 0x65, 0x40, 0x0f, 0xaa, 0x29, 0xfe, 0x7c, 0x39, 0x65, 0xd8, 0x84, 0xb2, 0xdb, 0x02, 0x01, 0x23, 0x02, 0x82, 0x01, 0x01, 0x00, 0x8e, 0x21, 0x72, 0x94, 0xc3, 0x65, 0x25, 0xd7, 0x01, 0x77, 0x63, 0x9f, 0x33, 0x5e, 0x41, 0x83, 0x0a, 0x83, 0x53, 0x63, 0xdd, 0x87, 0x73, 0xcb, 0x74, 0x5b, 0x0c, 0xab, 0x1d, 0x67, 0xde, 0x0c, 0xe7, 0xdf, 0x12, 0xa2, 0x28, 0x90, 0x74, 0x3f, 0x77, 0x8e, 0x88, 0x75, 0x92, 0x12, 0x91, 0x2c, 0x26, 0xde, 0xf9, 0x63, 0x26, 0x65, 0x7d, 0xd0, 0xcb, 0x12, 0x80, 0x0a, 0xdb, 0x92, 0x46, 0x97, 0x99, 0x3b, 0xb6, 0xbc, 0xc3, 0x20, 0xf3, 0xc9, 0x52, 0x4b, 0x16, 0xec, 0x73, 0xd3, 0x75, 0x2d, 0x75, 0x8c, 0x8b, 0x77, 0x39, 0x86, 0x13, 0x90, 0x93, 0x72, 0xbf, 0x81, 0x26, 0x0e, 0xfb, 0x8b, 0x76, 0x0e, 0x09, 0xf2, 0x3f, 0xcb, 0xb5, 0x32, 0x2f, 0xeb, 0x26, 0xce, 0x95, 0xa7, 0xd6, 0x5a, 0xf1, 0x7c, 0x68, 0x12, 0x5f, 0xc3, 0x89, 0x27, 0xcd, 0x57, 0x68, 0x63, 0x3f, 0x77, 0xbf, 0xed, 0xf5, 0x06, 0xde, 0xdd, 0x3e, 0x16, 0x1e, 0xa9, 0x4f, 0x95, 0xbb, 0xbd, 0xa0, 0xd2, 0xd6, 0xb3, 0x43, 0x83, 0x0e, 0xba, 0x8c, 0xea, 0x7d, 0xbc, 0xdb, 0xa5, 0x41, 0xbe, 0x84, 0x8a, 0x28, 0x37, 0x54, 0xa4, 0x90, 0x6e, 0x83, 0x0a, 0x01, 0x7f, 0x93, 0xe2, 0xb1, 0xd7, 0xac, 0x3a, 0x35, 0xd8, 0x35, 0x8b, 0xe5, 0x0e, 0xb0, 0x9a, 0x20, 0x12, 0xc8, 0xf6, 0xa8, 0x09, 0x9b, 0x5c, 0x3f, 0xca, 0x88, 0x57, 0x49, 0xc8, 0x15, 0xa5, 0x08, 0x13, 0xbe, 0x43, 0x9e, 0xf6, 0xfe, 0xb4, 0x81, 0x1b, 0xc2, 0x93, 0x7c, 0x01, 0x8d, 0x8c, 0x74, 0x2b, 0xbc, 0xb5, 0xe4, 0xbf, 0xb9, 0xe4, 0xed, 0x40, 0xe5, 0x3b, 0x7f, 0x47, 0x07, 0xfb, 0xcd, 0x2d, 0x19, 0x9d, 0x93, 0x75, 0xd0, 0x88, 0x8e, 0x82, 0x46, 0xc1, 0xe7, 0xcb, 0xf7, 0xcb, 0x9b, 0xef, 0xe6, 0x3a, 0x18, 0x0f, 0x62, 0xa8, 0xea, 0xcb, 0x02, 0x81, 0x81, 0x00, 0xdf, 0x80, 0xb4, 0xd3, 0x72, 0x0f, 0x83, 0x53, 0xf4, 0x37, 0x73, 0x95, 0x5b, 0xf8, 0x9e, 0x88, 0x76, 0x22, 0x0e, 0x22, 0x63, 0xef, 0x86, 0x34, 0xc2, 0x64, 0x90, 0xc9, 0xad, 0x80, 0x0f, 0x4d, 0xaa, 0x76, 0x10, 0x6a, 0xf7, 0x50, 0x8c, 0xc8, 0xad, 0x6d, 0x29, 0x77, 0x50, 0xdc, 0x07, 0x1c, 0xf1, 0x52, 0x05, 0xc4, 0x2f, 0x18, 0x91, 0xeb, 0xbd, 0x65, 0x7b, 0x6b, 0xd0, 0x68, 0x41, 0xc9, 0xa8, 0x17, 0x97, 0x6e, 0xb7, 0x53, 0x46, 0xa9, 0xc3, 0xc0, 0xde, 0x5e, 0x69, 0x0b, 0x6b, 0x43, 0x64, 0xd0, 0x66, 0xcd, 0x0f, 0x24, 0x42, 0xa9, 0x66, 0xa6, 0x9b, 0xd1, 0x7a, 0x32, 0xd6, 0xbe, 0xe7, 0x63, 0x15, 0x72, 0x7d, 0xc7, 0xd6, 0xfd, 0x3a, 0x5f, 0x5a, 0x55, 0x95, 0x7e, 0x6e, 0x64, 0x74, 0xeb, 0xc5, 0xdc, 0x1e, 0x72, 0xa7, 0xd0, 0xdc, 0x94, 0xf5, 0xe6, 0x1f, 0xa0, 0x98, 0x7b, 0x02, 0x81, 0x81, 0x00, 0xd3, 0x08, 0x4a, 0x90, 0x53, 0x88, 0xb4, 0x42, 0x13, 0xcf, 0x27, 0x1d, 0x9a, 0x22, 0x8e, 0x30, 0xcb, 0x23, 0x3e, 0xb0, 0x50, 0xf0, 0x40, 0x88, 0xa5, 0x87, 0x2d, 0x04, 0x08, 0x13, 0x58, 0xb9, 0x9d, 0x34, 0x27, 0x28, 0x04, 0x7f, 0xbc, 0xfe, 0xce, 0x1f, 0x61, 0xc5, 0x80, 0xe0, 0x5e, 0x38, 0x50, 0xf2, 0xd2, 0xaa, 0x7e, 0x0a, 0xd7, 0xfa, 0xc5, 0x97, 0xc3, 0x56, 0x28, 0x81, 0x61, 0x11, 0xa8, 0x93, 0xad, 0xdd, 0x97, 0x8c, 0x75, 0x91, 0xc4, 0xf5, 0x40, 0xa9, 0x2b, 0x79, 0xf3, 0x74, 0xed, 0xf6, 0xa3, 0xd1, 0xf2, 0x4d, 0xf8, 0x0e, 0x66, 0x4f, 0x60, 0x7d, 0xb0, 0xf5, 0x85, 0xc6, 0x11, 0xf6, 0xe2, 0x23, 0x12, 0xe3, 0x62, 0xb3, 0x91, 0xf1, 0xf4, 0xa6, 0xc8, 0xd7, 0xc2, 0x76, 0xed, 0xa3, 0xec, 0x51, 0x52, 0x2c, 0xc6, 0x6e, 0x00, 0xf1, 0x4a, 0x3c, 0x5e, 0xec, 0xb1, 0x21, 0x02, 0x81, 0x80, 0x6c, 0x8e, 0xf8, 0xbe, 0x79, 0x3a, 0xbc, 0x21, 0x76, 0x9e, 0x97, 0x39, 0xea, 0xd7, 0xd7, 0xf9, 0x23, 0x6f, 0xa0, 0x77, 0x1a, 0x98, 0xe9, 0x6a, 0x15, 0x46, 0xc9, 0xfb, 0x8e, 0xc9, 0x2c, 0x01, 0x26, 0xe8, 0xe3, 0x67, 0x27, 0xaa, 0xc8, 0x09, 0xb3, 0x52, 0x47, 0x57, 0x35, 0xe7, 0x36, 0xa7, 0xa8, 0x69, 0xab, 0x07, 0x84, 0x96, 0xe7, 0xca, 0x46, 0x0c, 0xb8, 0x4a, 0x4f, 0x48, 0x94, 0xfb, 0x8c, 0x28, 0xb7, 0x44, 0x67, 0xac, 0x1b, 0x01, 0xff, 0xfe, 0x97, 0xe4, 0xb6, 0xad, 0xc6, 0x62, 0x90, 0x0d, 0x73, 0xc2, 0xaf, 0x95, 0x44, 0xf3, 0x31, 0xdb, 0xe5, 0x48, 0x7d, 0x2e, 0xa2, 0xd1, 0xc0, 0xd8, 0x5a, 0xdf, 0xd6, 0xb1, 0x85, 0xae, 0x32, 0x4b, 0x92, 0x46, 0xd3, 0x95, 0x2e, 0x4e, 0x0c, 0xe7, 0x8b, 0xfd, 0x33, 0x5c, 0x42, 0xe1, 0xca, 0x39, 0xb9, 0x43, 0xe3, 0x79, 0xe3, 0xa9, 0x02, 0x81, 0x80, 0x72, 0x8f, 0x78, 0xef, 0x43, 0x4a, 0x35, 0xf7, 0xfc, 0x1f, 0xff, 0x4a, 0x95, 0x80, 0x79, 0x13, 0x2c, 0x72, 0x37, 0xf9, 0x50, 0x82, 0x6c, 0x2c, 0xec, 0x24, 0xcf, 0x4b, 0x54, 0xd7, 0x4d, 0x6c, 0x13, 0x82, 0xb6, 0x2b, 0xaa, 0xab, 0xbe, 0x5e, 0x6f, 0xe5, 0x26, 0x72, 0x87, 0xca, 0x41, 0xc6, 0xcc, 0xdb, 0x96, 0xee, 0xd6, 0xb5, 0x6d, 0xee, 0x88, 0x85, 0x95, 0xec, 0xf1, 0x6a, 0xce, 0x4b, 0x6a, 0x24, 0x48, 0x70, 0xfa, 0x7f, 0x73, 0x05, 0xfd, 0x34, 0xae, 0x12, 0xb1, 0x33, 0x92, 0xca, 0x72, 0x8d, 0x34, 0x5c, 0x07, 0x31, 0xa3, 0xea, 0x8f, 0x4f, 0xa9, 0x68, 0xcd, 0xc7, 0x1c, 0xbb, 0xfb, 0x1f, 0x9f, 0x54, 0xde, 0x5e, 0x2e, 0x44, 0x39, 0x48, 0xd5, 0x44, 0x98, 0xea, 0x27, 0xbc, 0xe7, 0x67, 0x9d, 0x8b, 0x3b, 0x3c, 0xe0, 0xbf, 0x5f, 0x98, 0xed, 0xc9, 0x00, 0x54, 0x9a, 0xab, 0x02, 0x81, 0x80, 0x26, 0xb6, 0xf8, 0x14, 0xf9, 0xde, 0x3f, 0x43, 0xdf, 0xe1, 0x06, 0xfc, 0x43, 0x9f, 0xd5, 0xa2, 0xae, 0xc4, 0x3b, 0x49, 0x8f, 0x95, 0x82, 0x25, 0xea, 0x4b, 0xaf, 0x73, 0x0e, 0x9a, 0x23, 0x12, 0x79, 0x9f, 0x94, 0x8e, 0x10, 0xb9, 0x45, 0xf2, 0x08, 0xff, 0xc1, 0xab, 0x3a, 0x0f, 0xec, 0x0a, 0x95, 0x09, 0x0b, 0xf5, 0x72, 0x50, 0xb0, 0x84, 0x3c, 0x7d, 0x0c, 0xea, 0xde, 0x54, 0x7d, 0xac, 0x10, 0xdd, 0xfd, 0x44, 0x98, 0x66, 0x3b, 0x6c, 0xe7, 0xea, 0x4c, 0x9a, 0x7e, 0xb2, 0xd9, 0x96, 0xb8, 0xd3, 0x13, 0x3e, 0xd4, 0x5f, 0x17, 0x1f, 0xf7, 0x80, 0x7d, 0x24, 0x2c, 0x81, 0x57, 0x90, 0x33, 0x4f, 0x2a, 0xdb, 0x3a, 0x24, 0x74, 0xd0, 0xbe, 0x91, 0xe6, 0xce, 0x69, 0x57, 0x1d, 0x6d, 0xc1, 0xa9, 0xad, 0xc9, 0x02, 0x2b, 0x98, 0xb0, 0xfd, 0xe2, 0xf8, 0x32, 0xc3, 0xb0, 0x2c, 0x88, 0x03, 0x03, 0x03 };
            var input = new byte[] { 0x00, 0x00, 0x00, 0x14, 0xdd, 0xed, 0xa2, 0xf8, 0x42, 0x39, 0xfa, 0x83, 0x37, 0x88, 0x98, 0xed, 0x3b, 0x5a, 0x9f, 0xc3, 0x81, 0x9c, 0xe9, 0x3b, 0x32, 0x00, 0x00, 0x00, 0x06, 0x74, 0x65, 0x73, 0x74, 0x65, 0x72, 0x00, 0x00, 0x00, 0x0e, 0x73, 0x73, 0x68, 0x2d, 0x63, 0x6f, 0x6e, 0x6e, 0x65, 0x63, 0x74, 0x69, 0x6f, 0x6e, 0x00, 0x00, 0x00, 0x09, 0x70, 0x75, 0x62, 0x6c, 0x69, 0x63, 0x6b, 0x65, 0x79, 0x01, 0x00, 0x00, 0x00, 0x07, 0x73, 0x73, 0x68, 0x2d, 0x72, 0x73, 0x61, 0x00, 0x00, 0x01, 0x15, 0x00, 0x00, 0x00, 0x07, 0x73, 0x73, 0x68, 0x2d, 0x72, 0x73, 0x61, 0x00, 0x00, 0x00, 0x01, 0x23, 0x00, 0x00, 0x01, 0x01, 0x00, 0xb8, 0x3e, 0x52, 0x29, 0x23, 0x37, 0x44, 0x03, 0xbf, 0x87, 0xcc, 0xfd, 0xc7, 0x54, 0x41, 0xf5, 0xb8, 0x4b, 0x6c, 0x19, 0x28, 0xa6, 0x1a, 0xd8, 0x54, 0x76, 0x06, 0xf0, 0xc7, 0x4d, 0xc1, 0x07, 0x3f, 0x89, 0x76, 0xf8, 0x21, 0x9e, 0xcf, 0x94, 0xa4, 0x76, 0x65, 0x0a, 0x2f, 0x21, 0x8c, 0xc7, 0x74, 0xc2, 0x39, 0xcc, 0x61, 0x2e, 0x3a, 0xcc, 0x49, 0x9c, 0xb8, 0xf1, 0xa1, 0x5e, 0xcd, 0x49, 0x41, 0xe5, 0x1c, 0x4a, 0x06, 0x6d, 0x16, 0x17, 0xef, 0x6a, 0xd1, 0xdd, 0x2d, 0xd9, 0x39, 0x15, 0x00, 0xac, 0xb4, 0xc9, 0xf5, 0x3c, 0x06, 0x66, 0x14, 0x78, 0x4d, 0x94, 0x73, 0xb4, 0x9b, 0x68, 0xee, 0x5e, 0x0c, 0xe4, 0xb1, 0x83, 0x53, 0x2e, 0x18, 0x30, 0xd3, 0x7d, 0x92, 0x97, 0x32, 0x4f, 0xf6, 0xaa, 0xbf, 0xcb, 0xf7, 0x65, 0xc4, 0xc1, 0xd1, 0x4b, 0x61, 0x64, 0x35, 0xd4, 0x1e, 0xba, 0xe6, 0xae, 0x59, 0x2d, 0x3c, 0x00, 0xbe, 0x25, 0xa8, 0x14, 0x8e, 0x11, 0x12, 0x6e, 0xda, 0xbe, 0x14, 0x0b, 0xa2, 0x49, 0x45, 0x9d, 0xf7, 0xf4, 0x97, 0x9c, 0x09, 0x8b, 0xc9, 0xae, 0xcb, 0x91, 0x60, 0x0d, 0xc3, 0x64, 0x9c, 0x32, 0x97, 0x92, 0xc9, 0x79, 0x84, 0xbc, 0xb0, 0xfe, 0x5f, 0x47, 0x9a, 0xa4, 0xdb, 0x6e, 0xc1, 0x79, 0x6d, 0x8d, 0x15, 0xb8, 0x3e, 0x82, 0x92, 0xe5, 0xf5, 0x8c, 0x86, 0x25, 0xe7, 0x4f, 0xad, 0x4d, 0x5e, 0x68, 0x17, 0x0d, 0xc7, 0x2b, 0x50, 0x78, 0xd6, 0xac, 0xe6, 0xb5, 0xa1, 0xe3, 0x63, 0x9a, 0x13, 0xae, 0x20, 0x66, 0x83, 0xa6, 0x84, 0x6d, 0x90, 0x11, 0xfc, 0x94, 0x21, 0x50, 0x75, 0x17, 0x8f, 0x82, 0xf7, 0x01, 0x21, 0x19, 0xd4, 0xf4, 0x3e, 0xec, 0x8e, 0xe0, 0x63, 0x65, 0x40, 0x0f, 0xaa, 0x29, 0xfe, 0x7c, 0x39, 0x65, 0xd8, 0x84, 0xb2, 0xdb };
            var output = new byte[] { 0x00, 0x00, 0x00, 0x07, 0x73, 0x73, 0x68, 0x2d, 0x72, 0x73, 0x61, 0x00, 0x00, 0x01, 0x00, 0x57, 0x39, 0xd1, 0x2e, 0x84, 0x28, 0x9c, 0xf1, 0x96, 0x9d, 0xd7, 0x72, 0x70, 0xdd, 0x14, 0xe5, 0x73, 0x8a, 0x51, 0xd5, 0xa3, 0xa4, 0x37, 0xf3, 0xc3, 0x38, 0x59, 0xb6, 0x23, 0xea, 0xb9, 0x22, 0xa9, 0x5c, 0x96, 0x6b, 0x45, 0x79, 0x03, 0xaa, 0x23, 0xf2, 0xae, 0xdf, 0x5a, 0x47, 0xce, 0x8f, 0xcd, 0x58, 0xdb, 0x04, 0x9f, 0x73, 0x89, 0x67, 0x63, 0xe5, 0x42, 0x15, 0xa3, 0x06, 0x7e, 0x7b, 0xc9, 0xe9, 0xf7, 0x40, 0x25, 0x3d, 0xde, 0xe7, 0x98, 0x60, 0xaf, 0x23, 0x90, 0x52, 0xf8, 0x9b, 0x23, 0x96, 0xf7, 0xe6, 0x16, 0xe0, 0xca, 0xed, 0x3b, 0x89, 0x7f, 0x2c, 0xb1, 0xc8, 0xa9, 0x3f, 0x1f, 0xb0, 0x19, 0x26, 0x3c, 0x5c, 0xb2, 0x76, 0x27, 0x9b, 0xac, 0x79, 0x6e, 0xdc, 0xf7, 0x40, 0x86, 0x94, 0x6d, 0x22, 0xc2, 0x0f, 0xc7, 0x74, 0x8e, 0x83, 0x3e, 0x4b, 0x9b, 0x39, 0x3d, 0x7f, 0x13, 0xa9, 0xda, 0x41, 0x38, 0xd6, 0x7b, 0x4c, 0xa7, 0xdc, 0x87, 0x6a, 0xab, 0xa8, 0x17, 0x80, 0x11, 0x45, 0x81, 0xff, 0x9f, 0x3f, 0x29, 0x8b, 0xfa, 0x83, 0x31, 0xf1, 0x49, 0xbb, 0x12, 0x03, 0xc1, 0xfb, 0x42, 0x08, 0xca, 0xc7, 0x9c, 0xb1, 0xc2, 0xb3, 0x67, 0x13, 0x6c, 0x8c, 0x4e, 0x62, 0x8c, 0xf4, 0x27, 0xf9, 0x3b, 0xd8, 0x27, 0xcd, 0xa0, 0x96, 0xff, 0xe0, 0x59, 0x4f, 0x69, 0x29, 0x63, 0xb9, 0x03, 0x7c, 0x44, 0xf3, 0xcf, 0x3c, 0x19, 0xfe, 0x55, 0x48, 0x30, 0xea, 0x2d, 0x3a, 0x17, 0x6e, 0xe3, 0x1d, 0x6d, 0x5e, 0x63, 0xd8, 0xbe, 0x7e, 0x1f, 0xf5, 0xb0, 0x59, 0x34, 0xc0, 0x2d, 0x74, 0x5b, 0x8b, 0xda, 0x7e, 0xaf, 0x8e, 0x33, 0xdf, 0x02, 0x51, 0xdd, 0xbd, 0x48, 0x48, 0x75, 0x16, 0xb6, 0xd5, 0xcc, 0x2e, 0xf1, 0x58, 0x06, 0xb7, 0x35, 0x35, 0x9b, 0x2d, 0x74, 0x10 };

            var crypto = new CryptoPrivateKeyRsa();

            crypto.Load(key);

            var testOutput = crypto.GetSignature(input);

            CollectionAssert.Equals(output, testOutput);
        }

        [TestMethod]
        public void Test_Crypto_PrivateKey_DSS()
        {
            var key = new byte[] { 0x30, 0x82, 0x01, 0xbb, 0x02, 0x01, 0x00, 0x02, 0x81, 0x81, 0x00, 0x95, 0x34, 0xa4, 0x36, 0x50, 0x1e, 0x76, 0xb6, 0x1d, 0xa6, 0x86, 0x1e, 0xc2, 0xf5, 0x0f, 0x4a, 0x59, 0x96, 0x78, 0x7f, 0xb4, 0xce, 0xc4, 0x60, 0x07, 0x06, 0x41, 0xc1, 0xea, 0x35, 0x15, 0x15, 0x3c, 0xb5, 0xdb, 0x73, 0x2f, 0x78, 0x65, 0xd1, 0x74, 0x47, 0xd5, 0x75, 0xa8, 0x20, 0x3d, 0xbb, 0xb6, 0xad, 0xfc, 0x41, 0x2a, 0x76, 0xd7, 0xec, 0x79, 0x72, 0xdb, 0x8d, 0xbc, 0x4b, 0xc5, 0xc7, 0x09, 0x33, 0xab, 0x23, 0x08, 0x59, 0xfb, 0x18, 0xa3, 0x6f, 0x73, 0xa3, 0x7b, 0xc3, 0xb3, 0xe9, 0x01, 0xe5, 0x1b, 0x64, 0x17, 0x47, 0x76, 0xcc, 0xce, 0x90, 0xda, 0x25, 0xca, 0xa1, 0xac, 0xfb, 0xfe, 0x39, 0x3a, 0x3d, 0x2d, 0x18, 0x72, 0xd3, 0x2e, 0x4d, 0xab, 0x47, 0x23, 0x93, 0x78, 0x16, 0xa0, 0xa4, 0x94, 0xb5, 0x3e, 0x56, 0x50, 0x0a, 0x75, 0x5b, 0x4f, 0xca, 0x3f, 0x82, 0x3b, 0x6f, 0x02, 0x15, 0x00, 0xd4, 0x7b, 0xdd, 0x2f, 0xf2, 0x97, 0x40, 0x66, 0x1b, 0x4e, 0xf3, 0x81, 0x75, 0xf5, 0xc4, 0x54, 0x32, 0xb5, 0xa8, 0xa9, 0x02, 0x81, 0x80, 0x43, 0x67, 0x00, 0x46, 0x3b, 0x13, 0x11, 0xcb, 0xb9, 0xca, 0x73, 0x47, 0xfa, 0x69, 0x63, 0x61, 0xd0, 0x95, 0xf9, 0x36, 0x74, 0xc2, 0xb8, 0x48, 0x97, 0x98, 0x3e, 0x81, 0x98, 0x15, 0x7f, 0xda, 0x4f, 0x49, 0xd1, 0x52, 0x58, 0x82, 0x24, 0xd9, 0xc3, 0x89, 0xb3, 0x98, 0x5e, 0x15, 0xce, 0xb5, 0x7b, 0x68, 0x8f, 0x97, 0x09, 0x0c, 0xf9, 0xd8, 0xdf, 0x28, 0x77, 0xb7, 0x29, 0xef, 0xa3, 0xb5, 0x0d, 0x7c, 0x1e, 0x3b, 0x47, 0x08, 0xa8, 0xb9, 0x13, 0xdb, 0x12, 0xc6, 0xba, 0x80, 0x6d, 0x51, 0x2a, 0x47, 0x89, 0x2a, 0x91, 0x9c, 0x75, 0x2c, 0x2f, 0xd0, 0x43, 0x23, 0xcb, 0x37, 0x6d, 0x0e, 0x5f, 0x48, 0x26, 0xf4, 0x23, 0x01, 0x7a, 0x77, 0xdd, 0x2d, 0x02, 0xb0, 0xd7, 0xfd, 0xdf, 0x66, 0xcd, 0x8a, 0xb1, 0xf9, 0x5b, 0xe9, 0xfb, 0x86, 0xa3, 0x4a, 0x24, 0xa2, 0xcb, 0x36, 0x86, 0x51, 0x02, 0x81, 0x80, 0x77, 0xbc, 0x5c, 0xf5, 0x4f, 0xd8, 0xc6, 0x01, 0x9d, 0xe1, 0x04, 0xf9, 0x05, 0x43, 0xdc, 0xe5, 0xd2, 0x09, 0xe2, 0x17, 0x61, 0x10, 0xff, 0x0d, 0x54, 0x96, 0x71, 0xdb, 0xec, 0x00, 0x54, 0xc8, 0x18, 0xa0, 0x07, 0x1b, 0x67, 0x4c, 0xdd, 0x3e, 0xef, 0x27, 0xcd, 0xc0, 0x55, 0x5f, 0x41, 0x2f, 0xeb, 0x2b, 0x18, 0x53, 0xea, 0x6b, 0xb3, 0x62, 0x04, 0x01, 0xdd, 0xed, 0x66, 0x6a, 0xcb, 0xef, 0xd2, 0x4c, 0xbf, 0xbe, 0xcb, 0x67, 0x87, 0x99, 0xfb, 0x11, 0x99, 0x8b, 0x0c, 0xb1, 0x16, 0xc0, 0x87, 0xd1, 0x79, 0xf6, 0xcf, 0x9b, 0x27, 0xcb, 0x08, 0xa2, 0xbe, 0xdb, 0x74, 0x26, 0x31, 0x98, 0x0f, 0x83, 0xf4, 0x86, 0xb8, 0xb9, 0xb0, 0x6a, 0x0c, 0x3b, 0xd7, 0x54, 0x5e, 0x88, 0xbc, 0x81, 0xaa, 0x7e, 0x58, 0x88, 0xff, 0x2a, 0xb9, 0x77, 0x03, 0x76, 0x74, 0x5e, 0x24, 0x22, 0x4f, 0x8a, 0x02, 0x15, 0x00, 0x9d, 0x35, 0x74, 0x5a, 0x77, 0xae, 0x9c, 0xd3, 0x38, 0xa1, 0xff, 0x6d, 0x49, 0xea, 0x51, 0xb1, 0x55, 0x33, 0x34, 0x9c, 0x01 };
            var input = new byte[] { 0x00, 0x00, 0x00, 0x14, 0x6f, 0x70, 0x04, 0x42, 0xa8, 0x27, 0x87, 0xf7, 0x6b, 0x23, 0x4d, 0x14, 0xa2, 0x0e, 0xbf, 0xb2, 0x5c, 0x40, 0x4e, 0x2c, 0x32, 0x00, 0x00, 0x00, 0x06, 0x74, 0x65, 0x73, 0x74, 0x65, 0x72, 0x00, 0x00, 0x00, 0x0e, 0x73, 0x73, 0x68, 0x2d, 0x63, 0x6f, 0x6e, 0x6e, 0x65, 0x63, 0x74, 0x69, 0x6f, 0x6e, 0x00, 0x00, 0x00, 0x09, 0x70, 0x75, 0x62, 0x6c, 0x69, 0x63, 0x6b, 0x65, 0x79, 0x01, 0x00, 0x00, 0x00, 0x07, 0x73, 0x73, 0x68, 0x2d, 0x64, 0x73, 0x73, 0x00, 0x00, 0x01, 0xb1, 0x00, 0x00, 0x00, 0x07, 0x73, 0x73, 0x68, 0x2d, 0x64, 0x73, 0x73, 0x00, 0x00, 0x00, 0x81, 0x00, 0x95, 0x34, 0xa4, 0x36, 0x50, 0x1e, 0x76, 0xb6, 0x1d, 0xa6, 0x86, 0x1e, 0xc2, 0xf5, 0x0f, 0x4a, 0x59, 0x96, 0x78, 0x7f, 0xb4, 0xce, 0xc4, 0x60, 0x07, 0x06, 0x41, 0xc1, 0xea, 0x35, 0x15, 0x15, 0x3c, 0xb5, 0xdb, 0x73, 0x2f, 0x78, 0x65, 0xd1, 0x74, 0x47, 0xd5, 0x75, 0xa8, 0x20, 0x3d, 0xbb, 0xb6, 0xad, 0xfc, 0x41, 0x2a, 0x76, 0xd7, 0xec, 0x79, 0x72, 0xdb, 0x8d, 0xbc, 0x4b, 0xc5, 0xc7, 0x09, 0x33, 0xab, 0x23, 0x08, 0x59, 0xfb, 0x18, 0xa3, 0x6f, 0x73, 0xa3, 0x7b, 0xc3, 0xb3, 0xe9, 0x01, 0xe5, 0x1b, 0x64, 0x17, 0x47, 0x76, 0xcc, 0xce, 0x90, 0xda, 0x25, 0xca, 0xa1, 0xac, 0xfb, 0xfe, 0x39, 0x3a, 0x3d, 0x2d, 0x18, 0x72, 0xd3, 0x2e, 0x4d, 0xab, 0x47, 0x23, 0x93, 0x78, 0x16, 0xa0, 0xa4, 0x94, 0xb5, 0x3e, 0x56, 0x50, 0x0a, 0x75, 0x5b, 0x4f, 0xca, 0x3f, 0x82, 0x3b, 0x6f, 0x00, 0x00, 0x00, 0x15, 0x00, 0xd4, 0x7b, 0xdd, 0x2f, 0xf2, 0x97, 0x40, 0x66, 0x1b, 0x4e, 0xf3, 0x81, 0x75, 0xf5, 0xc4, 0x54, 0x32, 0xb5, 0xa8, 0xa9, 0x00, 0x00, 0x00, 0x80, 0x43, 0x67, 0x00, 0x46, 0x3b, 0x13, 0x11, 0xcb, 0xb9, 0xca, 0x73, 0x47, 0xfa, 0x69, 0x63, 0x61, 0xd0, 0x95, 0xf9, 0x36, 0x74, 0xc2, 0xb8, 0x48, 0x97, 0x98, 0x3e, 0x81, 0x98, 0x15, 0x7f, 0xda, 0x4f, 0x49, 0xd1, 0x52, 0x58, 0x82, 0x24, 0xd9, 0xc3, 0x89, 0xb3, 0x98, 0x5e, 0x15, 0xce, 0xb5, 0x7b, 0x68, 0x8f, 0x97, 0x09, 0x0c, 0xf9, 0xd8, 0xdf, 0x28, 0x77, 0xb7, 0x29, 0xef, 0xa3, 0xb5, 0x0d, 0x7c, 0x1e, 0x3b, 0x47, 0x08, 0xa8, 0xb9, 0x13, 0xdb, 0x12, 0xc6, 0xba, 0x80, 0x6d, 0x51, 0x2a, 0x47, 0x89, 0x2a, 0x91, 0x9c, 0x75, 0x2c, 0x2f, 0xd0, 0x43, 0x23, 0xcb, 0x37, 0x6d, 0x0e, 0x5f, 0x48, 0x26, 0xf4, 0x23, 0x01, 0x7a, 0x77, 0xdd, 0x2d, 0x02, 0xb0, 0xd7, 0xfd, 0xdf, 0x66, 0xcd, 0x8a, 0xb1, 0xf9, 0x5b, 0xe9, 0xfb, 0x86, 0xa3, 0x4a, 0x24, 0xa2, 0xcb, 0x36, 0x86, 0x51, 0x00, 0x00, 0x00, 0x80, 0x77, 0xbc, 0x5c, 0xf5, 0x4f, 0xd8, 0xc6, 0x01, 0x9d, 0xe1, 0x04, 0xf9, 0x05, 0x43, 0xdc, 0xe5, 0xd2, 0x09, 0xe2, 0x17, 0x61, 0x10, 0xff, 0x0d, 0x54, 0x96, 0x71, 0xdb, 0xec, 0x00, 0x54, 0xc8, 0x18, 0xa0, 0x07, 0x1b, 0x67, 0x4c, 0xdd, 0x3e, 0xef, 0x27, 0xcd, 0xc0, 0x55, 0x5f, 0x41, 0x2f, 0xeb, 0x2b, 0x18, 0x53, 0xea, 0x6b, 0xb3, 0x62, 0x04, 0x01, 0xdd, 0xed, 0x66, 0x6a, 0xcb, 0xef, 0xd2, 0x4c, 0xbf, 0xbe, 0xcb, 0x67, 0x87, 0x99, 0xfb, 0x11, 0x99, 0x8b, 0x0c, 0xb1, 0x16, 0xc0, 0x87, 0xd1, 0x79, 0xf6, 0xcf, 0x9b, 0x27, 0xcb, 0x08, 0xa2, 0xbe, 0xdb, 0x74, 0x26, 0x31, 0x98, 0x0f, 0x83, 0xf4, 0x86, 0xb8, 0xb9, 0xb0, 0x6a, 0x0c, 0x3b, 0xd7, 0x54, 0x5e, 0x88, 0xbc, 0x81, 0xaa, 0x7e, 0x58, 0x88, 0xff, 0x2a, 0xb9, 0x77, 0x03, 0x76, 0x74, 0x5e, 0x24, 0x22, 0x4f, 0x8a };
            var output = new byte[] { 0x00, 0x00, 0x00, 0x07, 0x73, 0x73, 0x68, 0x2d, 0x64, 0x73, 0x73, 0x00, 0x00, 0x00, 0x28, 0x8d, 0x1e, 0xa9, 0x41, 0x92, 0x3e, 0xa6, 0x9d, 0x13, 0x2d, 0x10, 0x36, 0x67, 0xaa, 0xa8, 0xf2, 0xfb, 0x6d, 0xc6, 0x1f, 0x0d, 0xfe, 0x7d, 0x15, 0x32, 0x51, 0xa1, 0x74, 0x21, 0x78, 0xd0, 0x75, 0x00, 0x9e, 0xcf, 0x8f, 0xbf, 0x4c, 0xc1, 0x5c };
            
            var crypto = new CryptoPrivateKeyDss();

            crypto.Load(key);

            var testOutput = crypto.GetSignature(input);

            CollectionAssert.Equals(output, testOutput);
        }
    }
}