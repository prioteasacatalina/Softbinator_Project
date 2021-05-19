using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Softbinator_Project.DTOs
{
    public class RefreshDto
    {
        public string AccessToken { get; set; } //tokenul expirat 
        public string RefreshToken { get; set; } //verificam daca e acelasi refresh token
    }
}
