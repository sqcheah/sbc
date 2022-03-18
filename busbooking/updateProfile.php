<?php
//database connection, timeout counter and navbar
include("shared/header.php");
$targetDir = "uploads/provider/" . $_SESSION['providerID'] . "/";
function getProvider($conn, $id)
{
    return query($conn, "SELECT * FROM `provider` WHERE `id`='$id'");
}
function updateProvider($conn, $id, $oldImage)
{

    $phoneNum = $_POST['phoneNum'];
    $phoneNum = ltrim($phoneNum, "0");
    $email = $_POST['email'];
    if (isset($_FILES) && !empty($_FILES['pimage']['tmp_name'])) {
        $targetDir = "uploads/provider/" . $_SESSION['providerID'] . "/";
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

            query($conn, "UPDATE provider SET `phoneNum`='$phoneNum',`email`='$email',`image`='$fileName' WHERE `id`='$id'");
        }
    } else {
        query($conn, "UPDATE provider SET `phoneNum`='$phoneNum',`email`='$email' WHERE `id`='$id'");
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
$result = getProvider($conn, $_SESSION['providerID']);
$row = mysqli_fetch_assoc($result);
?>


<div class="container py-5">
    <h2 class="text-center py-2">Update Profile </h2>
    <div class="card">
        <div class="card-body">
            <?php
            if (isset($_POST['save'])) {
                updateProvider($conn, $_SESSION['providerID'], $row['image']);
                $result = getProvider($conn, $_SESSION['providerID']);
                $row = mysqli_fetch_assoc($result);
            }

            echo '
            <!--form for update driver-->
            <!--https://stackoverflow.com/questions/49943610/can-i-check-password-confirmation-in-bootstrap-4-with-default-validation-options-->
            <form action="' . basename($_SERVER['PHP_SELF']) . '" method="POST" class="needs-validation" novalidate enctype="multipart/form-data">
           
            <input type="hidden" name="id" id="id" value="' . $row['id'] . '">
            <div class="my-5">
            <img id="output" src="' . (empty($row['image']) ? "assets/avatar_placeholder.jpg" : $targetDir . $row['image']) . '" class="img-fluid mx-auto d-block border border-info" style="width:auto;height:10rem;"/>
            </div>
                
            <div class="form-group">
            <label for="Image">Change Image</label>
            <div class="custom-file">
                <input class="custom-file-input" type="file" name="pimage"  id="pimage" accept="image/*" >
                <label class="custom-file-label" for="chooseimage">Choose image...</label>
            </div>
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
    <label for="Email">Email: </label>
</div>
<div class="col-md-8 mb-3">
    <input pattern="[^@ \t\r\n]+@[^@ \t\r\n]+\.[^@ \t\r\n]+" class="form-control" name="email"
        id="email" value="' . $row['email'] . '" required>
    <div class="invalid-feedback">
        Please enter a valid email address.
    </div>
</div>
</div>

<div class="form-row">
<div class="col-md-4 mb-3">
    <label for="contact details">Phone No. : </label>
</div>
<div class="col-md-8 mb-3">
    <input type="text" pattern="0?(11[0-9]{8}$|1[02-9][0-9]{7}$)" value="' . $row['phoneNum'] . '" class="form-control" name="phoneNum" id="phoneNum" placeholder="Mobile Number" required oninput="if (/\D/g.test(this.value)) this.value = this.value.replace(/\D/g,"")">
    <div class="invalid-feedback">
        Please enter valid Malaysia Mobile Number.
    </div>
</div>

</div>
        ' ?>
            <div class="text-center">
                <button class="btn btn-primary" type="submit" name="save" value="save">Update</button>
                <a class="btn btn-primary" href="profile.php">Back</a>
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