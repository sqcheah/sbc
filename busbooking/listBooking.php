<?php
include("shared/header.php");
function getListBooking($conn, $sort)
{
    if (isset($_GET['status'])) {
        $status = $_GET['status'];
        if ($status == "BOOKED") {
            return query($conn, "SELECT booking.*,customer.name FROM booking JOIN customer ON booking.cusID=customer.phoneNum WHERE `status`='BOOKED' AND `provider`='" . $_SESSION['providerID'] . "' ORDER BY `departureDate`,`departureTime` $sort");
        }
        if ($status == "BOOKEDBUTNOTPAID") {
            return query($conn, "SELECT booking.*,customer.name FROM booking JOIN customer ON booking.cusID=customer.phoneNum WHERE `status`='BOOKED BUT NOT PAID' AND `provider`='" . $_SESSION['providerID'] . "' ORDER BY `departureDate`,`departureTime` $sort");
        } else if ($status == "CANCEL") {
            return query($conn, "SELECT booking.*,customer.name FROM booking JOIN customer ON booking.cusID=customer.phoneNum WHERE `status`='CANCEL' AND `provider`='" . $_SESSION['providerID'] . "' ORDER BY `departureDate`,`departureTime` $sort");
        }
    }
    return query($conn, "SELECT booking.*,customer.name FROM booking JOIN customer ON booking.cusID=customer.phoneNum WHERE `status`='PENDING' ORDER BY `departureDate`,`departureTime` $sort");
}
$status = "";
?>

<div class="container my-5 min-vh-100">
    <h2 class='text-center'>
        <?php if (isset($_GET['status'])) {
            $status = $_GET['status'];
            if ($status == "BOOKED") {
                echo "Booked";
            }
            if ($status == "BOOKEDBUTNOTPAID") {
                echo "Booked but not paid";
            } else if ($status == "CANCEL") {
                echo "Cancelled";
            }
        }
        ?>
        Booking List</h2>
    <hr style="border-top:5px solid rgba(0,0,0,.1)">
    <?php
    echo '
      <nav class="nav nav-pills nav-fill mb-5">
      <a class="nav-link ' . ($status == "" ? "active" : "") . '" href="listBooking.php">Pending</a>
      <a class="nav-link ' . ($status == "BOOKED" ? "active" : "") . '" href="listBooking.php?status=BOOKED">Booked</a>
      <a class="nav-link ' . ($status == "BOOKEDBUTNOTPAID" ? "active" : "") . '" href="listBooking.php?status=BOOKEDBUTNOTPAID">Booked but not paid</a>
      <a class="nav-link ' . ($status == "CANCEL" ? "active" : "") . '" href="listBooking.php?status=CANCEL">Cancelled</a>
      </nav>
      ';
    $sort = "ASC";
    if (isset($_GET['sort'])) {
        if (strtoupper($_GET['sort']) == 'DESC') {
            $sort = "DESC";
        }
    }

    echo '<a href="' . basename($_SERVER['PHP_SELF']) . '?sort=' . ($sort == "ASC" ? "DESC" : "ASC") . ($status != "" ? "&status=$status" : "") . '" class="btn btn-primary mb-5"> <i class="fas fa-sort-numeric-' . ($sort == "ASC" ? "up" : "down") . '-alt"></i> Sort By Departure Date</a>';

    $result = getListBooking($conn, $sort);
    if (mysqli_num_rows($result) > 0) {
        $index = 0;
        while ($item = mysqli_fetch_assoc($result)) {

            echo "
        <div class='card my-3'>
            <div class='card-header' id='heading$index'>
            <h5 class='card-title'>Booking ID : " . $item['id'] . "</h5>
            </div>
            <div class='card-body'>
                        <p>Passenger: " . $item['passenger'] . "</p>
                        <p>Remarks:" . $item['remarks'] . "</p>
                        <h5>Departure</h5>
                        <hr>
                        <p>Date & Time : " . $item['departureDate'] . " " .  $item['departureTime'] . "</p>
                        <p>Location : " . $item['departureLocation'] . "</p>
                        <h5>Arrival</h5>
                        <hr>
                        <p>Date & Time : " . $item['arrivalDate'] . " " . $item['arrivalTime'] . "</p>
                        <p>Location : " . $item['arrivalLocation'] . "</p>
                        <h5>Customer</h5>
                        <hr>
                        <p>Name: " . $item['name'] . "</p>
                        <p>Phone No. : " . $item['cusID'] . "</p>

                    <div class='text-center mt-2'>
                        <a class='btn btn-primary' href='viewBooking.php?id=" . $item['id'] . "'>Accept Request</a>
                    </div>

            </div>
        </div>";
            $index++;
        }
    } else {
        echo "<div class='alert alert-light'>
    No Bookings Found.
    </div>";
    }
    ?>
</div>
<?php
include("shared/footer.php");