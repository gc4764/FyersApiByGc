using System.Net;
using System.Net.Http;
using System.IO;
using System.Text;
using System.Net.Http.Headers;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Security.Cryptography;
using RestSharp;
using System.Net.Http.Json;
using System.Security.AccessControl;
using System.Text.Json;


namespace FyersApiClient
{
    public class ProfileModels
    {
        public string  Name { get; set; }
        public string  Image { get; set; }
        public string Display_Name { get; set; }
        public string Email_Id { get; set; } 
        public string Pan { get; set; }
        public string Fy_Id { get; set; }
        public DateTime Pin_Change_Date { get; set; }
        public string Mobile_Number { get; set; }  
        public bool Totp { get; set; }
        public DateTime Pwd_Change_Date { get; set; }
        public int Pwd_To_Expire { get; set; }
                
    }
}