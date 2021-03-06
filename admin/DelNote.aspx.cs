﻿/***************************************************************************************************
*
*\File          DelProject.aspx
*\Description   后台管理模块。用于后台删除工程。
*\Log           2012.11.27    Ver 1.0    肖骏涛
*               创建文件。
***************************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class admin_DelNote : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            int id = int.Parse(Request.QueryString["id"].ToString());
            NoteEntity ne = NoteOperation.GetNote(int.Parse(Request.QueryString["id"].ToString()));
            
            if (ne != null)
            {
                DataBase db = new DataBase();
                DataSet sql = db.ExCommand(string.Format("SELECT tb_note.id, tb_note.noteName, tb_note.upTime, tb_note.cid, tb_note.uid, tb_user.userName, tb_code.path FROM  tb_user INNER JOIN tb_note ON tb_user.id = tb_note.uid INNER JOIN tb_code ON tb_note.cid = tb_code.id  WHERE (tb_note.id ={0} ) ", id));
                string User = sql.Tables[0].Rows[0]["userName"].ToString();
                string Path = sql.Tables[0].Rows[0]["path"].ToString();
                //在表单中显示数据
                lb_NoteName.Text = ne.NoteName;
                lb_Id.Text = ne.Id.ToString();
                lb_Path.Text = Path;
                lb_User.Text = User;
                lb_UpTime.Text = ne.UpTime.ToString();
                
            }
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/admin/Notelist.aspx");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            //调用NoteOperation类里的DelNote方法，通过传入id，进行删除操作
            NoteOperation.DelNote(Request.QueryString["id"].ToString());
            SmallScript.goRedirect(Response, Session, "删除成功!", "~/admin/Notelist.aspx");
        }
        catch
        {
            //删除失败提示
            SmallScript.MessageBox(Page, "删除失败!");
        }
    }
}