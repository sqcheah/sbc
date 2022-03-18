<?php
include_once("shared/connect.php");
date_default_timezone_set('Asia/Kuala_lumpur');
//include_once('shared/userSession.php');
//function to disable navbar option if currently on the option's page
function isCurFile(...$fileName)
{
    return in_array(basename($_SERVER['PHP_SELF']), $fileName) ? 'active' : '';
}
?>

<head>
    <meta charset='UTF-8'>
    <meta name='viewport' content='width=device-width, initial-scale=1.0, shrink-to-fit=no'>
    <meta http-equiv='X-UA-Compatible' content='ie=edge'>
    <title>SBC shuttle bus</title>
    <link rel='icon' href='assets/icon.png' />

    <link rel='stylesheet' type='text/css' href='bootstrap/css/bootstrap.min.css'>
    <link rel='stylesheet' type='text/css' href='fontawesome/css/all.min.css'>

    <!-- Our Custom CSS -->
    <link rel="stylesheet" href="styleSidebar.css">
    <!-- Scrollbar Custom CSS -->
    <link rel="stylesheet"
        href="https://cdnjs.cloudflare.com/ajax/libs/malihu-custom-scrollbar-plugin/3.1.5/jquery.mCustomScrollbar.min.css">

    <link href="https://fonts.googleapis.com/css2?family=Stardos+Stencil:wght@700&display=swap" rel="stylesheet">
    <script src='bootstrap/js/jquery.min.js'></script>
    <script src='bootstrap/js/bootstrap.bundle.min.js'></script>
    <!-- jQuery Custom Scroller CDN -->
    <script
        src="https://cdnjs.cloudflare.com/ajax/libs/malihu-custom-scrollbar-plugin/3.1.5/jquery.mCustomScrollbar.concat.min.js">
    </script>
    <style>
    #sticky-footer {

        flex-shrink: none;
    }

    /*
        #navbar a {
            color: white;
        }
*/
    #navbar .nav-link,
    #navbar .nav-link a {
        color: white !important;
    }

    #navbar .active,
    #navbar .active a {
        color: #4A86E8 !important;
        ;
    }

    .navbar-brand {
        font-family: "Stardos Stencil";
        color: #4A86E8 !important;
    }
    </style>
</head>

<body class="d-flex flex-column">

    <div class="wrapper">
        <!-- Sidebar  -->
        <nav id="sidebar">
            <div class="sidebar-header">
                <h3>SBC</h3>
            </div>

            <ul class="list-unstyled components">
                <!--
                <p>Dummy Heading</p>
                <li class="active">
                    <a href="#homeSubmenu" data-toggle="collapse" aria-expanded="false" class="dropdown-toggle">Home</a>
                    <ul class="collapse list-unstyled" id="homeSubmenu">

                        <li>
                            <a href="#">Home 2</a>
                        </li>
                        <li>
                            <a href="#">Home 3</a>
                        </li>
                    </ul>
                </li>

                <li>
                    <a href="#">About</a>
                </li>
                <li>
                    <a href="#">Portfolio</a>
                </li>
-->
                <?php
                if (isset($_SESSION['curUser'])) {
                    echo '
                    <li>
                    <a href="profile.php" class="' . (isCurFile('profile.php') ? "active" : "")  . '">Profile</a>
                </li>
                    <li>
                    <a href="listDriver.php" class="' . (isCurFile('listDriver.php') ? "active" : "") . '">Driver List</a>
                </li>
                    <li>
                    <a href="listBooking.php" class="' . (isCurFile('listBooking.php') ? "active" : "")  . '">Booking List</a>
                </li>
                    <li>
                    <a href="logout.php">Logout</a>
                </li>
                        ';
                } else {
                    echo '
                    <li>
                    <a href="index.php"  class="' . (isCurFile('index.php') ? "active" : "")  . '">Home</a>
                </li>
                <li>
                <a href="about.php"  class="' . (isCurFile('about.php') ? "active" : "")  . '">About Us</a>
            </li>
                    ';
                }
                ?>
            </ul>

        </nav>

        <!-- Page Content  -->
        <div id="content">

            <nav class="navbar navbar-expand navbar-light bg-light">
                <button type="button" id="sidebarCollapse" class="btn btn-info">
                    <i class="navbar-toggler-icon"></i>

                </button>
                <ul class="nav navbar-nav ml-auto">
                    <?php
                    if (isset($_SESSION['curUser'])) {

                        echo '
                    <li class="nav-item dropdown">
                        <a class="nav-link " href="#" id="alertsDropdown" role="button" data-toggle="dropdown"
                            aria-haspopup="true" aria-expanded="false">
                            <i class="fas fa-bell"></i>
                            <span class="badge badge-danger" id="notifCount" ></span>
                        </a>
                        <div class="dropdown-menu shadow dropdown-menu-right" id="notificationdropdown"
                            aria-labelledby="alertsDropdown">
                     
                            <div class="d-flex justify-content-between">
                            <div class=" dropdown-header">
                                Notifications 
                                </div>
                            
                                <a class="d-inline dropdown-header " id="notifBtn" style="cursor:pointer">Mark All Read</a>
                                </diV>
                       
                        
                          
                         
                            <div class="dropdown-divider"></div>
                            <div style="overflow-y:scroll;max-height:10rem;" id="notifView">
            
                            </div>
                            <div class="dropdown-divider"></div>
                            <a class="dropdown-item text-center small text-black-50 text-wrap" href="listNotification.php">Show All
                                Notification</a>
                        </div>
                    </li>';
                    } else {
                        echo '
                        <li class="nav-item">
                        <a class="nav-link" href="login.php">Login</a>
                    </li>
                        ';
                    }
                    ?>
                </ul>

            </nav>