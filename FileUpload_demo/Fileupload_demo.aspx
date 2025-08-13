<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Fileupload_demo.aspx.cs" Inherits="FileUpload_demo.Fileupload_demo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <table style="width: 100%;">
                <tr>
                    <td class="style1"></td>
                    <td></td>
                    <td></td>
                </tr>
                <tr>
                    <td class="style1">
                        <asp:FileUpload ID="FileUpload1" runat="server" Width="211px" />
                    </td>
                    <td>
                        <asp:FileUpload ID="FileUpload2" runat="server" />
                    </td>
                    <td>
                        <asp:FileUpload ID="FileUpload3" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td class="style1">
                        <asp:Label ID="Label1" runat="server"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label2" runat="server"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label3" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="style1">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Upload" />
                    </td>
                    <td>
                        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Upload" />
                    </td>
                    <td>
                        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Upload" />
                    </td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
