﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
///ProjectOperation 的摘要说明
/// </summary>
public class ProjectOperation
{
	public ProjectOperation()
	{
		//
		//TODO: 在此处添加构造函数逻辑
		//
	}
    public static bool AddProject(ProjectEntity pe){
        DataBase db = new DataBase();
        try
        {
            string sql =string.Format( "INSERT INTO tb_project ( projectName, description, upTime, tid, uid)VALUES  ( '{0}', '{1}','{2}', {3}, {4})",pe.ProjectName,pe.Description,pe.UpTime,pe.Tid,pe.Uid);
            db.ExCommandNoBack(sql);
            return true;
        }
        catch
        {
            return false;
        }
    }
}