<?php
//database connection, timeout counter and navbar
include_once("shared/connect.php");
include_once("shared/header.php");
function getListNotif($conn)
{
    return query($conn, "SELECT * FROM `notification` WHERE  `recipient`='" . $_SESSION['providerID'] . "'");
}
?>
<div class="container-fluid min-vh-100">
    <h2 class="text-center mt-5">Notification List</h2>
    <?php
    $result = getListNotif($conn);
    if (mysqli_num_rows($result) > 0) {
        while ($item = mysqli_fetch_assoc($result)) {
            echo '

            <div class="card my-5">
            <div class="card-header d-flex justify-content-between">
            <h5 class="card-title">' . $item['title'] . '</h5>
            <p >' . $item['createdAt'] . '</p>
            </div>
            <div class="card-body">
            <div class="d-flex align-items-center">
            <div class="mr-3">
            <i class="fas fa-envelope' . ($item['isRead'] == 1 ? "-open" : "") . '"></i>
        </div>
            <div> ' . $item['description'] . '</div>
            </div>
            <div class="text-center mt-2">
            <a href="viewNotification.php?id=' . $item['id'] . '" class="btn btn-primary">View</a>
        </div>
    

            </div>
    
            </div>

';
        }
    }
    ?>
</div>


<?php
include_once("shared/footer.php");