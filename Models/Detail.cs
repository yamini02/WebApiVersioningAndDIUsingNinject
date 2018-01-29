using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiVersioningWithNinject.Models
{
    public class Detail :IDetail
    {
        public string FullName

        {

            get

            {

                return "Kamya Nehwal";

            }

            set

            {

                this.FullName = value;

            }
        }
    }
}