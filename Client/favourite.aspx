<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="favourite.aspx.cs" Inherits="Client.favourite" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>Destinations</title>
<meta charset="utf-8">
<meta http-equiv="X-UA-Compatible" content="IE=edge">
<meta name="description" content="Travello template project">
<meta name="viewport" content="width=device-width, initial-scale=1">
<link rel="stylesheet" type="text/css" href="styles/bootstrap4/bootstrap.min.css">
<link href="plugins/font-awesome-4.7.0/css/font-awesome.min.css" rel="stylesheet" type="text/css">
<link rel="stylesheet" type="text/css" href="plugins/OwlCarousel2-2.2.1/owl.carousel.css">
<link rel="stylesheet" type="text/css" href="plugins/OwlCarousel2-2.2.1/owl.theme.default.css">
<link rel="stylesheet" type="text/css" href="plugins/OwlCarousel2-2.2.1/animate.css">
<link rel="stylesheet" type="text/css" href="styles/destinations.css">
<link rel="stylesheet" type="text/css" href="styles/destinations_responsive.css">
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>

			<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            <asp:Repeater ID="Repeater1" runat="server">
							<ItemTemplate>
								


								<div class="destination item">
									<div class="destination_image">
										<img src="images/<%# Eval("imagepath") %>" alt="">
										<div class="spec_offer text-center"><a href="#">Special Offer</a></div>
									</div>
									<div class="destination_content">
										<div class="destination_title"><a href="#"><%# Eval("placeid") %></a></div>
										
										<div class="buttons">
									
												<div class="buttons_container d-flex flex-row align-items-start justify-content-start">
													<div class="button" runat="server">
														</div>
                                        
												</div>
									
										</div>
										
                           

										<div class="destination_subtitle"><p><%# Eval("desc") %></p></div>
										<div class="destination_price">From <%# Eval("price") %></div>
										<div class="destination_list">
											<ul>
												<li>5 Stars Hotel</li>
												<li>All Inclusive</li>
												<li>Flight tickets included</li>
												<li>Guided visits</li>
											</ul>
										</div>
									</div>
								</div>
							</ItemTemplate>

                        </asp:Repeater>
        </div>
    </form>

	<script src="js/jquery-3.2.1.min.js"></script>
<script src="styles/bootstrap4/popper.js"></script>
<script src="styles/bootstrap4/bootstrap.min.js"></script>
<script src="plugins/OwlCarousel2-2.2.1/owl.carousel.js"></script>
<script src="plugins/easing/easing.js"></script>
<script src="plugins/Isotope/isotope.pkgd.min.js"></script>
<script src="plugins/parallax-js-master/parallax.min.js"></script>
<script src="js/destinations.js"></script>
</body>
</html>
