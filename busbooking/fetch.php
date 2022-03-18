<?php


include('shared/connect.php');

if (isset($_POST['view'])) {

    $providerID = $_POST['id'];
    if ($_POST["view"] != '') {
        $update_query = "UPDATE `notification` SET isRead = 1 WHERE `recipient`='$providerID' AND isRead=0";
        query($conn, $update_query);
    }

    $query = "SELECT * FROM `notification` WHERE `recipient`='$providerID' ORDER BY `createdAt` DESC LIMIT 10";
    $result = query($conn, $query);
    $output = '';

    if (mysqli_num_rows($result) > 0) {

        while ($row = mysqli_fetch_assoc($result)) {
            if ($row['isRead'] == 1) {
                $output .= '
            <a class="dropdown-item d-flex align-items-center" href="viewNotification.php?id=' . $row['id'] . '">
                <div class="mr-3">
                    <i class="fas fa-envelope-open"></i>
                </div>
                <div class="text-wrap">
                    <div class="small text-black-50">' . $row['createdAt'] . '</div>
                    <span class="font-weight-bold">' . $row['title'] . '</span>
                </div>
            </a>';
            } else {
                $output .= '
                <a class="dropdown-item d-flex align-items-center" href="viewNotification.php?id=' . $row['id'] . '">
                    <div class="mr-3">
                        <i class="fas fa-envelope"></i>
                    </div>
                    <div class="text-wrap">
                        <div class="small text-black-50">' . $row['createdAt'] . '</div>
                        <span class="font-weight-bold">' . $row['title'] . '</span>
                    </div>
                </a>';
            }
        }
    } else {
        $output .= '
        <a class="dropdown-item d-flex align-items-center" href="#">
            <div class="text-wrap">
                <div class="small text-black-50">No notifications yet.</div>
            </div>
        </a>';
    }
    $status_query = "SELECT * FROM notification WHERE `recipient`='$providerID' AND `isRead`=0";
    $result_query = mysqli_query($conn, $status_query);
    $count = mysqli_num_rows($result_query);

    $data = array(
        'notification' => $output,
        'unseen_notification'  => $count
    );

    echo json_encode($data);
}