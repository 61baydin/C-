using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ServerSessionStateWebService
{
    /// <summary>
    /// Summary description for SessionStateWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class SessionStateWebService : System.Web.Services.WebService /* 1. Bu classın miras olarak bırakılması gerekiyor. */
    {
        /* 2. (EnableSession =true) propertysi ayarlanmalı. */
        [WebMethod(EnableSession =true, Description ="Bu metot iki sayı toplar", CacheDuration =15)]
        public int Toplam(int sayi1,int sayi2){
            List<string> hesaplamalar;
            if(Session["hesaplamalar"]==null){
                hesaplamalar = new List<string>();
            }
            else{
                hesaplamalar = (List<string>)Session["hesaplamalar"]; 
            }
            string sonHesaplamalar = sayi1.ToString() + "+" + sayi2.ToString() + "=" + (sayi1 + sayi2).ToString();
            hesaplamalar.Add(sonHesaplamalar);
            Session["hesaplamalar"] = hesaplamalar;
            return sayi1+sayi2;
        }
        [WebMethod(EnableSession = true)]
        public List<string> HesaplamayıGetir(){
            if(Session["hesaplamalar"]==null){
                List<string> hesaplamalar = new List<string>();
                hesaplamalar.Add("Henüz bir işlem gerçekleştirmediniz.");
                return hesaplamalar;
            }
            else{
                return (List<string>)Session["hesaplamalar"];
            }
        }
    }
}
