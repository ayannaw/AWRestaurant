<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="AWRestaurant.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/font-awesome.css" rel="stylesheet" />
    <link href="MainStyle.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/jquery-3.0.0.min.js"></script>
    <script src="Scripts/popper.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="col-md-6 mx-auto">
                    <div class="card">
                        <div class="card-body">
                            <div class="row">
                                <div class="col">
                                    <center>
                                        <img src="Images/user-login.png" />
                                    </center>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col">
                                 <center>
                                    <h4>User Login</h4>
                                </center>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col">
                                    <div class="form-group">
                                        <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" placeholder="Email"></asp:TextBox>
                                    </div>

                                    <div class="form-group">
                                        <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" placeholder="Password" TextMode="Password"></asp:TextBox>
                                    </div>

                                    <div class="form-group">
                                        <asp:Button ID="btnLogin" runat="server" Text="Login" CssClass="btn btn-success btn-block" OnClick="btnLogin_Click"/>
                                    </div>

                                    <div class="form-group">
                                        <a href="CreateAccount.aspx"> 
                                            <input id="btnCreateAccount" type="button" value="Create Account" class="btn btn-info btn-block"/>
                                        </a>
                                    </div>

                                </div>
                            </div>
                        </div>
                    </div>


                </div>

            </div>

        </div>
    </form>
</body>
</html>
