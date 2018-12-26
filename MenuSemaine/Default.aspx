<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MenuSemaine.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" lang="zh">
<head>
    <title></title>
    <!-- Meta tag Keywords -->
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="keywords" content="" />
    <script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false);
function hideURLbar(){ window.scrollTo(0,1); } </script>
    <!-- Meta tag Keywords -->
    <!-- css files -->
    <link href="css/style.css" rel="stylesheet" type="text/css" media="all" />
    <!-- css files -->
    <!-- Online Fonts -->
    <link href="//fonts.googleapis.com/css?family=Share:400,400i,700,700i&amp;subset=latin-ext" rel="stylesheet" />
    <link href="//fonts.googleapis.com/css?family=Open+Sans:300,300i,400,400i,600,600i,700,700i,800,800i&amp;subset=cyrillic,cyrillic-ext,greek,greek-ext,latin-ext,vietnamese" rel="stylesheet" />
    <!-- //Online Fonts -->
</head>
<body>
    <form runat="server">
        <div class="main-w3l">
            <canvas id="myCanvas"></canvas>
            <div class="sub-w3l">
                <h1>下星期的菜</h1>

                <div class="main-agile">
                    <div class="alert-close"></div>
                    <div class="content-wthree">
                        <h2>看看下个星期吃啥</h2>
                        <div class="w3l-text">
                            <div runat="server" id="divPlatsSemaine">
                                <asp:Repeater ID="rptPlatsSemaine" runat="server" OnItemDataBound="rptPlatsSemaine_ItemDataBound">
                                    <HeaderTemplate></HeaderTemplate>
                                    <ItemTemplate>
                                        <div>
                                            <fieldset>
                                                <legend>
                                                    <asp:Literal runat="server" ID="litDayOfWeek"></asp:Literal>
                                                    <asp:Literal runat="server" ID="litTypePlat"></asp:Literal>
                                                </legend>
                                                <form>
                                                    <strong>
                                                        <asp:Literal runat="server" ID="litPlatName"></asp:Literal></strong>
                                                </form>
                                            </fieldset>
                                        </div>
                                    </ItemTemplate>
                                    <FooterTemplate></FooterTemplate>
                                </asp:Repeater>
                            </div>
                            <div class="sub-agile-w3l">
                                <img src="images/click.png" alt="image">
                            </div>
                            <div class="clear"></div>
                        </div>
                        <%--<form action="#" method="post">--%>
                        <%--<input type="submit" value="生成菜单" />--%>
                        <asp:Button ID="btnSubmit" Text="生成菜单" runat="server" OnClick="btnSubmit_Click" />
                        <%--</form>--%>
                        <div class="clear"></div>
                    </div>
                </div>
                <div class="footer-w3l">
                    <%--<p class="agileinfo">&copy; 2017 Stylish Subscribe Form. All Rights Reserved | Design by <a href="http://w3layouts.com">W3layouts</a></p>--%>
                </div>
            </div>
        </div>

        <!-- js scripts -->
        <!-- js -->
        <script type="text/javascript" src="js/jquery-2.1.4.min.js"></script>
        <!-- //js -->
        <!-- particles-JavaScript -->
        <script src="js/particles.min.js"></script>
        <script>
            window.onload = function () {
                Particles.init({
                    selector: '#myCanvas',
                    color: '#d37f41',
                    connectParticles: true,
                    minDistance: 90
                });
            };
        </script>
        <!-- //particles-JavaScript -->

        <!-- Script -->
        <script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false); function hideURLbar(){ window.scrollTo(0,1); } </script>
        <script>$(document).ready(function (c) {
    $('.alert-close').on('click', function (c) {
        $('.main-agile').fadeOut('slow', function (c) {
            $('.main-agile').remove();
        });
    });
});
        </script>
        <!-- //Script -->
        <!-- //js scripts -->
    </form>
</body>
</html>
