<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="DGApp.Register" %>

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
				<header>Registration form</header>
				
				<fieldset>
                    <section>
						<label class="input">
							<i class="icon-append icon-user"></i>
							<input type="text" placeholder="Username" id="txtUsername" runat="server">
							<b class="tooltip tooltip-bottom-right">Only latin characters and numbers</b>
						</label>
					</section>		
                    <section >
						<label class="input">
                                <i class="icon-append icon-user"></i>
								<input type="text" placeholder="First name" id="txtFirstname" runat="server">
						</label>
					</section>
					<section >
						<label class="input">
                                <i class="icon-append icon-user"></i>
								<input type="text" placeholder="Last name" id="txtLastname" runat="server">
						</label>
					</section>					
								
					<section>
						<label class="input">
							<i class="icon-append icon-envelope-alt"></i>
							<input type="text" placeholder="Email address" id="txtEmail" runat="server">
							<b class="tooltip tooltip-bottom-right">Needed to verify your account</b>
						</label>
					</section>
                    <section>
						<label class="input">
							<i class="icon-append icon-phone"></i>
							<input type="text" placeholder="Phone Number" id="txtPhone" runat="server">
							<b class="tooltip tooltip-bottom-right">Needed to verify your account</b>
						</label>
					</section>					
					<section>
						<label class="input">
							<i class="icon-append icon-lock"></i>
							<input type="password" placeholder="Password" id="txtPassword" runat="server">
							<b class="tooltip tooltip-bottom-right">Only latin characters and numbers</b>
						</label>
					</section>
					
					<section>
						<label class="input">
							<i class="icon-append icon-lock"></i>
							<input type="password" placeholder="Confirm password" id="txtConfirmPassword" runat="server">
							<b class="tooltip tooltip-bottom-right">Only latin characters and numbers</b>
						</label>
					</section>
				</fieldset>
					
				
                <fieldset>
                    <div class="row">
						<section class="col col-6">
							<label class="input">
								<input type="text" placeholder="Pet name" id="txtPetname" runat="server">
							</label>
						</section>
					</div>

					 <section>
						<label class="select" >
							<select id="lblselectpetCategory" runat ="server">
								<option value="0" selected disabled>Category</option>
        						<option value="1">Dog</option>
								<option value="2">Cat</option>
								<option value="3">Bird</option>
                                <option value="4">Fish</option>
								<option value="5">Mammal</option>
								<option value="3">Other</option>
							</select>
							<i></i>
						</label>
					</section>
                    <div class="row">
                    <section class="col col-6">
							<label class="input">
								<input type="text" placeholder="Breed" id="txtBreed" runat="server">
							</label>
						</section>
                        <section class="col col-6">
							<label class="input">
								<input type="text" placeholder="Date Born" id="txtDateBorn" runat="server">
							</label>
						</section>
                        </div>
					<section>
						<label class="select" >
							<select id="lblselectpetGender" runat ="server">
								<option value="0" selected disabled>Pet Gender</option>
								<option value="1">Male</option>
								<option value="2">Female</option>
								<option value="3">Other</option>
							</select>
							<i></i>
						</label>
					</section>
					<section>
						<label class="checkbox"><input type="checkbox" name="checkbox"><i></i>I agree to the Terms of Service</label>						
					</section>
				</fieldset>
				<footer>
					<%--<button type="submit" class="button">Submit</button>--%>
                    <asp:Button ID="BtnRegister" runat="server" OnClick="Register_Click" CssClass="button" Text="Submit" />
                    
                    <label id="lblStatus" runat ="server" style="color:red" visible ="false" ></label>
				</footer>
			</form>
			
		</div>
	</body>
</html>
