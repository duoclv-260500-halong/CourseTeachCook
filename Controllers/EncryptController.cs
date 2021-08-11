using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using CourseTeachCook.Models;
using System.Security.Cryptography;
using System.Text;
using System.IO;

namespace CourseTeachCook.Controllers
{
    public class EncryptController : Controller
    {
        public static string EncryptPassword(string password)
        {
            MD5 mD5 = MD5.Create();
            if(password == null){
                password = "";
            }
            var passwordByte = Encoding.UTF8.GetBytes(password);
            var hash = mD5.ComputeHash(passwordByte);
            var stringhash = BitConverter.ToString(hash).Replace("-", string.Empty);
            return stringhash;
        }
    }
}