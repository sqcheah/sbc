<?php
include_once("shared/connect.php");

if (isset($_COOKIE['rememberusername']) && !empty($_COOKIE['rememberusername'])) {
    $cookie = json_decode($_COOKIE["rememberusername"]);
}

//validation
$message = "";
if (isset($_POST) && !empty($_POST)) {
    $postUsername = mysqli_real_escape_string($conn, $_POST["username"]);
    $result = getUser($conn, $postUsername);

    if (!$result || mysqli_num_rows($result) == 0) {

        $message = "<div class='alert alert-danger'>
        Invalid username or password!
        </div>";
    } else {
        $row = mysqli_fetch_assoc($result);
        $dbpassword = $row["password"];
        $postPassword = $_POST["password"];
        if (password_verify($postPassword, $dbpassword)) {

            if ($row['status'] != "ACTIVE") {
                $message =  "<div class='alert alert-danger'>
                Invalid username or password!
                </div>";
            } else {
                if (!isset($_POST['rememberusername'])) {
                    if (isset($_COOKIE['rememberusername']) && !empty($_COOKIE['rememberusername'])) {
                        setcookie("rememberusername", "", $time - (10 * 365 * 24 * 60 * 60));
                        // unset($_COOKIE['rememberusername']);
                    }
                } else {
                    if (!isset($_COOKIE['rememberusername'])) {
                        $expiry = time() + (10 * 365 * 24 * 60 * 60);
                        $cookie =  array('username' => $postUsername, "expiry" => $expiry);
                        setcookie("rememberusername", json_encode($cookie), $expiry);
                    }
                }
                if ($cookie->username != $_POST['username']) {
                    $expiry = time() + (10 * 365 * 24 * 60 * 60);
                    $cookie =  array('username' => $postUsername, "expiry" => $expiry);
                    setcookie("rememberusername", json_encode($cookie), $expiry);
                }
                $_SESSION["curUser"] = $row['username'];
                $_SESSION['acc_type'] = $row['acc_type'];
                $_SESSION['providerID'] = $row['provider'];
                $_SESSION['loggedIn_time'] = time();
                header("Location:profile.php");
                exit();

                $message = "<div class='alert alert-success'>
                Successfully login! Redirecting...
                </div>";
            }

            $_SESSION["curUser"] = $row['username'];
            $_SESSION['acc_type'] = $row['acc_type'];
            $_SESSION['providerID'] = $row['provider'];
            $_SESSION['loggedIn_time'] = time();
            header("Location:dashboard.php");
            exit();
            $message = "<div class='alert alert-success'>Successfully login! Redirecting...</div>";
        } else {
            var_dump($_POST);
            $message =  "<div class='alert alert-danger'>
            Invalid username or password!
            </div>";
        }
    }
}
include_once("shared/header.php");
function getUser($conn, $postUsername)
{

    return query($conn, "SELECT * FROM user_account WHERE lower(username)='" . strtolower($postUsername) . "' AND `acc_type`='PROVIDER' AND NOT `provider`=1 LIMIT 0,1");
}
?>

<div class="container">
    <h1 class="text-center py-2">Login</h1>
    <div class="card mx-auto">
        <div class="card-body">
            <img class="img-fluid mx-auto d-block py-2" src="assets/logo.png" alt="logo">
            <div class="px-5">
                <?php
                //if redirected from session expiry
                if (isset($_GET['session_expired'])) {
                    echo "<div class='alert alert-danger mx-auto' >
            Session expired. Please login again!
            </div>";
                }
                ?>
                <form action='<?php echo basename($_SERVER['PHP_SELF']) ?>' method="POST" class='needs-validation'
                    novalidate>
                    <div class="form-group">
                        <label for="uname"><b>Username</b></label>
                        <input type="text" class="form-control" placeholder="Enter Username" name="username"
                            value='<?php echo empty($cookie) ? '' : $cookie->username ?>' required>
                        <div class="invalid-feedback">
                            Please enter username
                        </div>
                    </div>
                    <div class="form-group">

                        <label for="psw"><b>Password</b></label>
                        <div class="input-group">
                            <input type="password" class="form-control pwd1" placeholder="Enter Password"
                                name="password" required>
                            <div class="input-group-append">
                                <button class="btn btn-outline-secondary reveal1" type="button"><i
                                        class="fas fa-eye-slash"></i></button>
                            </div>
                            <div class="invalid-feedback">
                                Please enter password.
                            </div>
                        </div>

                    </div>
                    <?php echo $message ?>

                    <div>
                        <!-- Remember me -->
                        <div class="custom-control custom-checkbox ">
                            <input type="checkbox" class="custom-control-input" id="rememberusername"
                                name="rememberusername" <?php echo (empty($cookie) ? "" : "checked") ?>>
                            <label class="custom-control-label" for="rememberusername">Remember username</label>
                        </div>
                    </div>

                    <div class="text-center p-3">
                        <input class="btn btn-primary mb-3" type="submit" value="Login"><br>
                    </div>
                    <hr />
                    <div>
                        <!-- Forgot password -->
                        <div class="text-center">
                            <a href="forgotPassword.php">Forgot password?</a>
                        </div>
                        <div class="text-center">
                            <p>New around here? <a href="register.php">Register here</a></p>
                        </div>
                    </div>
                </form>
            </div>
        </div>
    </div>
</div>

<script>
(function() {
    'use strict';
    window.addEventListener('load', function() {
        // Fetch all the forms we want to apply custom Bootstrap validation styles to
        var forms = document.getElementsByClassName('needs-validation');
        // Loop over them and prevent submission
        var validation = Array.prototype.filter.call(forms, function(form) {
            form.addEventListener('submit', function(event) {
                if (form.checkValidity() === false) {
                    event.preventDefault();
                    event.stopPropagation();
                }
                form.classList.add('was-validated');

            }, false);
        });
    }, false);
})();
$(".reveal1").on('mousedown touchstart', function() {
    var $pwd = $(".pwd1");

    $pwd.attr('type', 'text');
    $(".reveal1").html(`<i class="fas fa-eye"></i>`);


}).on('mouseup touchend', function() {
    var $pwd = $(".pwd1");
    $pwd.attr('type', 'password');
    $(".reveal1").html(`<i class="fas fa-eye-slash"></i>`);

});
</script>
<?php
include("shared/footer.php");
?>