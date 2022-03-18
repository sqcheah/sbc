<?php
//database connection, timeout counter and navbar
include("shared/header.php");
function getProvider($conn, $id)
{
    return query($conn, "SELECT * FROM `provider` WHERE `id`='$id'");
}
$result = getProvider($conn, $_SESSION['providerID']);
echo mysqli_error($conn);
$row = mysqli_fetch_assoc($result);
$targetDir = "uploads/provider/" . $_SESSION['providerID'] . "/";

?>


<div class="container py-5">
    <h2 class="text-center py-2">Profile</h2>
    <div class="card">
        <div class="card-body">
            <?php


            echo '
            <!--form for update driver-->
            <!--https://stackoverflow.com/questions/49943610/can-i-check-password-confirmation-in-bootstrap-4-with-default-validation-options-->
            <form action="' . basename($_SERVER['PHP_SELF']) . '" method="POST" class="needs-validation" novalidate>
         
            <input type="hidden" name="id" id="id" value="' . $row['id'] . '">
            <div class="my-5">
            <img id="output" src="' . (empty($row['image']) ? "assets/avatar_placeholder.jpg" : $targetDir . $row['image']) . '" class="img-fluid mx-auto d-block border border-info" style="width:auto;height:10rem;"/>
            </div>

                <div class="form-row">
                    <div class="col-md-4 mb-3">
                        <label for="company">Company: </label>
                    </div>
                    <div class="col-md-8 mb-3">
                        <input type="text" class="form-control" name="company" id="company" value="' . $row['company'] . '" disabled>
                    </div>
                </div>

                <div class="form-row">
                    <div class="col-md-4 mb-3">
                        <label for="Name">Name: </label>
                    </div>
                    <div class="col-md-8 mb-3">
                        <input type="text" class="form-control" name="name" id="name" value="' . $row['name'] . '" disabled>
                    </div>
                </div>

                <div class="form-row">
                <div class="col-md-4 mb-3">
                    <label for="IC">IC No. : </label>
                </div>
                <div class="col-md-8 mb-3">
                    <input type="text" class="form-control" name="IC" id="IC" value="' . $row['ic'] . '" disabled>
                </div>
            </div>

            <div class="form-row">
            <div class="col-md-4 mb-3">
                <label for="email">Email: </label>
            </div>
            <div class="col-md-8 mb-3">
                <input type="text" class="form-control" name="email" id="class" value="' . $row['email'] . '" disabled>
            </div>
        </div>

                <div class="form-row">
                    <div class="col-md-4 mb-3">
                        <label for="contact details">Phone No. : </label>
                    </div>
                    <div class="col-md-8 mb-3">
                        <input type="text"  value="' . $row['phoneNum'] . '" class="form-control" name="phoneNum" id="phoneNum" disabled>
                    </div>

                </div>

        ' ?>
            <div class="text-center">
                <a class="btn btn-primary" href="updateProfile.php">Update</a>
            </div>
            </form>


        </div>
    </div>
</div>

<?php
include("shared/footer.php");

?>