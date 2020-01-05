﻿using System;
using System.IO;
using System.Security.Cryptography;

namespace Cryptography
{
    class Program
    {
        static void Main(string[] args)
        {
           DESCryptoServiceProvider key = new DESCryptoServiceProvider();
           Console.WriteLine("Enter your message to be encrypted: ");
           string plainText = Console.ReadLine();

           string cipherText = Encrypt(plainText, key);
           Console.WriteLine("\nCipherText: " + Encrypt(plainText, key));
           Console.WriteLine("\nPlainText: " + Decrypt(cipherText, key));
        }

        private static string Decrypt(string cipherText, DESCryptoServiceProvider key)
        {
            MemoryStream ms = new MemoryStream(Convert.FromBase64String(cipherText));
            CryptoStream cs = new CryptoStream(ms, key.CreateDecryptor(), CryptoStreamMode.Read);
            StreamReader sr = new StreamReader(cs);
            return sr.ReadToEnd();

        }


        private static string Encrypt(string plainText, DESCryptoServiceProvider key)
        {
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, key.CreateEncryptor(), CryptoStreamMode.Write);
            StreamWriter sw = new StreamWriter(cs);

            sw.Write(plainText);
            sw.Flush();
            cs.FlushFinalBlock();
            return (Convert.ToBase64String(ms.GetBuffer(), 0, (int) ms.Length));
        }
    }
}
