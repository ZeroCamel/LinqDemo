using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Security.Cryptography;


namespace LinqDemo
{
    //扩展类1、静态类 2、静态方法
    //!如果扩展方法和原方法名相同扩展方法将失效
    public static class Help
    {
        public static string MD5Hash(this string s)
        {
            //return FormsAuthentication.HashPasswordForStoringInConfigFile(s, "MD5"); 
            return null;
        }
    }
}
