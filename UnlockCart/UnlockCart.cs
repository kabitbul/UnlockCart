using System;
using System.Net;
using System.Net.Http;

namespace UnlockCart
{
    class UnlockCart
    {
        static void Main(string[] args)
        {
            string mac = "ED9AA417BDCC";
            string gmac = "BB:93:16:DE:E3:CA";
            string userId = "1";
            unlockCart(mac, gmac, userId);
        }
        public static async void unlockCart(string compMac, string gMac, string userId)
        {
            string url = "http://dev.picasau.com/MqttPub/g4/MunLock?mac={0}&userId={1}&gMac={2}";
            string urlExe = String.Format(url, compMac, userId, gMac);
            WebRequest request = WebRequest.Create(urlExe);
            WebResponse response = request.GetResponse();//opens the lock
            // Display the status.
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
        }
    }
}
