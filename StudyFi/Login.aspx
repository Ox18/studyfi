<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="StudyFi.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">

<!------ Include the above in your HEAD tag ---------->
    <nav class="navbar navbar-expand-lg navbar-light bg-light">
  <a class="navbar-brand" href="#">Study NOW</a>
  <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNavDropdown" aria-controls="navbarNavDropdown" aria-expanded="false" aria-label="Toggle navigation">
    <span class="navbar-toggler-icon"></span>
  </button>
  <div class="collapse navbar-collapse form-inline my-2 my-lg-0" id="navbarNavDropdown">
    <ul class="navbar-nav form-inline my-2 my-lg-0">
      <li class="nav-item active">
        <a class="nav-link" href="#">Home <span class="sr-only">(current)</span></a>
      </li>
      <li class="nav-item">
        <a class="nav-link" href="#">Features</a>
      </li>
      <li class="nav-item">
        <a class="nav-link" href="#">Pricing</a>
      </li>
      <li class="nav-item dropdown">
        <a class="nav-link dropdown-toggle" href="#" id="navbarDropdownMenuLink" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
          Iniciar sesión
        </a>
        <div class="dropdown-menu" aria-labelledby="navbarDropdownMenuLink">
          <a class="dropdown-item" href="/login.aspx?type=student">Estudiante</a>
          <a class="dropdown-item" href="/login.aspx?type=teacher">Profesor</a>
          <a class="dropdown-item" href="/login.aspx?type=admin">Gerencia</a>
        </div>
      </li>
    </ul>
  </div>
</nav>
<!-- no additional media querie or css is required -->
<div class="container">
        <div class="row justify-content-center align-items-center" style="height:100vh">
            <div class="col-4">
                <div class="card">
                    <div class="card-body">
                        <h3 class="align-content-center text-center">Iniciar sesión como 

                            <asp:Label ID="typeAccount" runat="server" Text="" />
                        </h3>
                        <form id="formulario_login"  autocomplete="off" runat="server">
                            <div class="form-group">
                                <asp:Label runat="server" Text="Username"></asp:Label>
                                <asp:TextBox CssClass="form-control" ID="txtUsername" runat="server" type="email" required />
                            </div>
                            <div class="form-group">
                                <asp:Label runat="server" Text="Username"></asp:Label>
                                <asp:TextBox CssClass="form-control" ID="txtPassword" runat="server" type="password" />
                            </div>
                            <asp:Label runat="server" Id="txtAlert" CssClass="alert alert-danger" Visible="false"></asp:Label>
                            <br />
                            <asp:Button CssClass="btn btn-primary" runat="server" Text="Iniciar sesión" OnClick="Unnamed3_Click" />
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </div>
<script src="https://code.jquery.com/jquery-3.2.1.slim.min.js" integrity="sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN" crossorigin="anonymous"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js" integrity="sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q" crossorigin="anonymous"></script>
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js" integrity="sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl" crossorigin="anonymous"></script>
</body>
</html>
