﻿using QuanlyquanCoffe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyquanCoffe.DAO
{
     public class TableDAO
    {
        private static TableDAO instance;
        public static TableDAO Instance
        {
            get { if (instance == null) instance = new TableDAO(); return instance; }
            private set { instance = value; }
        }
        public static int tableWidth = 100;
        public static int tableHeight = 100;
        public TableDAO() { }
        public void SwitchTable(int id1,int id2)
        {
            Dataprovider.Instance.ExcuteQuery("USP_SwitchTable1 @idTable1 , @idTable2",new object[] {id1,id2});
        }
        public List<Table> LoadTableList()
        {
            List<Table> tablelist = new List<Table>();
            DataTable data = Dataprovider.Instance.ExcuteQuery("USP_GetTableList");
            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tablelist.Add(table);
            }
            return tablelist;
        }
        public DataTable GetListTable ()
        {
            return Dataprovider.Instance.ExcuteQuery("select id as N'Mã số',name as N'Tên bàn',status as N'Trạng thái' from TableFood");
        }
    }
}
