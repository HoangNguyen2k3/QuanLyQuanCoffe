﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyquanCoffe.DTO
{
    public class Menu
    {
        public Menu(  float price,int count,string foodName,float totalPrice=0) { 
        this.Count = count;
            this.TotalPrice = totalPrice;
            this.Price = price;
            this.FoodName = foodName;
        }
        public Menu(DataRow row)
        {
            this.FoodName = row["name"].ToString();
            this.Count = (int)row["count"];
            this.Price = (float)Convert.ToDouble((row["price"]).ToString());
            this.TotalPrice = (float)Convert.ToDouble((row["totalprice"]).ToString());
        }
        private float totalPrice;
        private float price;
        private int count;
        private string foodName;

        public string FoodName { get => foodName; set => foodName = value; }
        public int Count { get => count; set => count = value; }
        public float Price { get => price; set => price = value; }
        public float TotalPrice { get => totalPrice; set => totalPrice = value; }
    }
}