﻿/***************************************************************************************************
 *
 *\File          search_code.aspx.cs
 *\Description   用户搜索源代码
 *\Log           2012.11.14    Ver 1.0    肖骏涛
 *               创建文件。
 ***************************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

public partial class search_code : System.Web.UI.Page
{
    
    protected void search_Click(object sender, EventArgs e)
    {
        string message = search_textbox.Text;
        Response.Redirect("code_List.aspx?path=" + message);
    }

   
}