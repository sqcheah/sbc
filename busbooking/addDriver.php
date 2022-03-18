<?php
//database connection, timeout counter and navbar
include_once("shared/connect.php");


function insertDriver($conn)
{
    $name = mysqli_real_escape_string($conn, $_POST['name']);
    $IC = $_POST['IC'];
    $licenseNo = $_POST['licenseNo'];
    $class = mysqli_real_escape_string($conn, $_POST['class']);
    $phoneNum = $_POST['phoneNum'];
    $phoneNum = ltrim($phoneNum, "0");
    $provider = $_SESSION['providerID'];

    query($conn, "INSERT INTO driver (`name`,`IC`,`licenseNo`,`class`,`phoneNum`,`provider`) VALUES('$name','$IC','$licenseNo','$class','$phoneNum','$provider')");
    $last_id = mysqli_insert_id($conn);
    header("Location:driverDetails.php?id=$last_id");
    exit();
}
if (isset($_POST['save'])) {
    insertDriver($conn);
}
include("shared/header.php");
?>


<div class="container py-5">
    <h2 class="text-center py-2">Update Driver </h2>
    <div class="card">
        <div class="card-body">
            <?php


            echo '
            <!--form for update driver-->
            <!--https://stackoverflow.com/questions/49943610/can-i-check-password-confirmation-in-bootstrap-4-with-default-validation-options-->
            <form action="' . basename($_SERVER['PHP_SELF']) . '" method="POST" class="needs-validation" novalidate enctype="multipart/form-data">
                <div class="form-row">
                    <div class="col-md-4 mb-3">
                        <label for="Name">Name: </label>
                    </div>
                    <div class="col-md-8 mb-3">
                        <input type="text" class="form-control" name="name" id="name" placeholder="Enter name" required>
                        <div class="invalid-feedback">
                        Field is required
                    </div>
                    </div>
                </div>

                <div class="form-row">
                    <div class="col-md-4 mb-3">
                        <label for="IC">IC: </label>
                    </div>
                    <div class="col-md-8 mb-3">
                        <input type="text" class="form-control" name="IC" id="IC" pattern="[\d]{12}" placeholder="Enter IC" oninput="if (/\D/g.test(this.value)) this.value = this.value.replace(/\D/g,"")" required>
                        <div class="invalid-feedback">
                        Please enter a valid Malaysian IC number.
                    </div>
                        </div>
                   
                </div>

                <div class="form-row">
                <div class="col-md-4 mb-3">
                    <label for="licenseNo">License No. : </label>
                </div>
                <div class="col-md-8 mb-3">
                    <input type="text" class="form-control" name="licenseNo" id="licenseNo" placeholder="Enter Driver license number" required>
                    <div class="invalid-feedback">
                    Field is required
                </div>
                    </div>
             
            </div>

            <div class="form-row">
            <div class="col-md-4 mb-3">
                <label for="class">class: </label>
            </div>
            <div class="col-md-8 mb-3">
                <input type="text" class="form-control" name="class" id="class" placeholder="Enter Driver class" required>
                <div class="invalid-feedback">
                Field is required
            </div>
                </div>
    
        </div>

                <div class="form-row">
                    <div class="col-md-4 mb-3">
                        <label for="contact details">Phone No. : </label>
                    </div>
                    <div class="col-md-8 mb-3">
                        <input type="text" pattern="0?(11[0-9]{8}$|1[02-9][0-9]{7}$)"  class="form-control" name="phoneNum" id="phoneNum" placeholder="Enter Mobile Number" required oninput="if (/\D/g.test(this.value)) this.value = this.value.replace(/\D/g,"")" required>
                        <div class="invalid-feedback">
                            Please enter valid Malaysia Mobile Number.
                        </div>
                    </div>

                </div>


        ' ?>
            <div class="text-center">
                <button class="btn btn-primary" type="submit" name="save" value="save">Add</button>
                <a class="btn btn-primary" href="listDriver.php">Back</a>
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