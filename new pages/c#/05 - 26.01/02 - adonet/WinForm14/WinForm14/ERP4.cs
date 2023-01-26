using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm14
{
    class ERP4
    {
        //static yapınca invoke edebiliyoruz
        //SqlConnection con = new SqlConnection(ERP4.ConnectionString);

        public static string ConnectionString {
            get 
            { 
                return "Server=SEVDE;Database=Northwind;Trusted_Connection=true";
            }
        } //Connection değişmeyeceği için set kullanmaya gerek yok
    }
}
