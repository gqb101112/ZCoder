﻿/***************************************************************************************************
 *                    (c) Copyright 1992-2009 Embedded Products Research Center
 *                                       All Rights Reserved
 *
 *\File          usdl_xxx.h
 *\Description   XXXXXXXXXXXXX
 *\Log           2008.XX.XX    Ver 1.0    张三
 *               创建文件。
 ***************************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_UserList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void fixAdmin(object sender, EventArgs e)
    {
        Label lb=(Label)sender;
        if (lb.Text == "True")
        {
            lb.Text = "管理员";
        }
        else
        {
            lb.Text = "会员";
        }
    }
    protected void fixSex(object sender, EventArgs e)
    {
        Label lb = (Label)sender;
        if (lb.Text == "True")
        {
            lb.Text = "男";
        }
        else
        {
            lb.Text = "女";
        }
    }
}