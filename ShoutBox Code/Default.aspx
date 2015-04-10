<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    
    <!---- Shout Box stuff below ------>
    
    <div id = "shoutBox">
        
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>

        <p>The Chat Box</p>

        <asp:UpdatePanel ID="ShoutBoxPanel1" runat="server">
        
            <ContentTemplate>

               <asp:Label ID="lblShoutBox" runat="server"></asp:Label> 

               <asp:Timer ID="Timer1" runat="server" Interval="5000"></asp:Timer>

            </ContentTemplate>

            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="btnAddShout" EventName="Click" />
            </Triggers>        
        
        </asp:UpdatePanel>
    
    <asp:UpdatePanel ID="ShoutBoxPanel2" runat="server" UpdateMode="Conditional">
    
        <ContentTemplate>
        
        <p class="label">Name: </p>
        <p class="entry">
            <asp:TextBox ID="txtUserName" runat="server" MaxLength="15" Width="100px"></asp:TextBox>     
        </p>

        <p class="label">Shout: </p>
        <p class="entry">
            <asp:TextBox ID="txtShout" runat="server" MaxLength="255" Width="220"></asp:TextBox>     
        </p>

        <asp:Button ID="btnAddShout" runat="server" Text="Add Shout" 
                onclick="btnAddShout_CLick" />
        <asp:UpdateProgress ID="UpdateProgress1" runat="server" DynamicLayout="false">
        
            <ProgressTemplate>
            
                <!-- Update imagey spinny thing goes here... it's a bit gimmicky though -->
            
            </ProgressTemplate>

        </asp:UpdateProgress>

        </ContentTemplate>
    
    </asp:UpdatePanel>

    
    </div>
     <!------------------------------------->

    </form>
</body>
</html>
