﻿/***************************************************************************************************
 *                    
 *\File          Logout.aspx.cs
<<<<<<< HEAD
 *\Description  用户注销
 *\Log           2008.XX.XX    Ver 1.0    王晓晴
=======
 *\Description   用户注销
 *\Log           2012.11.07    Ver 1.0    王晓晴
>>>>>>> 95591acbefed59f0ee52ca13fce0374407032732
 *               创建文件。
 ***************************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Logout : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        /*清空session，实现注销登录*/
        Session["uid"] = null;
        Session["username"] = null;
        Session["password"] = null;
        SmallScript.goRedirect(Response, Session, "退出登陆成功。", Request["url"].ToString()); /*提示信息显示*/
    }
}