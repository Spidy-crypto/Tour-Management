<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="Client.Registration" %>

<!DOCTYPE html>
<html>

<head>
    <title>Registration</title>
    <link rel="stylesheet" type="text/css" href="css/reg.css">
    <style type="text/css">
    body {
        background-image: url("images/bg.jpg");
        background-size: cover;

    }
    .reg {
    position: absolute;
    top: 51%;
    left: 50%;
    transform: translate(-50%, -50%);
    box-sizing: border-box;
    width: 430px;
    height: 590px;
    padding: 20px 40px;
    border-radius: 50px;
    background: rgba(255, 255, 255, 0.95);
    box-shadow: 1px, 0px, 5px, lightgray;
}

h2 {
    text-align: center;
    color: black;
}

.reg label {
    padding: 0;
    font-weight: bold;
    color: rgb(0, 0, 0);
}

.reg input {
    width: 100%;
    margin-bottom: 10px;
}

.reg input[type="text"],
.reg input[type="email"],
.reg input[type="password"] {
    border: none;
    outline: none;
    height: 40px;
    font size: 16px;
    border-bottom: 1px solid black;
    color: black;
    background: transparent;
}

.reg input[type="submit"] {
    border: none;
    outline: none;
    border-radius: 20px;
    height: 40px;
    font-size: 16px;
    background: rgb(255, 38, 126);
    cursor: pointer;
    margin-top: 15px;
}

::placeholder {
    color: rgba(0, 0, 0, 0.4);
}

.reg a:hover {
    text-decoration: none;
    color: red;
}

.reg a {
    margin-left: 30px;
    margin-top: 30px;
    font-weight: bold;
    font-size: 14px;
    text-decoration: none;
    color: black;
}
    </style>
</head>

<body>
    <div class="reg">
        <h2>Create New Account</h2>
        <form id="regform" runat="server">
            
            <label for="firstname">FirstName</label><br>
            <input type="text" name="firstname" id="firstname" required runat="server" placeholder="Enter FirstName" ><br>
            <label for="lastname">LastName</label><br>
            <input type="text" name="lastname" id="lastname" required runat="server" placeholder="Enter LastName" ><br>
            <label for="email">EmailId</label><br>
            <input type="email" name="email" id="email" required placeholder="Enter email" runat="server"><br>
            <label for="password">Password</label><br>
            <input type="password" name="password" id="password" required runat="server" placeholder="Enter Password"><br>
            <label for="repassword">Confirm Password</label><br>
            <input type="password" name="repassword" id="repassword" required runat="server" placeholder="Confirm password"><br>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        </form>
        <footer>
            <a href="login.html">Already have an account ?</a>
        </footer>
    </div>
    <script src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>
    <script src="js/apply.js"></script>
</body>

</html>