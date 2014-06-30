<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="DGApp.Login" %>

<!DOCTYPE html>

<html>
	<head>
		<title>Dog Grooming App</title>
		
		<meta charset="utf-8">
		<meta name="viewport" content="width=device-width, initial-scale=1.0, minimum-scale=1.0">
		
		<link rel="stylesheet" href="css/demo.css">
		<link rel="stylesheet" href="css/sky-forms.css">
		<!--[if lt IE 9]>
			<link rel="stylesheet" href="css/sky-forms-ie8.css">
		<![endif]-->
		
		<!--[if lt IE 10]>
			<script src="http://ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js"></script>
			<script src="js/jquery.placeholder.min.js"></script>
		<![endif]-->		
		<!--[if lt IE 9]>
			<script src="http://html5shim.googlecode.com/svn/trunk/html5.js"></script>
			<script src="js/sky-forms-ie8.js"></script>
		<![endif]-->
	</head>
	<body class="bg-cyan">
		<div class="body body-s">
		
			<form action="" class="sky-form" runat="server">
				<header>Login form</header>
				
				<fieldset>					
					<section>
						<div class="row">
							<label class="label col col-4">Username</label>
							<div class="col col-8">
								<label class="input">
									<i class="icon-append icon-user"></i>
									<input type="email" id="txtUsername" runat="server">
								</label>
							</div>
						</div>
					</section>
					
					<section>
						<div class="row">
							<label class="label col col-4">Password</label>
							<div class="col col-8">
								<label class="input">
									<i class="icon-append icon-lock"></i>
									<input type="password" id="txtPassword" runat="server">
								</label>
								<!--<div class="note"><a href="#">Forgot password?</a></div>-->
							</div>
						</div>
					</section>
					
					<section>
						<div class="row">
							<div class="col col-4"></div>
							<div class="col col-8">
								<label class="checkbox"><input type="checkbox" name="checkbox-inline" checked><i></i>Keep me logged in</label>
							</div>
						</div>
					</section>
				</fieldset>
				<footer>
					<%--<button type="submit" class="button" >Log in</button>--%>
                    <asp:Button ID="BtnLogin" runat="server" OnClick="Login_Click" CssClass="button" Text="Log in" />
					<a href="/Register.aspx" class="button button-secondary">Register</a>   
                    
                    <label id="lblStatus" runat ="server" style="color:red" visible ="false" ></label>                 
				</footer>
                
			</form>
			
		</div>
	</body>
</html>