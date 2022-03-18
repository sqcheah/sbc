<?php
//function to restrict which server pages can be accessed based on the account type

function checkFilePermission()
{
    $commonFiles = [];
    $AllowedFiles = [];
    $noRestrictFiles = ['index.php', 'login.php', 'register.php', 'ProductSelection.php', 'ProductDetails.php', 'help.php', 'about.php', 'logout.php' . 'viewfile.php', 'downloadfile.php', 'forgotPassword.php', 'resetPassword.php', '400.php', '403.php', '408.php', '500.php'];
    if (isset($_SESSION) && !empty($_SESSION)) {
        $commonFiles = ['dashboard.php', 'changePassword.php', 'invoice.php'];
        switch ($_SESSION['acc_type']) {
            case "client": {
                    $AllowedFiles = ['updateProfile.php', 'requestQuotation.php', 'checkout.php', 'payment.php'];
                    break;
                }

            case "admin":
            case "staff": {
                    $AllowedFiles = ['addAcc.php', 'editAcc.php', 'manageAcc.php', 'editProduct.php', 'addProduct.php', 'manageProduct.php', 'editNews.php', 'addNews.php', 'manageNews.php', 'manageQuotation.php', 'viewQuotation.php', 'manageInvoice.php'];
                    break;
                }
        }
    }
    return in_array(basename($_SERVER['PHP_SELF']), array_merge($commonFiles, $AllowedFiles, $noRestrictFiles));
}

//https://phppot.com/php/user-login-session-timeout-logout-in-php/
if (isset($_SESSION["curUser"]) && isset($_SESSION['loggedIn_time'])) {
    //set redirect for timeout or invalid file permission
    $session_duration = 60 * 60; //in seconds
    $timeDiff = time() - $_SESSION['loggedIn_time'];

    if ($timeDiff < $session_duration) {
        if (basename($_SERVER['PHP_SELF']) == 'login.php' || basename($_SERVER['PHP_SELF']) == 'register.php') {
            header("Location:dashboard.php");
            exit;
        } else {
            //checkFilePermission() ? '' : header("Location:index.php");
        }
    } else {
        sleep(2);
        header("Location:logout.php?session_expired=1");
        exit;
    }
} else {

    //checkFilePermission() ? '' : header("Location:index.php");
}