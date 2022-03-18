<?php
//database connection, timeout counter and navbar
include("shared/header.php");
?>
<div id="myCarousel" class="carousel slide mb-5" data-ride="carousel">
    <ol class="carousel-indicators">
        <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
        <li data-target="#myCarousel" data-slide-to="1"></li>
        <li data-target="#myCarousel" data-slide-to="2"></li>
    </ol>
    <div class="carousel-inner">
        <div class="carousel-item active">
            <img src="assets/bus.png" class="d-block w-100" alt="bus">
            <div class="carousel-caption">
                <button class="btn btn-primary">
                    <a href="tel:+" class="text-white text-decoration-none">Contact Us!!!</a>
                </button>
            </div>
        </div>
        <div class="carousel-item">
            <img src="assets/bus.png" class="d-block w-100" alt="bus">
            <div class="carousel-caption ">
                <button class="btn btn-primary">
                    <a href="tel:+" class="text-white text-decoration-none">Contact Us!!!</a>
                </button>
            </div>
        </div>
        <div class="carousel-item">
            <img src="assets/bus.png" class="d-block w-100" alt="bus">
            <div class="carousel-caption">
                <button class="btn btn-primary">
                    <a href="tel:+" class="text-white text-decoration-none">Contact Us!!!</a>
                </button>
            </div>
        </div>
    </div>
    <a class="carousel-control-prev" href="#myCarousel" role="button" data-slide="prev">
        <span class="carousel-control-prev-icon" aria-hidden="true"></span>
        <span class="sr-only">Previous</span>
    </a>
    <a class="carousel-control-next" href="#myCarousel" role="button" data-slide="next">
        <span class="carousel-control-next-icon" aria-hidden="true"></span>
        <span class="sr-only">Next</span>
    </a>
</div>
<div class="jumbotron jumbotron-fluid text-center">
    <div class="container">
        <h1 class="display-4 ">SBC Shuttle Bus</h1>
        <p class="lead">Looking for bus rental Malaysia or van rental ? Find us for the best transportation company
            which you can reliable. Booking with us is always the easiest and most convenient way for the transportation
            arrangement. </p>
    </div>
</div>
<!--
<div class="vh-100">Lorem ipsum dolor sit amet consectetur adipisicing elit. Recusandae deserunt rerum excepturi
    similique optio eveniet asperiores, nesciunt distinctio quae ut fugiat doloremque suscipit illum laudantium
    provident odio debitis voluptate in.
</div>
-->
<?php
include("shared/footer.php");