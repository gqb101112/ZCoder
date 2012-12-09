﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            height: 60px;
        }
    </style>
<link href="layout.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div style="background-color:White;">
    <table class="style1">
        <tr>
            <td colspan="2">
               <h3>用户登陆</h3></td>
            <td width="40%">
                &nbsp;</td>
        </tr>
        <tr>
            <td align="right"  colspan="2">
                <hr style="100%" />
            </td>
            <td width="40%">
                &nbsp;</td>
        </tr>
        <tr>
            <td align="right" width="110px" class="style2" dir="ltr">
                用户名：</td>
            <td class="style2">
                &nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="tb_UserName" runat="server" CssClass="zTextBox"></asp:TextBox>
            </td>
            <td width="40%" class="style2">
                </td>
        </tr>
        <tr>
            <td align="right" width="110px">
                密码：</td>
            <td height="60">
                &nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="tb_Password" runat="server" TextMode="Password" 
                    CssClass="zTextBox"></asp:TextBox>
            </td>
            <td width="40%">
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td height="60">
                &nbsp;&nbsp;
                <asp:CheckBox ID="CheckBox1" runat="server" Text="一周内免登陆" 
                    oncheckedchanged="CheckBox1_CheckedChanged" />
            </td>
            <td width="40%">
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td height="60">
                <asp:Button ID="Log" runat="server" CssClass="zbutton" Text="登陆" 
                    onclick="Log_Click" />
            </td>
            <td width="40%">
                &nbsp;</td>
        </tr>
    </table>
    </div>
</asp:Content>

