using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Data.sqlClient;

namespace DataExamenn
{
    public class Dexam
    {
        SqlConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);
    }
}