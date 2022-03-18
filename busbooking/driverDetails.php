<?php
//database connection, timeout counter and navbar
include_once("shared/connect.php");

function getDriver($conn, $id)
{
    return query($conn, "SELECT * FROM driver WHERE `id`=$id AND `provider`='" . $_SESSION['providerID'] . "'");
}
function updateDriver($conn, $id)
{

    $phoneNum = $_POST['phoneNum'];
    $phoneNum = ltrim($phoneNum, "0");
    $status = $_POST['status'];
    $reason = mysqli_real_escape_string($conn, trim($_POST['reason']));
    if ($status == 'UNAVAILABLE' && empty($reason)) {
        echo '<br><div class="alert alert-danger">
        <div class="row">
            <div class="col-auto align-self-center">
            <i class="fas fa-times-circle"></i>
            </div>
            <div class="col">
            Reason is missing. 
            </div>
        </div>
    </div>';
        return;
    } else if ($status == 'FREE') {
        $reason = NULL;
    }
    if (isset($_FILES) && !empty($_FILES['pimage']['tmp_name'])) {
        $targetDir = "uploads/driver/" . $_POST['id'] . "/";
        if (!file_exists($targetDir)) {
            mkdir($targetDir, 0700, true);
        }
        $fileName  = preg_replace('/[^a-zA-Z0-9_-]+/', '-', strtolower($_FILES['pimage']['name'])) . '.' . pathinfo($_FILES['pimage']['name'], PATHINFO_EXTENSION);
        //$docExt = strtolower(pathinfo($_FILES['pimage']['name'], PATHINFO_EXTENSION));
        //$newFileName = "product_" . $uploadTitle . "_" . time() . "." . $docExt;
        $docTempPath = $_FILES['pimage']['tmp_name'];
        $newFilePath = $targetDir . $fileName;
        if (isset($oldImage) && !empty($oldImage)) {
            unlink($oldImage);
        }
        $uploadResult = move_uploaded_file($docTempPath, $newFilePath);
        if (!$uploadResult) {
            echo '<br><div class="alert alert-danger">
            Something went wrong! Cannot upload file!
            </div>';
            return;
        } else {
            query($conn, "UPDATE driver SET `phoneNum`='$phoneNum',`status`='$status',`reason`='$reason',`image`='$fileName' WHERE `id`='$id'");
        }
    } else {
        query($conn, "UPDATE driver SET `phoneNum`='$phoneNum',`status`='$status',`reason`='$reason' WHERE `id`='$id'");
    }
    echo '<br><div class="alert alert-success">
        <div class="row">
            <div class="col-auto align-self-center">
            <i class="fas fa-check-circle"></i>
            </div>
            <div class="col">
            Update successful.  
            </div>
        </div>
    </div>';
}

include("shared/header.php");
?>


<div class="container py-5">
    <h2 class="text-center py-2">Update Driver </h2>
    <div class="card">
        <div class="card-body">
            <?php
            if (isset($_GET['id']) && !empty($_GET['id'])) {
                $id = $_GET['id'];
                if (preg_match("/^[\d]+$/", $id)) {
                    $result = getDriver($conn, $id);
                    if (mysqli_num_rows($result) > 0) {
                        $row = mysqli_fetch_assoc($result);
                        $targetDir = "uploads/driver/" . $id . "/";
                    } else {
                        header("Location:listDriver.php");
                        exit();
                    }
                } else {
                    header("Location:listDriver.php");
                    exit();
                }
            } else if (isset($_POST['save'])) {
                $id = $_POST['id'];
                updateDriver($conn, $id);
                $result = getDriver($conn, $id);
                if (mysqli_num_rows($result) > 0) {
                    $row = mysqli_fetch_assoc($result);
                    $targetDir = "uploads/driver/" . $row['id'] . "/";
                } else {
                    header("Location:listDriver.php");
                    exit();
                }
            } else {
                header("Location:listDriver.php");
                exit();
            }

            echo '
            <!--form for update driver-->
            <!--https://stackoverflow.com/questions/49943610/can-i-check-password-confirmation-in-bootstrap-4-with-default-validation-options-->
            <form action="' . basename($_SERVER['PHP_SELF']) . '" method="POST" class="needs-validation" novalidate enctype="multipart/form-data">
           
            <input type="hidden" name="id" id="id" value="' . $row['id'] . '">
            <img id="output" src="' . (empty($row['image']) ? "assets/avatar_placeholder.jpg" : $targetDir . $row['image']) . '" class="img-fluid mx-auto d-block border border-info" style="width:auto;height:10rem;"/>
            
            <div class="form-group">
            <label for="Image">Change Image</label>
            <div class="custom-file">
                <input class="custom-file-input" type="file" name="pimage"  id="pimage" accept="image/*" >
                <label class="custom-file-label" for="chooseimage">Choose image...</label>
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
                        <label for="IC">IC: </label>
                    </div>
                    <div class="col-md-8 mb-3">
                        <input type="text" class="form-control" name="IC" id="IC" value="' . $row['IC'] . '" disabled>
                    </div>
                </div>

                <div class="form-row">
                <div class="col-md-4 mb-3">
                    <label for="licenseNo">License No. : </label>
                </div>
                <div class="col-md-8 mb-3">
                    <input type="text" class="form-control" name="licenseNo" id="licenseNo" value="' . $row['licenseNo'] . '" disabled>
                </div>
            </div>

            <div class="form-row">
            <div class="col-md-4 mb-3">
                <label for="class">class: </label>
            </div>
            <div class="col-md-8 mb-3">
                <input type="text" class="form-control" name="class" id="class" value="' . $row['class'] . '" disabled>
            </div>
        </div>

                <div class="form-row">
                    <div class="col-md-4 mb-3">
                        <label for="contact details">Phone No. : </label>
                    </div>
                    <div class="col-md-8 mb-3">
                        <input type="text" pattern="0?(11[0-9]{8}$|1[02-9][0-9]{7}$)" value="' . $row['phoneNum'] . '" class="form-control" name="phoneNum" id="phoneNum" placeholder="Mobile Number" required oninput="if (/\D/g.test(this.value)) this.value = this.value.replace(/\D/g,"")" required>
                        <div class="invalid-feedback">
                            Please enter valid Malaysia Mobile Number.
                        </div>
                    </div>

                </div>

                <div class="form-row">
                    <div class="col-md-4 mb-3">
                        <label for="Status">Status</label>
                    </div>
                    <div class="col-md-8 mb-3">
                        <select name="status" id="state" class="form-control" required>
                            <option value="FREE" ' . ($row['status'] == "FREE" ? 'selected' : '') . '>FREE</option>
                            <option value="UNAVAILABLE" ' . ($row['status'] == "UNAVAILABLE" ? 'selected' : '') . '>UNAVAILABLE</option>    
                        </select>
                        <div class="invalid-feedback">
                            Please provide a valid status.
                        </div>
                    </div>
                </div>

                <div class="form-row">
                    <div class="col-md-4 mb-3">
                        <label for="Reason">Reason: </label>
                    </div>
                    <div class="col-md-8 mb-3">
                        <textarea name="reason" id="reason" class="form-control" placeholder="Enter reason here if status is unavailable">' . $row['reason'] . '</textarea>
                        <div class="invalid-feedback">
                            Reason is required.
                        </div>
                    </div>
                </div>
        ' ?>
            <div class="text-center">
                <button class="btn btn-primary" type="submit" name="save" value="save">Update</button>
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
$('#pimage').on('change', function(event) {
    //get the file name
    var fileName = $(this).val().replace('C:\\fakepath\\', ' ');
    //replace the 'Choose a file' label
    $(this).next('.custom-file-label').html(fileName);
    loadFile(event)
})
//https://www.webtrickshome.com/faq/how-to-display-uploaded-image-in-html-using-javascript
var loadFile = function(event) {
    var image = document.getElementById('output');
    image.src = URL.createObjectURL(event.target.files[0]);
};
</script>
<br><br>
<?php
include("shared/footer.php");

?>