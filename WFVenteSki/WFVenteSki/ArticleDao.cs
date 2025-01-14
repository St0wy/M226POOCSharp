﻿using System;
using System.Collections.Generic;

namespace WFVenteSki
{
    public class ArticleDao
    {

        private const char SEP = ';';
        private static readonly string[] ARTICLES = new string[] {
            "13; Caméra Magicam SD19F Sport;254.5",
            "20;Pack A.R.V.A Zoom;228.9",
            "25;Thermos Extreme de Ferrino;31.8",
            "23;Wanderer Primo Black;99.9",
            "28;Alborg Gaucho Men FA14;129",
            "27;Moon Boot Vinil Dark Brown;85",
            "18;Winter Carnival Black/Stone;119.95",
            "1;Nabucco GTX Mid Brown;169.8",
            "10;Veste de ski Homme ARMADA;239.9",
            "24;K Pro GTX Jkt Black;429.9",
            "5;Alpha SV Jkt M Cayenne;650",
            "9;DCLA 14 Jkt Black;229.1",
            "26;La Sorcha Jacket Rip Curl;139.9",
            "2;Veste de ski Femme HAGLOFS;349",
            "12;Vail Jkt Black;399.95",
            "16;Pack Press 2014;299",
            "19;Pack Shreditor 102;519",
            "3;BBR 9.0 2014;599",
            "14;Sick Day 110;549",
            "11;Le Q-96 Lumen de Salomon;479",
            "4; ARW 2014;459",
            "7;Bâtons Remit Black 2014;54.9",
            "17;Bâtons Team Issue Orange;59",
            "8;T.Rice Pro C2BTX;55",
            "21;Pack PBJ 2014;380",
            "22;Pack Jackpot 2014;540",
            "15;MTD 2014;399",
            "6;The Quiver Rail 2014;409"
            };

        public static List<Article> GetListeArticles()
        {
            List<Article> res = new List<Article>();
            for (int k = 0; k < ARTICLES.Length; k++)
            {
                String[] sT = ARTICLES[k].Split(SEP);
                int idA = Int32.Parse(sT[0]);
                String des = sT[1];
                double prix = Double.Parse(sT[2]);
                res.Add(new Article(idA, des, prix));

            }
            return res;
        }
    } //  ArticleDao

}
