using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace Lit
{
    class WarframeItem
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public double Damage { get; set; }
        public string ImageSource { get; set; }
       
       
    }
}
