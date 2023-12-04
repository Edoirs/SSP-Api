using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using SelfPortalAPi.ErasModel;
using SelfPortalAPi.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfPortalAPi
{
    public  class AllFunction
    {
        public enum ApprovalStatusEnum : int
        {
            Pending = 1,
            Approved,
            DisApproved
        }
        public enum TaxPayerTypeEnum : byte
        {
            Individual = 1,
            Company,
            Special
        }
        public static string GetAccessToken(string username, string password)
        {
            string allChar = username + ":" + password;
            var random = new Random();
            var resultToken = new string(
               Enumerable.Repeat(allChar, 6)
               .Select(token => token[random.Next(token.Length)]).ToArray());

            string authToken = resultToken.ToString();
            return authToken;
        }
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
        public async Task<int> ValidateToken(string token)
        {
            if (token != null)
            {
                if (token.Contains("Bearer"))
                {
                    token = token.Replace("Bearer ", "").Trim();
                }
                else
                {
                    token = token.Replace("Basic ", "").Trim();
                }

                using var _context = new ErasContext();
                var user = await _context.MstUserTokens.FromSqlRaw($"SELECT top(1) * FROM [MST_UserToken] WHERE token = '{token}'").FirstOrDefaultAsync();

                //public static int GetUserId(string token)
                //{
                //string query = $"Select UserID from MST_UserToken where Token ='{token}'";
                //SqlConnection sqlConnection = new SqlConnection(conString);
                //SqlCommand cmd = new SqlCommand(query, sqlConnection);
                //sqlConnection.Open();
                //var result = cmd.ExecuteScalar();
                //sqlConnection.Close();
                //int userId = Convert.ToInt32(result);

                //return userId;
                // }
                if (user != null)
                {
                    return user.UserId.Value;
                }
            }
            return 0;
        }

        public static string RootPath()
        {
            return (string)AppDomain.CurrentDomain.GetData("ContentRootPath") ?? string.Empty;
        }

        private static String ErrorlineNo, Errormsg, extype, exurl, hostIp, ErrorLocation, HostAdd;

        public static void SendErrorToText(Exception ex)
        {
            var line = Environment.NewLine + Environment.NewLine;

            ErrorlineNo = ex.StackTrace.ToString();
            Errormsg = ex.GetType().Name;
            extype = ex.GetType().ToString();
            ErrorLocation = ex.Message;

            try
            {
                string filepath = System.IO.Path.Combine(RootPath(), "ErrorLog/");

                if (!Directory.Exists(filepath))
                {
                    Directory.CreateDirectory(filepath);
                }
                filepath = filepath + DateTime.Today.ToString("dd-MMM-yyyy") + ".txt";
                if (!File.Exists(filepath))
                {
                    File.Create(filepath).Dispose();
                }

                using StreamWriter sw = File.AppendText(filepath);
                var date = DateTime.Now.ToString();
                sw.WriteLine($"--------------------------------*Start @ {date}*------------------------------------------");
                string error = "Log Written Date:" + " " + DateTime.Now.ToString(CultureInfo.InvariantCulture) + line +
                               "Error Line No :" + " " + ErrorlineNo + line + "Error Message:" + " " + Errormsg + line +
                               "Exception Type:" + " " + extype + line + "Error Location :" + " " + ErrorLocation +
                               line + " Error Page Url:" + " " + exurl + line + "User Host IP:" + " " + hostIp + line;
                sw.WriteLine("-----------Exception Details on " + " " + DateTime.Now.ToString(CultureInfo.InvariantCulture) + "-----------------");
                sw.WriteLine("-------------------------------------------------------------------------------------");
                sw.WriteLine(line);
                sw.WriteLine(error);
                sw.WriteLine("--------------------------------*End*------------------------------------------");
                sw.WriteLine(line);
                sw.Flush();
                sw.Close();
            }
            catch (Exception e)
            {
                e.ToString();
            }
        }

        public static void WriteFormModel(string payload, string location)
        {
            var line = Environment.NewLine + Environment.NewLine;
            try
            {
                string filepath = System.IO.Path.Combine(RootPath(), $"Payloads/{location}/");

                if (!Directory.Exists(filepath))
                {
                    Directory.CreateDirectory(filepath);
                }
                filepath = filepath + DateTime.Today.ToString("dd-MMM-yyyy") + ".txt";
                if (!File.Exists(filepath))
                {
                    File.Create(filepath).Dispose();
                }

                using StreamWriter sw = File.AppendText(filepath);
                var date = DateTime.Now.ToString();
                sw.WriteLine($"--------------------------------*Start @ {date}*------------------------------------------");
                sw.WriteLine(payload);
                sw.WriteLine("--------------------------------*End*------------------------------------------");
                sw.WriteLine(line);
                sw.Flush();
                sw.Close();
            }
            catch (Exception e)
            {
                e.ToString();
            }
        }
       
    }
}
