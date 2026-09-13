using System;
using System.Collections.Generic;
using System.Text;
using TaskFlow.Models;

namespace TaskFlow.Helper
{
    public static class AuthHelper
    {
        public static User? CurrentUser { get; set; }
    }
}
