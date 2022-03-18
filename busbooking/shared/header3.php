<?php
include("shared/connect.php");
date_default_timezone_set('Asia/Kuala_lumpur');
//include('shared/userSession.php');
//function to disable navbar option if currently on the option's page
function isCurFile(...$fileName)
{
    return in_array(basename($_SERVER['PHP_SELF']), $fileName) ? 'active' : '';
}
?>
<!DOCTYPE html>
<html lang='en'>

<head>
    <meta charset='UTF-8'>
    <meta name='viewport' content='width=device-width, initial-scale=1.0, shrink-to-fit=no'>
    <meta http-equiv='X-UA-Compatible' content='ie=edge'>
    <title>SBC shuttle bus</title>
    <link rel='icon' href='assets/icon.png' />

    <link rel='stylesheet' type='text/css' href='bootstrap/css/bootstrap.min.css'>
    <link rel='stylesheet' type='text/css' href='fontawesome/css/all.min.css'>

    <link href="https://fonts.googleapis.com/css2?family=Stardos+Stencil:wght@700&display=swap" rel="stylesheet">
    <style>
    html,
    body {
        height: 100%;
    }

    #page-content {
        flex: 1 0 auto;
    }

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
    <div id="page-content">
        <?php
        ///https://startbootstrap.com/snippets/navbar-logo/
        /***
        echo "
    <ul class='nav nav-tabs justify-content-center d-print-none'>
    <li class='nav-item mx-3'>
    <a class='nav-link " . isCurFile(' index.php') . "' href='index.php'>  <img src='assets/icon.png' style='height:25px'></a>
    </li>
        <li class='nav-item mx-1'>
            <a class='nav-link " . isCurFile(' index.php') . "' href='index.php'>Home</a>
        </li>
        <li class='nav-item mx-1'>
            <a class='nav-link " . isCurFile('#') . "' href='#'>Products</a>
        </li>
        <li class='nav-item mx-1'>
            <a class='nav-link " . isCurFile('#') . "' href='#'>About</a>
        </li>
        <li class='nav-item mx-1'>
            <a class='nav-link " . isCurFile('#') . "' href='#'>Help</a>
        </li>
    
        <span style='flex: 1 1 auto'></span>
        <li class='nav-item mx-1'>
        ";
        if (isset($_SESSION['curUser'])) {
            echo "   <a class='nav-link ' href='logout.php'><i class='fas fa-sign-out-alt'></i>Logout</a>";
        } else {
            echo "   <a class='nav-link ' href='login.php'>Login/Register</a>";
        }
        echo "      </li>
    </ul>
    ";
      <img src="assets/icon.png" style="height:50px">
         */
        echo ' <nav id="navbar" class="navbar navbar-expand-lg navbar-dark bg-dark d-print-none" style="z-index: 100;">
            <a class="navbar-brand" href="index.php">
            MY LITTLE BUS
            </a>
            <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse" id="navbarSupportedContent">
                <ul class="navbar-nav mr-auto">
                    <li class="nav-item ' . isCurFile('index.php') . '">
                        <a class="nav-link" href="index.php"><i class="fas fa-home"></i> Home </a>
                    </li>
                ';
        if (isset($_SESSION['curUser'])) {
            echo '
                   <li class="nav-item ' . isCurFile('dashboard.php') . '">
                   <a class="nav-link" href="dashboard.php"><i class="fas fa-chart-line"></i> Dashboard </a>
               </li>
                   ';
            if ($_SESSION['acc_type'] != 'client') {
                echo '
            <li class="nav-item dropdown">
                        <a class="nav-link dropdown-toggle ' . isCurFile("manageAcc.php", "manageInvoice.php", "manageProduct.php", "manageNews.php") . '" href="#" id="navbarDropdown" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                            <i class="fas fa-tools"></i> Management
                        </a>
                        <div class="dropdown-menu dropdown-menu-right" aria-labelledby="navbarDropdown">
                        <a class="dropdown-item ' . isCurFile("manageAcc.php") . '" href="manageAcc.php">Account</a>
                        <a class="dropdown-item ' . isCurFile("manageNews.php") . '" href="manageNews.php">News</a>
                        <a class="dropdown-item ' . isCurFile("manageProduct.php") . '" href="manageProduct.php">Product</a>
                        <a class="dropdown-item ' . isCurFile("manageQuotation.php") . '" href="manageQuotation.php">Quotation</a>
                        <a class="dropdown-item ' . isCurFile("manageInvoice.php") . '" href="manageInvoice.php">Invoice</a>
                        </div>
                        </li>
            ';
            }
        }
        echo '  <li class="nav-item ' . isCurFile('ProductSelection.php') . '">
                        <a class="nav-link" href="ProductSelection.php"><i class="fas fa-shopping-cart "></i> Products</a>
                    </li>
                    <li class="nav-item ' . isCurFile('about.php') . '">
                        <a class="nav-link" href="about.php"><i class="fas fa-address-card"></i> About</a>
                    </li>
                    <li class="nav-item ' . isCurFile('help.php') . '">
                        <a class="nav-link" href="help.php"><i class="fas fa-info-circle"></i> Help</a>
                    </li>
                </ul>
                <ul id="navbar" class="navbar-nav ml-auto">
                ';
        if (isset($_SESSION['curUser'])) {
            echo '  
                    <li class="nav-item dropdown">
                        <a class="nav-link dropdown-toggle ' . isCurFile("updateProfile.php", "changePassword.php") . '" href="#" id="navbarDropdown" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                            <i class="fas fa-user"></i> Welcome, ' . $_SESSION['curUser'] . '
                        </a>
                        <div class="dropdown-menu dropdown-menu-right" aria-labelledby="navbarDropdown">
                        ';
            if ($_SESSION['acc_type'] == 'client') {
                echo '             <a class="dropdown-item ' . isCurFile("updateProfile.php") . '" href="updateProfile.php">Update profile</a>';
            }
            echo '    <a class="dropdown-item ' . isCurFile("changePassword.php") . '" href="changePassword.php">Change Password</a>
                            <div class="dropdown-divider"></div>
                            <a class="dropdown-item" href="logout.php"><i class="fas fa-sign-out-alt"></i>Logout</a>
                        </div>
                    </li>
                    ';
        } else {
            echo "  <li class='nav-item mx-1'>  
            <span class='nav-link'>
                    <a href='login.php'>Login</a> / <a href='register.php'>Register</a>
                    </span>
                    </li>";
        }
        echo '
                </ul>
            </div>
        </nav>
    ';  ?>