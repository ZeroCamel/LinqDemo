using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace LinqDemo
{
    class Program
    {
        /// <summary>
        /// 诞生的理由-以一种统一的方式操作各种数据源，减少数据访问的复杂性
        /// 1、数据访问对象类型 XML,OBJECT,SQL   后续还有LINQ TO ENTITY
        /// 2、var 类似Javascript里面弱类型的变量
        /// 3、感觉类似用SQL脚本式语言操作其他数据类型，
        ///    提供了对象领域和数据领域之间对接的土壤
        ///    
        /// 强类型和弱类型语言的区别
        /// 1、变量的使用要有严格的定义，所有变量必须先使用后定义
        ///    （不同类型的变量不可以放在同一块存储区域）
        /// 2、弱类型的语言，数据类型是可以被忽略的语言，一个变量可以可以赋值不同数据类型的值
        ///    （不同类型的变量可以放在同一块存储区域）给予了开发人员滥用的机会
        ///     但是只有在运行时才会发现
        /// 3、c#也不是‘绝对’的强类型的语言
        ///    object是属于弱类型  var变量代码智能的体现 可以根据上下文推断出类型
        /// 4、弱类型语言有VBScirpt PHP
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //MethodInfo[] methods = typeof(string).GetMethods();
            ////m-隐式声明的变量
            //var result = from m in methods
            //             where m.IsStatic != true
            //             select m.Name;

            //var resultDis = (from m in methods
            //                 where m.IsStatic != true
            //                 select m.Name).Distinct();

            ////System.Linq.Lookup`2+Grouping[System.String,System.Reflection.MethodInfo]
            //var resultDis1 = from m in methods
            //                 where m.IsStatic != true
            //                 group m by m.Name;

            ////into 对象赋值 匿名参数 将对象属性赋值给NEW 之后的新变量
            ////select cl1,count(1) from a group by a.cl1
            ////NEW { } 匿名类(不用写类的声明，直接实例化)
            ////名字可以不用写 大括号里的为类初始化器 省去了构造函数 NEW的同时 给对象属性赋值 
            ////var 懒人专用
            //var resultDis2 = from m in methods
            //                 where m.IsStatic != true
            //                 group m by m.Name into g
            //                 select new { MethodName = g.Key, OverLoad = g.Count() }; //Myclass my = new Myclass();    

            //foreach (var item in resultDis2)
            //{
            //    Console.WriteLine(item.ToString());
            //}
            ////一、LINQ
            ////1、DLINQ LinqtoSql 基于关系的.NET语言集成查询以对象形式管理关系数据，并提供了丰富的查询功能
            ////2、LINQ TO XML
            ////3、LINQ TO OBJECT
            ////4、LINQ TO DATASET
            ////5、LINQ TO ENTITIES
            //var age = 16;
            //var username = "zhuye";
            //var userlist = new[] { "a", "b", "c" };
            //foreach (var user in userlist)
            //{
            //    Console.WriteLine(user);
            //}
            ////匿名类型
            ////允许开发人员自定义行内类型，无需显示定义类型 实现了对象的转换和投影
            //var date = new { username = "zhuye", age = "16" };
            //Console.WriteLine("username:{0} age:{1}", date.username, date.age);

            ////lambda表达式
            ////和2.0产生内联的方法是一致的
            //var list = new[] { "aaa", "ab", "cc" };
            ////参数列表=》表达式或者语句块
            ////参数：多个参数 一个参数 或者无参数
            ////表达式：相当于函数体
            //var lamdaResult = Array.FindAll(list, s => (s.IndexOf("a") > -1));
            //foreach (var a in lamdaResult)
            //{
            //    Console.WriteLine(a);
            //}
            //是否包含负值
            //string strReg_3 = @"^-?[0-9]+\.*[0-9]*$";
            //Regex regex_3 = new Regex(strReg_3, RegexOptions.IgnoreCase);

            //string a = "-34.00";
            //if (regex_3.IsMatch(a))
            //{
            //    MatchCollection match = regex_3.Matches(a);
            //    Console.Write(Convert.ToDecimal(match[0].ToString()));
            //}
            //string a = "_^尿视黄醇结合蛋白$";
            //string[] b = a.Split('_');
            //for (int i = 0; i < b.Length; i++)
            //{
            //    Console.WriteLine(b[i]);
            //}

            ////skip skipwhile take takewhile
            //string[] names = { "DebugLZQ", "DebugMan", "Sarah", "Jerry", "Tom", "Linda", "M&M", "Jeffery" };
            ////1.Take用于从一个序列的开头返回指定数量的元素
            ////
            ////a.在数组上直接使用Take方法
            //foreach (string name in names.Take(3))
            //{
            //    Console.Write("{0}  ", name);
            //}
            //Console.WriteLine();
            //Console.WriteLine("-----");
            ////b.在LINQ返回的IEnumerable<T>序列上使用Take方法
            //var query = from string name in names
            //            where name.Length <= 3
            //            select name;
            //foreach (string name in query.Take(1))
            //{
            //    Console.Write("{0}  ", name);
            //}
            //Console.WriteLine();
            //Console.WriteLine("----------------------------");
            //Console.ReadKey(false);
            ////2.TakeWhile 用于获取指定序列从头开始符合条件的元素，直到遇到不符合条件的元素为止
            ////
            //var takenames = names.TakeWhile(n => n.Length > 4);
            //var takenames2 = names.TakeWhile((n, i) => n.Length < 10 && i < 3);
            //foreach (string name in takenames)
            //{
            //    Console.Write("{0}  ", name);
            //}
            //Console.WriteLine();
            //Console.WriteLine("-----");
            //foreach (string name in takenames2)
            //{
            //    Console.Write("{0}  ", name);
            //}
            //Console.WriteLine();
            //Console.WriteLine("----------------------------");
            //Console.ReadKey(false);
            ////3.Skip跳过序列中指定数量的元素
            ////
            //foreach (string name in names.Skip(5))
            //{
            //    Console.Write("{0}  ", name);
            //}
            //Console.WriteLine();
            //Console.WriteLine("-----");
            //var query_skip = (from name in names
            //                  where name.Length >= 3
            //                  select name).Skip(2);
            //foreach (string name in query_skip.Skip(2))
            //{
            //    Console.Write("{0}  ", name);
            //}
            //Console.WriteLine();
            //Console.WriteLine("----------------------------");
            //Console.ReadKey(false);
            ////4.SkipWhile 用于跳过序列总满足条件的元素，然会返回剩下的元素
            ////跳过名字长度大于3的
            //var takenames_SkipWhile = names.SkipWhile(n => n.Length > 3);
            //foreach (string name in takenames_SkipWhile)
            //{
            //    Console.Write("{0}  ", name);
            //}
            //Console.WriteLine();
            //Console.WriteLine("-----");
            //var takenames_SkipWhile2 = names.SkipWhile((n, i) => n.Length > 3 && i > 2);
            //foreach (string name in takenames_SkipWhile2)
            //{
            //    Console.Write("{0}  ", name);
            //}
            //Console.WriteLine();
            //Console.WriteLine("----------------------------");
            //Console.ReadKey(false);

            ////小结Take、Skip获得第N到第M个元素
            //var names_TakeAndSkip = names.Skip(5).Take(3);

            //var names_TakeAndSkip2 = (from name in names
            //                          select name).Skip(5).Take(3);

            //foreach (string name in names_TakeAndSkip)
            //{
            //    Console.Write("{0}  ", name);
            //}
            //Console.WriteLine();
            //Console.WriteLine("-----");
            //foreach (string name in names_TakeAndSkip2)
            //{
            //    Console.Write("{0}  ", name);
            //}
            //Console.WriteLine();
            //Console.WriteLine("----------------------------");
            //Console.ReadKey(false);


            #region OTHER
            //int[] myarr = new int[] { 1, 2, 3 };

            ////Console.WriteLine("{0}", mianji());

            ////Console.WriteLine("{0}", mianji(2.0)); 
            //string a = "1.42×10^4";
            //string tar = "细菌数";
            //string b = "<50qefasfasfsafsfsd0";
            //string c = "细菌数：250-300个/油镜";
            //Regex rege = new Regex(@"×10\^");
            //string B = Regex.Replace(a, @"×10\^", "E");
            //string aac = "3.4E-05";
            //Regex rege1 = new Regex(@"[0-9]+\.*[0-9]*");


            //Console.WriteLine(ChangeDataToD(aac));
            //Console.WriteLine(b.Contains(""));
            //Console.WriteLine(a.Substring(2));
            //Console.WriteLine(CutYuJuZhiJianHuo(c, "G+球菌", "88", false));
            //Console.WriteLine(c.Substring(c.IndexOf(tar) + tar.Length));
            //MatchCollection matchCol = rege1.Matches(c);

            //for (int i = 0; i < matchCol.Count; i++)
            //{
            //    Console.WriteLine(matchCol[i].ToString());
            //}
            //List<string> matchStr = new List<string>();
            //string regeBiaoben = string.Empty;
            //string regeItemName = string.Empty;
            //string regeCulResult = string.Empty;
            //string regeAntiName = string.Empty;
            //regeBiaoben = ".*";
            //regeItemName = "药敏定量试验";
            //regeCulResult = ".*";
            //regeAntiName = ".*";
            //matchStr.Add(regeBiaoben);
            //matchStr.Add(regeItemName);
            //matchStr.Add(regeCulResult);
            //matchStr.Add(regeAntiName);
            //for (int i = 0; i < matchStr.Count; i++)
            //{
            //    Console.WriteLine(matchStr[i].ToString());
            //}
            //matchStr[2] = "hhhh";
            //for (int i = 0; i < matchStr.Count; i++)
            //{
            //    Console.WriteLine(matchStr[i].ToString());
            //}
            ////DateTime datatime1 = "";
            ////DateTime datatime2 = "";
            ////TimeSpan ts = DateTime1.Subtract(DateTime2).Duration();
            ////day = ts.Days.ToString();

            //DateTime dt = Convert.ToDateTime("2017-08-09 00:00:00");
            //DateTime dt1 = Convert.ToDateTime("2017-08-10 13:00:00");
            //Console.WriteLine(dt.Date);
            //Console.WriteLine((dt.Date - dt1.Date).Days.ToString());
            //Console.WriteLine(dt.Subtract(dt1).Duration());


            //Person p = new Person();
            //p.name = "5";
            //p.age = 12;
            //p.score = 12.02m;

            //Person p1 = new Person();
            //p1.name = "2";
            //p1.age = 13;
            //p1.score = 12.00m;

            //Person p2 = new Person();
            //p2.name = "4";
            //p2.age = 14;
            //p2.score = 12.02m;

            //Person p3 = new Person();
            //p3.name = "3";
            //p3.age = 15;
            //p3.score = 12.00m;

            //List<Person> lstP = new List<Person>();
            //lstP.Add(p);
            //lstP.Add(p1);
            //lstP.Add(p2);
            //lstP.Add(p3);

            //lstP = lstP.OrderBy(d => d.score).ThenBy(d => d.name).ToList();
            //Console.WriteLine("---------------");
            //foreach (Person item in lstP)
            //{
            //    Console.WriteLine(item.name + '-' + item.score);
            //}

            //string pattern = @"(\d{3})-(\d{3}-\d{4})";
            //string input = "212-555-6666 906-932-1111 415-222-3333 425-888-9999";
            //MatchCollection matches = Regex.Matches(input, pattern);

            //foreach (Match match2 in matches)
            //{
            //    Console.WriteLine("Area Code:        {0}", match2.Groups[1].Value);
            //    Console.WriteLine("Telephone number: {0}", match2.Groups[2].Value);
            //    Console.WriteLine();
            //}

            //(?!=,).*(?=h)
            //string testStr = ",hhh111.00,adsfasdfs,asdf";
            //string strReg_3 = @"(,.*a.*)";
            //Regex regex_3 = new Regex(strReg_3, RegexOptions.IgnoreCase);
            //MatchCollection match = regex_3.Matches(testStr);
            //string[] matchs=regex_3.Split(testStr);

            //string a = Guid.NewGuid().ToString();
            //Console.WriteLine(a);
            //Console.WriteLine(match[0]);


            //Console.WriteLine("Current Processor:" + System.Environment.ProcessorCount);

            //string aa = "<180.00";
            //decimal result = 0.0m;
            //Console.WriteLine(decimal.TryParse(aa.ToString(), out result) ? result : 0);

            //string bb = "DR_02_20031".Replace("|", "','") + "|";

            //Console.WriteLine(bb.Substring(0, bb.Length - 1));

            //string s1 = "，最远的标点，asdfhasohz中欧第一个奥的斯嘎哈送服哀悼啊但是看第二个了附件啊师傅，奥萨蒂放假哦阿三第二个奥i的司法，asdfhasohz中欧奥的斯嘎哈送服哀悼啊但是看了附件啊师傅，奥萨蒂放假哦阿三奥i的司法";
            //List<string> s = CutContentHQHList("我", "，|。|；", "，|。|；", s1, RegexOptions.IgnoreCase);

            //Console.WriteLine(aa.Contains(".*"));

            //string s2 = "-2.0";
            //string S3 = "78×10^5";
            //Console.WriteLine(decimal.TryParse(s2, out result) ? result : 0);
            //Console.WriteLine(S3.Contains(@"×10^"));

            //Console.WriteLine(DateTime.Now.TimeOfDay);
            //Console.WriteLine(System.Environment.ProcessorCount);
            #endregion

            #region 编码
            //字符集-一个字符和数字对应的表 表示每一个字符都对应一个数字 其实就是一张表
            //编码格式-这些字符对应的数字如何在计算机中存储
            //ASCII GB2312 GB18030-简体 BIG5-繁体
            //ASCII 最早的字符集 一个字符用一个字节表示 不过它只能表示部分字符
            //Mbcs多字节表示->Unicode 一个字符两个字节
            //UCS2-一个字符两个字节 UCS4-一个字符用4个字节
            //UTF7(汉字4字节 英文1个字节 目前主要用于邮件方面) UTF8（汉字3个字节 英文1个字节）
            //UTF16 UTF32 都是以Unicode都是以为基础进行编码的
            //Unicode和BigEndianUnicode都是用2个字节对一个字符进行编码格式;只不过它们储存字符的顺序正好相反*/  

            //string msg = "测试CESHI";
            //string msg1 = "C";//63 //99 //67
            //string receive = string.Empty;
            //List<byte> lst = new List<byte>();
            //lst.AddRange(Encoding.ASCII.GetBytes(msg1));
            //lst.AddRange(ASCIIEncoding.ASCII.GetBytes(msg));
            //lst.AddRange(UTF8Encoding.ASCII.GetBytes(msg));
            //lst.AddRange(UnicodeEncoding.ASCII.GetBytes(msg));
            //lst.AddRange(UTF32Encoding.ASCII.GetBytes(msg));
            //lst.AddRange(UTF7Encoding.ASCII.GetBytes(msg));


            //string str2 = Encoding.ASCII.GetString(lst.ToArray());
            //receive = BitConverter.ToString(lst.ToArray());

            //lst = new List<byte>(Encoding.UTF7.GetBytes(msg));
            //receive = BitConverter.ToString(lst.ToArray());

            //lst = new List<byte>(Encoding.UTF8.GetBytes(msg));
            //receive = Encoding.UTF8.GetString(lst.ToArray());
            //receive = BitConverter.ToString(lst.ToArray());

            //byte[] length = BitConverter.GetBytes(0x7D02);

            //Console.WriteLine(str2);
            //Console.WriteLine(receive);

            //SELECT SELECTMANY
            //string[] text = { "Albert was here", "Burke slept late", "Connor is happy" };

            //var tokens = text.Select(s => s.Split(' '));

            //var tokenss = text.SelectMany(s => s.Split(' '));

            //foreach (string[] line in tokens)

            //    foreach (string token in line)

            //        Console.Write("{0} ", token);

            //Console.WriteLine();
            //foreach (string token in tokenss)
            //    Console.Write("{0} ", token);

            //Switch 不加Case 报错
            //string s = "123";
            //switch (s)
            //{
            //    case "123":
            //        Console.WriteLine("111");
            //        //break;
            //    case "234":
            //        Console.WriteLine("222");
            //        break;
            //    default:
            //        break;
            //}

            //闭包
            List<Person> lstp = new List<Person>()
            {
                new Person {name="a",age=14,score=20 },
                new Person {name="b",age=14,score=20 },
                new Person {name="c",age=14,score=20 }
            };

            for (int i = 0; i < 3; i++)
            {
                Person p = lstp[i];
                ThreadPool.QueueUserWorkItem((obj) =>
                {

                    Thread.Sleep(1000);
                    //闭包的陷阱 索引超出范围 内部变量引用外部函数的最终值
                    //Person p = lstp[i];
                    Console.WriteLine(p.name);
                });
            }

            #endregion
            Console.ReadLine();
        }
        static double mianji(int m, double banjing = 1)
        {
            return banjing * banjing * 3.14;
        }
        public static Decimal ChangeDataToD(string strData)
        {
            Decimal dData = 0.0M;
            if (strData.Contains("E"))
            {
                dData = Convert.ToDecimal(Decimal.Parse(strData.ToString(), System.Globalization.NumberStyles.Float));
            }
            return dData;
        }

        public static List<string> CutContentHQHList(string strHx, string strHxQ, string strHxH, string content, RegexOptions ro)
        {
            var result = new List<string>();
            //核心词
            var regHx = new Regex(strHx, ro);
            var regHxQ = new Regex(strHxQ, ro);
            var regHxH = new Regex(strHxH, ro);
            //一个核心词位置
            var HxPosition = -1;
            var hxMatchs = regHx.Matches(content); //检索关键词

            for (int i = 0; i < hxMatchs.Count; i++)
            {
                HxPosition = hxMatchs[i].Index;//核心词的位置
                var hxLenth = hxMatchs[i].Length;
                string contentTempL = content.Substring(0, HxPosition);
                string contentTempR = content.Substring(HxPosition + hxLenth);
                var hxMatchsQ = regHxQ.Matches(contentTempL); //检索关键词
                var hxMatchsH = regHxH.Matches(contentTempR); //检索关键词
                string strCut = "";
                string strCutL = "";
                string strCutR = "";


                if (hxMatchsQ.Count > 0)
                {
                    strCutL = contentTempL.Substring(hxMatchsQ[hxMatchsQ.Count - 1].Index, contentTempL.Length - hxMatchsQ[hxMatchsQ.Count - 1].Index);
                }
                else
                {
                    strCutL = contentTempL;
                }
                if (hxMatchsH.Count > 0)
                {
                    strCutR = contentTempR.Substring(0, hxMatchsH[0].Index + hxMatchsH[0].Value.Length);
                }
                else
                {
                    strCutR = contentTempR;
                }
                strCut = strCutL + hxMatchs[i].Value + strCutR;//前字符串+核心词+后字符串
                if (!string.IsNullOrEmpty(strCut))
                    result.Add(strCut);
            }

            return result;
        }
        public static string CutYuJuZhiJianHuo(string content, string hxq, string hxh, bool isZuihou)
        {
            string strResult = string.Empty;
            List<string> hxqList = null;
            List<string> hxhList = null;
            string qian = string.Empty;
            string hou = string.Empty;
            string contentNew = string.Empty;
            if (string.IsNullOrEmpty(content) || string.IsNullOrEmpty(hxq))
            {
                return strResult;
            }
            hxqList = hxq.Split('|').ToList();
            hxhList = hxh.Split('|').ToList();

            foreach (string item in hxqList)
            {
                if (content.Contains(item))
                {
                    qian = item;
                    break;
                }
            }
            if (!string.IsNullOrEmpty(qian))
            {
                contentNew = content.Substring(content.IndexOf(qian) + qian.Length);
            }
            foreach (string item in hxhList)
            {
                if (contentNew.Contains(item))
                {
                    hou = item;
                    break;
                }
            }
            if (!string.IsNullOrEmpty(hou))
            {
                strResult = contentNew.Substring(0, contentNew.IndexOf(hou));
            }
            else if (isZuihou == true)
            {
                strResult = contentNew;
            }
            return strResult;
        }
    }
}
