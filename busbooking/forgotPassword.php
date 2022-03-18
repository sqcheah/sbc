<?php
//database connection, timeout counter and navbar
include("shared/header.php");
$success = 0;
//add new account

?>


<div class="container py-5">
    <h1 class="text-center py-2">Forgot Password</h1>
    <div class="card">
        <div class="card-body">
            <?php
            if (isset($_POST['submitBtn'])) {
                $email = $_POST['email'];
                $result = query($conn, "SELECT * from `provider` JOIN `user_account` ON provider.id=user_account.provider  AND lower(email)='" . strtolower($email) . "'");
                if (mysqli_num_rows($result) > 0) {
                    $row = mysqli_fetch_assoc($result);
                    $bytes = random_bytes(16);
                    $token = bin2hex($bytes);
                    query($conn, "INSERT INTO `verification`(`email`,`token`) VALUES('$email','$token')");
                    include_once("shared/sendMail.php");
                    sendMail($row['email'], $row['name'], "Reset Password", "<p>
                    Please click the button below to reset your password. 
                    If it's not you, please ignore the email.
                   </p>", "http://" . $_SERVER['HTTP_HOST'] . substr($_SERVER['REQUEST_URI'], 0, strrpos($_SERVER['REQUEST_URI'], "/")) . "/resetpassword.php?email='" . $email . "'&token=" . $token . "", "Reset Password");
                }
                echo '<br><div class="alert alert-success">
                <div class="row">
                    <div class="col-auto align-self-center">
                    <i class="fas fa-check-circle"></i>
                    </div>
                    <div class="col">
                    Email sent! Please check your email.
                    </div>
                </div>
            </div>';
            }
            ?>

            <form action='<?php echo basename($_SERVER['PHP_SELF']) ?>' method="POST" class="needs-validation"
                novalidate
                oninput='confirmemail.setCustomValidity(confirmemail.value != email.value ? "Emails do not match." : "")'>


                <div class="form-row">
                    <div class="col-md-4 mb-3">
                        <label for="Email">Email: </label>
                    </div>
                    <div class="col-md-8 mb-3">
                        <input pattern="[^@ \t\r\n]+@[^@ \t\r\n]+\.[^@ \t\r\n]+" class="form-control" name="email"
                            id="email" required>
                        <div class="invalid-feedback">
                            Please enter a valid email address.
                        </div>
                    </div>
                </div>


                <div class="form-row">
                    <div class="col-md-4 mb-3">
                        <label for="Confirm Email">Confirm Email: </label>
                    </div>
                    <div class="col-md-8 mb-3">
                        <input pattern="[^@ \t\r\n]+@[^@ \t\r\n]+\.[^@ \t\r\n]+" class="form-control"
                            name="confirmemail" id="confirmemail" required>
                        <div class="invalid-feedback">
                            Email does not match!
                        </div>
                    </div>
                </div>



                <div class="text-center">
                    <button class="btn btn-primary" type="submit" name="submitBtn" value="submit">Submit</button>
                </div>
            </form>

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
</script>
<br><br>
<?php
include("shared/footer.php");

?>