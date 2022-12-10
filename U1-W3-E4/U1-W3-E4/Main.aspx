<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="U1_W3_E4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <title>Progetto Settimanale</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container" >
            <asp:Label ID="Errore" runat="server" Text=""></asp:Label>
            <div class="row bg-black">
                <h1 class="text-center text-white">Sala Acquisti</h1>
            </div>
            <br />
            <div class="row">
                <asp:Repeater ID="Repeater1" runat="server" ItemType="U1_W3_E4.Item">
                    <ItemTemplate>                
                        <div class=" col-3 " >
                            <div class="card">
                                <div class="p-2">
                                    <asp:Image ID="Image1" runat="server" />
                                </div>
                                <div>
                                    <asp:Label ID="Name" runat="server" Text=""></asp:Label>
                                    <p><%# Item. %></p>
                                    <br />
                                    <asp:LinkButton ID="LinkButton1" runat="server">Vuoi Saperne Di Più</asp:LinkButton>
                                </div>
                            </div>
                        </div>                  
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
    </form>
</body>
</html>
