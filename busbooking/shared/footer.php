<!--https://jsfiddle.net/StartBootstrap/out2g1mq/-->
<footer id="sticky-footer" class="py-4 bg-dark text-white">
    <div class="container text-center text-uppercase">
        <div class="row ">
            <div class="col-md-4 my-2"><a href="about.php" class="text-white text-decoration-none">About Us</a></div>
            <div class="col-md-4 my-2"><a href="#" class="text-white text-decoration-none">Privacy Policy</a></div>
            <div class="col-md-4 my-2"><a href="#" class="text-white text-decoration-none">Others</a></div>
        </div>
        <hr class="bg-white">
        <small>
            <p>Copyright 2020 &copy; SBC Shuttle Bus Central. All Right Reserved</p>

            <p>Contact Us: +84 28 7304 2288</p>
            <p>Fax: +087 519 661</p>
            <p>Email: enquiry@sbcshuttlebus.com</p>
        </small>
    </div>
</footer>
</div>
</div>


<script type="text/javascript">
$(document).ready(function() {
    $("#sidebar").mCustomScrollbar({
        theme: "minimal"
    });

    $('#sidebarCollapse').on('click', function() {
        $('#sidebar, #content').toggleClass('active');
        $('.collapse.in').toggleClass('in');
        $('a[aria-expanded=true]').attr('aria-expanded', 'false');
    });
    if ($(window).width() < 767) {

        $('#alertsDropdown').on('click', function() {
            if ($('#sidebar,#content').hasClass('active')) {
                $('#sidebar, #content').toggleClass('active');
                $('.collapse.in').toggleClass('in');
                $('a[aria-expanded=true]').attr('aria-expanded', 'false');
            }
        });
        // change functionality for smaller screens
    } else {
        // change functionality for larger screens
        $('#alertsDropdown').on('click', function() {
            if (!$('#sidebar,#content').hasClass('active')) {
                $('#sidebar, #content').toggleClass('active');
                $('.collapse.in').toggleClass('in');
                $('a[aria-expanded=true]').attr('aria-expanded', 'false');
            }
        });
    }

    <?php
        if (isset($_SESSION['curUser'])) {
            echo '
            function load_unseen_notification(view = "") {
            
                $.ajax({
                    url: "fetch.php",
                    method: "POST",
                    data: {
                        view: view,
                        id:' . $_SESSION['providerID'] . '
                        
                    },
                    dataType: "json",
                    success: function(data) {
                        $("#notifView").html(data.notification);
                        if (data.unseen_notification > 0) {
                            $("#notifCount").html(data.unseen_notification);
                        }
                    }
                });
            }
                load_unseen_notification();
                $("#notifBtn").on("click", function() {
                    $("#notifCount").html("");
                    load_unseen_notification("yes");
                });
            
                ';
        }
        ?>
});
</script>
</body>

<?php
/*
$rejected = ['logout.php', 'viewfile.php', 'downloadfile.php', 'invoice.php', 'addAcc.php', 'editAcc.php', 'manageAcc.php', 'editProduct.php', 'addProduct.php', 'manageProduct.php', 'editNews.php', 'addNews.php', 'manageNews.php', 'manageQuotation.php', 'viewQuotation.php', 'manageInvoice.php'];

if (!in_array(basename($_SERVER['PHP_SELF']), $rejected)) {
    echo '<script type="text/javascript">
var Tawk_API = Tawk_API || {},
    Tawk_LoadStart = new Date();
(function() {
    var s1 = document.createElement("script"),
        s0 = document.getElementsByTagName("script")[0];
    s1.async = true;
    s1.src = "https://embed.tawk.to/5ee6cfc74a7c6258179a9540/default";
    s1.charset = "UTF-8";
    s1.setAttribute("crossorigin", "*");
    s0.parentNode.insertBefore(s1, s0);
})();
</script>
';

}
 */
?>