using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using ServerDataSharper.Models;

namespace ServerDataSharper
{
    public static class ServerDataBuilder
    {
        public enum PeriodType { Hourly, Daily , Weekly, Monthly};

        public static string GetInfo(GetInfoData Data)
        {
            try
            {
                var Req = (HttpWebRequest)WebRequest.Create("https://portal.sarvdata.com/api/whoami");

                Req.Method = "GET";
                Req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/108.0.0.0 Safari/537.36";
                Req.Headers.Add("ApiToken", Data.ApiToken);
                Req.AllowAutoRedirect = true;

                var Res = (HttpWebResponse)Req.GetResponse();

                var Json = new StreamReader(Res.GetResponseStream()).ReadToEnd();

                if (Json.Contains("Succeed\":true"))
                {
                    return Regex.Match(Json, "\"Data\":{(.*?)}").Groups[1].Value;
                }
                else if (Json.Contains("Succeed\":false"))
                {
                    var Message = Regex.Match(Json, "Exception\":\"(.*?)\"").Groups[1].Value;

                    return Message;
                }
            }
            catch(HttpListenerException ex)
            {
                return ex.Message;
            }
            return "False";
        }

        public static string GetServerInfo(GetInfoData Data)
        {
            try
            {
                var Req = (HttpWebRequest)WebRequest.Create("https://portal.sarvdata.com/api/vm/list");

                Req.Method = "GET";
                Req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/108.0.0.0 Safari/537.36";
                Req.Headers.Add("ApiToken", Data.ApiToken);
                Req.AllowAutoRedirect = true;

                var Res = (HttpWebResponse)Req.GetResponse();

                var Json = new StreamReader(Res.GetResponseStream()).ReadToEnd();

                if (Json.Contains("Succeed\":true"))
                {
                    return Regex.Match(Json, "\"Data\":{(.*?)}").Groups[1].Value;
                }
                else if (Json.Contains("Succeed\":false"))
                {
                    var Message = Regex.Match(Json, "Exception\":\"(.*?)\"").Groups[1].Value;

                    return Message;
                }
            }
            catch (HttpListenerException ex)
            {
                return ex.Message;
            }
            return "False";
        }

        public static string GetServerLocations(GetInfoData Data)
        {
            try
            {
                var Req = (HttpWebRequest)WebRequest.Create("https://portal.sarvdata.com/api/locations");

                Req.Method = "GET";
                Req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/108.0.0.0 Safari/537.36";
                Req.Headers.Add("ApiToken", Data.ApiToken);
                Req.AllowAutoRedirect = true;

                var Res = (HttpWebResponse)Req.GetResponse();

                var Json = new StreamReader(Res.GetResponseStream()).ReadToEnd();

                if (Json.Contains("Succeed\":true"))
                {
                    return Regex.Match(Json, "\"Data\":{(.*?)}").Groups[1].Value;
                }
                else if (Json.Contains("Succeed\":false"))
                {
                    var Message = Regex.Match(Json, "Exception\":\"(.*?)\"").Groups[1].Value;

                    return Message;
                }
            }
            catch (HttpListenerException ex)
            {
                return ex.Message;
            }
            return "False";
        }

        public static string ShotDownServer(SettingServerData Data)
        {
            try
            {
                var Req = (HttpWebRequest)WebRequest.Create($"https://portal.sarvdata.com/api/vm/stop/{Data.Id}");

                Req.Method = "GET";
                Req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/108.0.0.0 Safari/537.36";
                Req.Headers.Add("ApiToken", Data.ApiToken);
                Req.AllowAutoRedirect = true;

                var Res = (HttpWebResponse)Req.GetResponse();

                var Json = new StreamReader(Res.GetResponseStream()).ReadToEnd();

                if (Json.Contains("Succeed\":true"))
                {
                    return "Server Is Off";
                }
                else if (Json.Contains("Succeed\":false"))
                {
                    var Message = Regex.Match(Json, "Exception\":\"(.*?)\"").Groups[1].Value;

                    return Message;
                }
            }
            catch (HttpListenerException ex)
            {
                return ex.Message;
            }
            return "False";
        }

        public static string StartServer(SettingServerData Data)
        {
            try
            {
                var Req = (HttpWebRequest)WebRequest.Create($"https://portal.sarvdata.com/api/vm/start/{Data.Id}");

                Req.Method = "GET";
                Req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/108.0.0.0 Safari/537.36";
                Req.Headers.Add("ApiToken", Data.ApiToken);
                Req.AllowAutoRedirect = true;

                var Res = (HttpWebResponse)Req.GetResponse();

                var Json = new StreamReader(Res.GetResponseStream()).ReadToEnd();

                if (Json.Contains("Succeed\":true"))
                {
                    return "Server Is Start";
                }
                else if (Json.Contains("Succeed\":false"))
                {
                    var Message = Regex.Match(Json, "Exception\":\"(.*?)\"").Groups[1].Value;

                    return Message;
                }
            }
            catch (HttpListenerException ex)
            {
                return ex.Message;
            }
            return "False";
        }

        public static string RestartServer(SettingServerData Data)
        {
            try
            {
                var Req = (HttpWebRequest)WebRequest.Create($"https://portal.sarvdata.com/api/vm/restart/{Data.Id}");

                Req.Method = "GET";
                Req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/108.0.0.0 Safari/537.36";
                Req.Headers.Add("ApiToken", Data.ApiToken);
                Req.AllowAutoRedirect = true;

                var Res = (HttpWebResponse)Req.GetResponse();

                var Json = new StreamReader(Res.GetResponseStream()).ReadToEnd();

                if (Json.Contains("Succeed\":true"))
                {
                    return "Server Is Restart";
                }
                else if (Json.Contains("Succeed\":false"))
                {
                    var Message = Regex.Match(Json, "Exception\":\"(.*?)\"").Groups[1].Value;

                    return Message;
                }
            }
            catch (HttpListenerException ex)
            {
                return ex.Message;
            }
            return "False";
        }

        public static string PauseServer(SettingServerData Data)
        {
            try
            {
                var Req = (HttpWebRequest)WebRequest.Create($"https://portal.sarvdata.com/api/vm/pause/{Data.Id}");

                Req.Method = "GET";
                Req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/108.0.0.0 Safari/537.36";
                Req.Headers.Add("ApiToken", Data.ApiToken);
                Req.AllowAutoRedirect = true;

                var Res = (HttpWebResponse)Req.GetResponse();

                var Json = new StreamReader(Res.GetResponseStream()).ReadToEnd();

                if (Json.Contains("Succeed\":true"))
                {
                    return "Server Is Restart";
                }
                else if (Json.Contains("Succeed\":false"))
                {
                    var Message = Regex.Match(Json, "Exception\":\"(.*?)\"").Groups[1].Value;

                    return Message;
                }
            }
            catch (HttpListenerException ex)
            {
                return ex.Message;
            }
            return "False";
        }

        public static string SaveServer(SettingServerData Data)
        {
            try
            {
                var Req = (HttpWebRequest)WebRequest.Create($"https://portal.sarvdata.com/api/vm/save/{Data.Id}");

                Req.Method = "GET";
                Req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/108.0.0.0 Safari/537.36";
                Req.Headers.Add("ApiToken", Data.ApiToken);
                Req.AllowAutoRedirect = true;

                var Res = (HttpWebResponse)Req.GetResponse();

                var Json = new StreamReader(Res.GetResponseStream()).ReadToEnd();

                if (Json.Contains("Succeed\":true"))
                {
                    return "Server Is Save";
                }
                else if (Json.Contains("Succeed\":false"))
                {
                    var Message = Regex.Match(Json, "Exception\":\"(.*?)\"").Groups[1].Value;

                    return Message;
                }
            }
            catch (HttpListenerException ex)
            {
                return ex.Message;
            }
            return "False";
        }

        public static string CheckServer(SettingServerData Data)
        {
            try
            {
                var Req = (HttpWebRequest)WebRequest.Create($"https://portal.sarvdata.com/api/vm/check/{Data.Id}");

                Req.Method = "GET";
                Req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/108.0.0.0 Safari/537.36";
                Req.Headers.Add("ApiToken", Data.ApiToken);
                Req.AllowAutoRedirect = true;

                var Res = (HttpWebResponse)Req.GetResponse();

                var Json = new StreamReader(Res.GetResponseStream()).ReadToEnd();

                if (Json.Contains("Succeed\":true"))
                {
                    return $"Server Is {Regex.Match(Json, "Data\": \"(.*?)\"").Groups[1].Value}";
                }
                else if (Json.Contains("Succeed\":false"))
                {
                    var Message = Regex.Match(Json, "Exception\":\"(.*?)\"").Groups[1].Value;

                    return Message;
                }
            }
            catch (HttpListenerException ex)
            {
                return ex.Message;
            }
            return "False";
        }

        public static string ByServer(ByServerData Data)
        {
            try
            {
                var PostData = $"{{“LocationId”: “{Data.LocationId}”, “PlanId”: “{Data.PlanId}”, “PeriodType”: “{Data.PeriodType}”, “DiskId”: “{Data.DiskId}”, “Count”: “{Data.Count}”, “Coupon”: “{Data.Coupon}”}}";

                var ToByte = Encoding.UTF8.GetBytes(PostData);

                var Req = (HttpWebRequest)WebRequest.Create($"https://portal.sarvdata.com/api/vm/create");

                Req.Method = "POST";
                Req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/108.0.0.0 Safari/537.36";
                Req.Headers.Add("ApiToken", Data.ApiToken);
                Req.AllowAutoRedirect = true;
                Req.ContentType = "application/json";
                Req.ContentLength = ToByte.Length;

                var StreamPostData = Req.GetRequestStream();
                StreamPostData.Write(ToByte, 0, ToByte.Length);

                var Res = (HttpWebResponse)Req.GetResponse();

                var Json = new StreamReader(Res.GetResponseStream()).ReadToEnd();

                if (Json.Contains("Succeed\":true"))
                {
                    return $"Server Is {Regex.Match(Json, "Data\": \"(.*?)\"").Groups[1].Value}";
                }
                else if (Json.Contains("Succeed\":false"))
                {
                    var Message = Regex.Match(Json, "Exception\":\"(.*?)\"").Groups[1].Value;

                    return Message;
                }
            }
            catch (HttpListenerException ex)
            {
                return ex.Message;
            }
            return "False";
        }

        public static string GetPlans(GetPlanData Data)
        {
            try
            {
                var Req = (HttpWebRequest)WebRequest.Create($"https://portal.sarvdata.com/api/locations/{Data.LocationId}/plans/{Data.PlanId}/disks/{Data.PeriodType}");

                Req.Method = "GET";
                Req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/108.0.0.0 Safari/537.36";
                Req.Headers.Add("ApiToken", Data.ApiToken);
                Req.AllowAutoRedirect = true;

                var Res = (HttpWebResponse)Req.GetResponse();

                var Json = new StreamReader(Res.GetResponseStream()).ReadToEnd();

                if (Json.Contains("Succeed\":true"))
                {
                    return Regex.Match(Json, "\"Data\":{(.*?)}").Groups[1].Value;
                }
                else if (Json.Contains("Succeed\":false"))
                {
                    var Message = Regex.Match(Json, "Exception\":\"(.*?)\"").Groups[1].Value;

                    return Message;
                }
            }
            catch (HttpListenerException ex)
            {
                return ex.Message;
            }
            return "False";
        }

        public static string RenewServer(RenewServerData Data)
        {
            try
            {
                var PostData = $"{{“VMId”: “{Data.VMId}”, “PeriodType”: “{Data.PeriodType}”, “Count”: “{Data.Count}”, “Coupon”: “{Data.Coupon}”}}";

                var ToByte = Encoding.UTF8.GetBytes(PostData);

                var Req = (HttpWebRequest)WebRequest.Create($"https://portal.sarvdata.com/api/vm/renew");

                Req.Method = "POST";
                Req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/108.0.0.0 Safari/537.36";
                Req.Headers.Add("ApiToken", Data.ApiToken);
                Req.AllowAutoRedirect = true;
                Req.ContentType = "application/json";
                Req.ContentLength = ToByte.Length;

                var StreamPostData = Req.GetRequestStream();
                StreamPostData.Write(ToByte, 0, ToByte.Length);

                var Res = (HttpWebResponse)Req.GetResponse();

                var Json = new StreamReader(Res.GetResponseStream()).ReadToEnd();

                if (Json.Contains("Succeed\":true"))
                {
                    return $"Server Is {Regex.Match(Json, "Data\": \"(.*?)\"").Groups[1].Value}";
                }
                else if (Json.Contains("Succeed\":false"))
                {
                    var Message = Regex.Match(Json, "Exception\":\"(.*?)\"").Groups[1].Value;

                    return Message;
                }
            }
            catch (HttpListenerException ex)
            {
                return ex.Message;
            }
            return "False";
        }

        public static string ChnageOsServer(ChangeOsServerData Data)
        {
            try
            {
                var PostData = $"{{“VMId”: “{Data.VMId}”, “DiskId”: “{Data.DiskId}”, “Coupon”: “{Data.Coupon}”}}";

                var ToByte = Encoding.UTF8.GetBytes(PostData);

                var Req = (HttpWebRequest)WebRequest.Create($"https://portal.sarvdata.com/api/vm/reload");

                Req.Method = "POST";
                Req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/108.0.0.0 Safari/537.36";
                Req.Headers.Add("ApiToken", Data.ApiToken);
                Req.AllowAutoRedirect = true;
                Req.ContentType = "application/json";
                Req.ContentLength = ToByte.Length;

                var StreamPostData = Req.GetRequestStream();
                StreamPostData.Write(ToByte, 0, ToByte.Length);

                var Res = (HttpWebResponse)Req.GetResponse();

                var Json = new StreamReader(Res.GetResponseStream()).ReadToEnd();

                if (Json.Contains("Succeed\":true"))
                {
                    return $"Server Is {Regex.Match(Json, "Data\": \"(.*?)\"").Groups[1].Value}";
                }
                else if (Json.Contains("Succeed\":false"))
                {
                    var Message = Regex.Match(Json, "Exception\":\"(.*?)\"").Groups[1].Value;

                    return Message;
                }
            }
            catch (HttpListenerException ex)
            {
                return ex.Message;
            }
            return "False";
        }
    }
}
