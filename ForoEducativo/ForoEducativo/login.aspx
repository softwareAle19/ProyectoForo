<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="ForoEducativo.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="Sources/css/styleLogin.css" rel="stylesheet" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-MrcW6ZMFYlzcLA8Nl+NtUVF0sA7MsXsP1UyJoMp4YLEuNSfAP+JcXn/tWtIaxVXM" crossorigin="anonymous"></script>
</head>
<body >
    <form id="form1" runat="server">
        <div class="contenedor">
            <div class="div-1">
                <div class="container">
                    <center>
                        <h3 class="titulo">BIENVENIDO</h3>
                    </center>
                    <div id="contenedorForm" class="mb-3">
                        <label for="exampleInputEmail1" class="form-label">Usuario</label>
                        <asp:TextBox type="email" ID="txtEmail" runat="server" class="inputIngreso" aria-describedby="emailHelp" required></asp:TextBox>

                    </div>
                    <div class="mb-3">
                        <label for="exampleInputPassword1" class="form-label">Contraseña</label>
                        <asp:TextBox type="password" ID="txtPass" runat="server" class="inputIngreso" required></asp:TextBox>

                    </div>
                    <a class="olvidoContraseña">Olvide mi contraseña</a>
                    <asp:Button ID="btnIngresar" runat="server" OnClick="btnIngresar_Click" Text="Ingresar" Class="btnIngresar" />

                </div>

            </div>

        <div class="div-2">
            <img class="imagenLogin"   src="Sources/img/imagenLogin.jpeg" />

        </div>

        </div>

    </form>
</body>
</html>
