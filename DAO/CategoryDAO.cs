﻿using QuanlyquanCoffe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyquanCoffe.DAO
{
    public class CategoryDAO
    {
        private CategoryDAO() { }
        private static CategoryDAO instance;
        public static CategoryDAO Instance {
            get { if (instance == null) { instance = new CategoryDAO(); }; return instance; }
            private set { instance = value; }
        }
        public List<Category> GetListCategory()
        {
            List<Category> list = new List<Category>();
            string query="select * from FoodCategory";
            DataTable data = Dataprovider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Category category=new Category(item);
                list.Add(category);
            }
            return list;
        }
    }
}
