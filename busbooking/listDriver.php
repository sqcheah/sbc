<?php
include("shared/header.php");
function getListDriver($conn)
{
    if (isset($_GET['status'])) {
        $status = $_GET['status'];
        if ($status == "FREE") {
            return query($conn, "SELECT * FROM driver WHERE `provider`='" . $_SESSION['providerID'] . "' AND `status` ='FREE'");
        } else if ($status == "UNAVAILABLE") {
            return query($conn, "SELECT * FROM driver WHERE `provider`='" . $_SESSION['providerID'] . "' AND `status` ='UNAVAILABLE'");
        }
    }
    return query($conn, "SELECT * FROM driver WHERE `provider`='" . $_SESSION['providerID'] . "'");
}
$status = "";
?>
<div class="container my-5 min-vh-100">
    <div class="row">
        <div class="col-md">
            <h2>

                <?php if (isset($_GET['status'])) {
                    $status = $_GET['status'];
                    if ($status == "FREE") {
                        echo "Free";
                    } else if ($status == "UNAVAILABLE") {
                        echo "Unavailable";
                    }
                }
                ?>
                Driver List</h2>
        </div>
        <div class="col-md text-center">
            <a class="btn btn-primary" href="addDriver.php">Add Driver</a>
        </div>
    </div>

    <hr style="border-top:5px solid rgba(0,0,0,.1)">



    <?php
    echo '
    <nav class="nav nav-pills nav-fill">
    <a class="nav-link ' . ($status == "" ? "active" : "") . '" href="listDriver.php">All</a>
    <a class="nav-link ' . ($status == "FREE" ? "active" : "") . '" href="listDriver.php?status=FREE">Free</a>
    <a class="nav-link ' . ($status == "UNAVAILABLE" ? "active" : "") . '" href="listDriver.php?status=UNAVAILABLE">Unavailable</a>
</nav>
    ';
    $result = getListDriver($conn);
    if (mysqli_num_rows($result) > 0) {
        $index = 0;
        while ($item = mysqli_fetch_assoc($result)) {
            $targetDir = "uploads/driver/" . $item['id'] . "/";

            echo "<div class='accordion my-3' id='accordion$index'>
        <div class='card'>
            <div class='card-header' id='heading$index'>
                <div class='row'>
                    <div class='col-md-3 my-5'>
                    <img id='output' src='" . (empty($item['image']) ? "assets/avatar_placeholder.jpg" : $targetDir . $item['image']) . "' class='img-fluid mx-auto d-block border border-info' style='width:auto;height:10rem;'/>
            </div>
                    <div class='col align-self-center'>
                        <p>Name : " . $item['name'] . "</p>
                        <p>IC No. : " . $item['IC'] . "</p>
                        <p>Phone No. : " . $item['phoneNum'] . "</p>
                    </div>
                    <div class='col-md-3 align-self-center'>
                        <button class='btn btn-primary text-left collapsed m-2' type='button' data-toggle='collapse'
                            data-target='#collapse$index' aria-expanded='true' aria-controls='collapse$index'>
                            More Detail
                        </button>
                        <a class='btn btn-primary' href='driverDetails.php?id=" . $item['id'] . "'>Change Details</a>
                         </div>
                </div>
            </div>
    
            <div id='collapse$index' class='collapse' aria-labelledby='heading$index' data-parent='#accordion$index'>
                <div class='card-body'>
                <p>License No. : " . $item['licenseNo'] . "</p>
                <p>Class : " . $item['class'] . "</p>
                </div>
            </div>
        </div>
    
    
    </div>";
            $index++;
        }
    } else {
        echo "<div class='alert alert-light'>
    No driver available.
    </div>";
    }
    ?>
</div>
<?php
include("shared/footer.php");