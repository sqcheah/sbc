<?php
//database connection, timeout counter and navbar
include_once("shared/connect.php");

function getNotif($conn, $id)
{
    return query($conn, "SELECT * FROM `notification` WHERE `id`=$id AND `recipient`='" . $_SESSION['providerID'] . "'");
}
function setRead($conn, $id)
{
    return query($conn, "UPDATE `notification` WHERE `id`=$id AND `recipent`='" . $_SESSION['providerID'] . "'");
}
$notifID = $_GET['id'];
if (preg_match("/^[\d]+$/", $notifID)) {
    $result = getNotif($conn, $notifID);
    if (mysqli_num_rows($result) > 0) {
        $item = mysqli_fetch_assoc($result);
        if ($item['isRead'] == 0) {
            setRead($conn, $notifID);
        }
    } else {

        header("Location:listNotification.php");
        exit();
    }
} else {

    header("Location:listNotification.php");
    exit();
}
include_once("shared/header.php");
echo '
<div class="container-fluid min-vh-100">
<h2 class="text-center mt-5">Notification</h2>
<div class="card my-5">
  <div class="card-header d-flex justify-content-between">
  <h5 class="card-title">' . $item['title'] . '</h5>
  <p >' . $item['createdAt'] . '</p>
  </div>
  <div class="card-body">
  ' . $item['description'] . '
  </div>
</div>
<div class="text-center my-5">
<a href="listNotification.php" class="btn btn-primary">Back to Notification List</a>
</div>
</div>
';
?>

<?php
include_once("shared/footer.php");