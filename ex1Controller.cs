using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ex1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ex1Controller : ControllerBase
    {

        //api/ex1/number4
        [HttpGet("number4")] //מכניס את שם שרוצה לעשות 
        public string oddword(string n)
        {
            var array = n.Split(' ') ;
            string str = ""; 
            for (int i = 0; i < array.Length; i++)
            {
                if(i%2 == 0)
                {
                    str = str + array[i] + ' ';
                }
            }
            return str;
        }




        //api/ex1/number5
        [HttpGet("number5")]
        public bool same(string n1 ,string n2 ) // Shenkar shenkaR
        {
            n1 = n1.ToLower();
            n2 = n2.ToLower();
            if (n1 == n2)
            {
                return true;
            }
            else
                return false;
        }




        //api/ex1/number16
        [HttpGet("number16")]
        public int MinNum(int n1, int n2, int n3, int n4)
        {
            int min = n1;
            int[] arr = { n1, n2, n3, n4 };

            for (int i = 0; i < arr.Length; i++)

                if (arr[i]<min)
                {
                    min = arr[i];
                }
            return min;
        }


        //api/ex1/number18
        [HttpGet("number18")]

        public string checkplace(string s,int n)
        {

            var array = s.Split(' ');
            string str = array[n -1];
            return str;

        }


        //api/ex1/number20
        [HttpGet("number20")]
        public string starnum(int n)
        {
            string s = "";
            for (int i = 0; i < n; i++)
            {
                s = s + "*";
            }
            return s;
        }

    }
}