<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TinhToanCB.aspx.cs" Inherits="TinhToan.TinhToanCB" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
      <link href="css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="text-center">
           <h1 class="text-lowercase" >Bài Tập Đơn Gĩan</h1>
             <div class="" style="margin-top: 117px">
                       Nhập Số 1:<asp:TextBox ID="txt1" runat="server" style="width: 128px"></asp:TextBox>  
                 </br>
                 Nhập Số 2:<asp:TextBox ID="txt2" runat="server" style="width: 128px"></asp:TextBox> 
                   </br>
                 
                 <asp:Button CssClass="btn btn-info " ID="btnnhap" runat="server" Text="Trừ" OnClick="btnnhap_Click"  />
                 
                 <asp:Button CssClass="btn btn-info  ml-2" ID="Button1" runat="server" Text="Nhân" OnClick="Button1_Click"  />
                 
                 <asp:Button CssClass="btn btn-info  ml-2" ID="Button2" runat="server" Text="Chia" OnClick="Button2_Click"  />
                 
                 <asp:Button CssClass="btn btn-info  ml-2" ID="Button3" runat="server" Text="Cộng" OnClick="Button3_Click" />
                    
            </div>
            Kết quả: <asp:Label ID="lblhien" runat="server" Text=""></asp:Label>
        </div>
        
    </form>
    
</body>
</html>

