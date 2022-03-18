<?php
//database connection, timeout counter and navbar
include("shared/header.php");
function getBooking($conn, $id)
{
    return query($conn, "SELECT booking.*,customer.name FROM booking JOIN customer on booking.cusID=customer.phoneNum WHERE `id`=$id");
}
function updateBooking($conn, $id)
{

    $vehicle = $_POST['vehicle'];
    $driver1 = $_POST['driver1'];
    $driver2 = $_POST['driver2'];
    $paid = $_POST['paid'];
    $status = "BOOKED BUT NOT PAID";
    if ($paid == "1") {
        $status = "BOOKED";
    }
    if ($driver1 == $driver2) {
        echo '<br><div class="alert alert-danger">
        <div class="row">
            <div class="col-auto align-self-center">
            <i class="fas fa-times-circle"></i>
            </div>
            <div class="col">
            Driver1 and Driver 2 cannot be the same;
            </div>
        </div>
    </div>';
        return;
    }
    query($conn, "UPDATE booking SET `vehicle`='$vehicle',`driver1`='$driver1',`driver2`='$driver2',`status`='$status',`provider`='" . $_SESSION['providerID'] . "' WHERE `id`='$id'");

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
function getVehicle($conn, $startDate, $endDate, $passenger)
{

    $result = query($conn, "SELECT * FROM vehicle WHERE `provider`='" . $_SESSION['providerID'] . "'");
    $result = query($conn, "SELECT * FROM vehicle WHERE `provider`='" . $_SESSION['providerID'] . "'  AND `plateNo` NOT IN (SELECT vehicle FROM `service` WHERE (`startDate`<'$endDate' AND `endDate`>'$endDate') OR  (`startDate`<'$startDate' AND `endDate`>'$startDate')OR  (`startDate`>='$startDate' AND `endDate`<='$endDate'))  AND `plateNo` NOT IN (SELECT vehicle FROM `booking` WHERE (`departureDate`<'$endDate' AND `arrivalDate`>'$endDate') OR  (`departureDate`<'$startDate' AND `arrivalDate`>'$startDate')OR  (`departureDate`>'$startDate' AND `arrivalDate`<'$endDate')) AND `capacity`>=$passenger");
    return $result;
}
function getDriver($conn, $startDate, $endDate)
{
    $result = query($conn, "SELECT * FROM driver WHERE `provider`='" . $_SESSION['providerID'] . "' AND `status`='FREE' AND `id` NOT IN (SELECT `driver1` FROM `booking` WHERE (`departureDate`<'$endDate' AND `arrivalDate`>'$endDate') OR  (`departureDate`<'$startDate' AND `arrivalDate`>'$startDate')OR  (`departureDate`>'$startDate' AND `arrivalDate`<'$endDate')) AND `id` NOT IN (SELECT `driver2` FROM `booking` WHERE (`departureDate`<'$endDate' AND `arrivalDate`>'$endDate') OR  (`departureDate`<'$startDate' AND `arrivalDate`>'$startDate')OR  (`departureDate`>'$startDate' AND `arrivalDate`<'$endDate'))");

    return $result;
}

$disabled = false;
?>


<div class="container py-5">
    <h2 class="text-center py-2">Booking Request</h2>
    <div class="card">
        <div class="card-body">
            <?php
            if (isset($_GET['id']) && !empty($_GET['id'])) {
                $id = $_GET['id'];
                if (preg_match("/^[\d]+$/", $id)) {
                    $result = getBooking($conn, $id);
                    if (mysqli_num_rows($result) > 0) {
                        $row = mysqli_fetch_assoc($result);
                    } else {
                        header("Location:listBooking.php");
                        exit();
                    }
                } else {
                    header("Location:listBooking.php");
                    exit();
                }
            } else if (isset($_POST['save'])) {
                $id = $_POST['id'];
                updateBooking($conn, $id);
                $result = getBooking($conn, $id);
                if (mysqli_num_rows($result) > 0) {
                    $row = mysqli_fetch_assoc($result);
                    if ($row['status'] == "CANCEL") {
                        $disabled = true;
                    }
                } else {
                    header("Location:listBooking.php");
                    exit();
                }
            } else {
                header("Location:listBooking.php");
                exit();
            }
            $endDate = $row['arrivalDate'];
            $startDate = $row['departureDate'];
            $passenger = $row['passenger'];
            echo '
            <!--form for booking request-->
            <form action="' . basename($_SERVER['PHP_SELF']) . '" method="POST" class="needs-validation" novalidate>
<h4>Booking ID: ' . $row['id'] . '</h4>
            <input type="hidden" name="id" id="id" value="' . $row['id'] . '">
            <input type="hidden" name="paid" id="paid" value="' . $row['paid'] . '"> 
                <div class="form-row">
                <div class="col-md-4 mb-3">
                    <label for="Passenger">Passenger: </label>
                </div>
                <div class="col-md-8 mb-3">
                    <input type="text" class="form-control" name="passenger" id="passenger" value="' . $row['passenger'] . '" disabled>
                </div>
            </div>
            
            <div class="form-row">
                <div class="col-md-4 mb-3">
                    <label for="Remarks">Remarks: </label>
                </div>
                <div class="col-md-8 mb-3">
                    <input type="text" class="form-control" name="remarks" id="remarks" value="' . $row['remarks'] . '" disabled>
                </div>
            </div>
            <h5>Departure</h5>
            <hr>
            <div class="form-row">
                <div class="col-md-4 mb-3">
                    <label for="departuredatetime">Date & Time : </label>
                </div>
                <div class="col-md-8 mb-3">
                    <input type="text" class="form-control" name="departuredatetime" id="departuredatetime" value="' . $row['departureDate'] . ' ' . $row['departureTime'] . '" disabled>
                </div>
            </div>
            
            <div class="form-row">
                <div class="col-md-4 mb-3">
                    <label for="departureLocation">Location: </label>
                </div>
                <div class="col-md-8 mb-3">
                    <input type="text" class="form-control" name="departureLocation" id="departureLocation" value="' . $row['departureLocation'] . '" disabled>
                </div>
            </div>
            <h5>Arrival</h5>
            <hr>
            <div class="form-row">
                <div class="col-md-4 mb-3">
                    <label for="arrivaldatetime">Date & Time : </label>
                </div>
                <div class="col-md-8 mb-3">
                    <input type="text" class="form-control" name="arrivaldatetime" id="arrivaldatetime" value="' . $row['arrivalDate'] . ' ' . $row['arrivalTime'] . '" disabled>
                </div>
            </div>
            
            <div class="form-row">
                <div class="col-md-4 mb-3">
                    <label for="arrivalLocation">Location: </label>
                </div>
                <div class="col-md-8 mb-3">
                    <input type="text" class="form-control" name="arrivalLocation" id="arrivalLocation" value="' . $row['arrivalLocation'] . '" disabled>
                </div>
            </div>
            <h5>Customer</h5>
            <hr>
            <div class="form-row">
                <div class="col-md-4 mb-3">
                    <label for="phoneNum">Phone No. : </label>
                </div>
                <div class="col-md-8 mb-3">
                <input type="text" class="form-control" name="cusID" id="cusID" value="' . $row['cusID'] . '" disabled>
                </div>
            </div>
            <div class="form-row">
                <div class="col-md-4 mb-3">
                    <label for="name">Name : </label>
                </div>
                <div class="col-md-8 mb-3">
                <input type="text" class="form-control" name="name" id="name" value="' . $row['name'] . '" disabled>
                </div>
            
            </div>
            <div class="form-row">
                <div class="col-md-4 mb-3">
                    <label for="Vehicle">Vehicle</label>
                </div>
                <div class="col-md-8 mb-3">
                    
                    ';

            $vresult = getVehicle($conn, $startDate, $endDate, $passenger);
            if (mysqli_num_rows($vresult) > 0) {

                echo '<select name="vehicle" id="vehicle" class="form-control" required ' . ($row['status'] == "CANCEL" ? "disabled" : "") . '>
                <option value="" selected disabled></option>
                ';

                while ($vrow = mysqli_fetch_assoc($vresult)) {
                    echo ' <option value="' . $vrow['plateNo'] . '" ' . ($row['vehicle'] == $vrow['plateNo'] ? 'selected' : '') . '>' . $vrow['plateNo'] . ',' . $vrow['category'] . '</option>';
                }
                echo '</select>
                <div class="invalid-feedback">
                    Please choose a vehicle.
                </div>';
            } else {
                echo ' <p>No vehicle available</p>';
                $disabled = true;
            }

            echo '
                </div>
            </div>
            <div class="form-row">
            <div class="col-md-4 mb-3">
                <label for="Driver1">Driver1</label>
            </div>
            <div class="col-md-8 mb-3">
                
                ';
            $dresult = getDriver($conn, $startDate, $endDate);
            if (mysqli_num_rows($dresult) > 0) {

                echo '<select name="driver1" id="driver1" class="form-control" required>
                <option value="" selected disabled></option>
                ';
                while ($drow = mysqli_fetch_assoc($dresult)) {
                    echo ' <option value="' . $drow['id'] . '" ' . ($row['driver1'] == $drow['id'] ? 'selected' : '') . '>' . $drow['name'] . '</option>';
                }
                echo '</select>
            <div class="invalid-feedback">
                Please choose a driver.
            </div>';
            } else {
                echo ' <p>No Driver available</p>';
                $disabled = true;
            }
            echo '
            </div>
        </div>
        <div class="form-row">
        <div class="col-md-4 mb-3">
            <label for="Driver2">Driver2</label>
        </div>
        <div class="col-md-8 mb-3">
            
            ';
            $dresult = getDriver($conn, $startDate, $endDate);
            if (mysqli_num_rows($dresult) > 0) {

                echo '<select name="driver2" id="driver2" class="form-control" required ' . ($row['status'] == "CANCEL" ? "disabled" : "") . '>
                <option value="" selected disabled></option>
                ';
                while ($drow = mysqli_fetch_assoc($dresult)) {
                    echo ' <option value="' . $drow['id'] . '" ' . ($row['driver2'] == $drow['id'] ? 'selected' : '') . '>' . $drow['name'] . '</option>';
                }
                echo '</select>
        <div class="invalid-feedback">
            Please choose a driver.
        </div>';
            } else {
                echo ' <p>No Driver available</p>';
                $disabled = true;
            }
            echo '
        </div>
    </div>


 
        ' ?>
            <div class="text-center">
                <button class="btn btn-primary" type="submit" name="save" value="save"
                    <?php echo ($disabled ? "disabled" : "") ?>>Submit</button>
                <a class="btn btn-primary" href="listBooking.php">Back</a>
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