<?php
include("shared/header.php");
?>
<style>
html,
body {
    width: 100%;
    height: 100%;
    padding: 0;
    margin: 0;
    background-color: #32333b;
    font-family: sans-serif;
}

#error408 {
    padding-top: calc(50vh - 25vmin);
}

#error408 h1 {
    justify-content: center;
    padding: 0;
    margin: 0 auto;
    font-family: sans-serif;
    font-weight: normal;
    font-size: 50vmin;
    text-align: center;
    color: rgba(255, 255, 255, 0.3);
    animation: 60s infinite colorWheelTxt;
}

#error408 h1 svg {
    height: 35vmin;
    width: 35vmin;
}

#error408 h1 svg circle:first-of-type {
    animation: 30s infinite colorWheel1;
}

#error408 h1 svg circle:last-of-type {
    animation: 20s infinite colorWheel2;
}

#error408 .subtitle {
    position: relative;
    top: -8vmin;
    text-align: center;
    color: rgba(255, 255, 255, 0.4);
    padding: 0;
    margin: 0 auto;
    font-size: 5vmin;
}

@keyframes colorWheelTxt {
    from {
        color: #4b4b4b;
    }

    10% {
        color: turquoise;
    }

    20% {
        color: springgreen;
    }

    30% {
        color: gold;
    }

    40% {
        color: coral;
    }

    50% {
        color: firebrick;
    }

    60% {
        color: deeppink;
    }

    70% {
        color: purple;
    }

    80% {
        color: indigo;
    }

    90% {
        color: midnightblue;
    }

    to {
        color: #4b4b4b;
    }
}

@keyframes colorWheel1 {
    from {
        stroke: #4b4b4b;
    }

    15% {
        stroke: turquoise;
    }

    30% {
        stroke: springgreen;
    }

    45% {
        stroke: gold;
    }

    75% {
        stroke: coral;
    }

    90% {
        stroke: firebrick;
    }

    to {
        stroke: #4b4b4b;
    }
}

@keyframes colorWheel2 {
    from {
        stroke: #4b4b4b;
    }

    15% {
        stroke: firebrick;
    }

    30% {
        stroke: deeppink;
    }

    45% {
        stroke: purple;
    }

    75% {
        stroke: indigo;
    }

    90% {
        stroke: midnightblue;
    }

    to {
        stroke: #4b4b4b;
    }
}
</style>

<div id="error408">
    <h1><span>4</span><svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 100 100" preserveAspectRatio="xMidYMid">
            <circle cx="50" cy="50" fill="none" stroke-linecap="round" r="40" stroke-width="8" stroke="#1B1B1B"
                stroke-dasharray="60 60">
                <animateTransform attributeName="transform" type="rotate" calcMode="linear" values="0 50 50;360 50 50"
                    keyTimes="0;1" dur="1.5s" begin="0s" repeatCount="indefinite"></animateTransform>
            </circle>
            <circle cx="50" cy="50" fill="none" stroke-linecap="round" r="30" stroke-width="8" stroke="#222222"
                stroke-dasharray="50 50" stroke-dashoffset="50">
                <animateTransform attributeName="transform" type="rotate" calcMode="linear" values="0 50 50;-360 50 50"
                    keyTimes="0;1" dur="1.5s" begin="0s" repeatCount="indefinite"></animateTransform>
            </circle>
        </svg><span>8</span>
    </h1>
    <p class="subtitle">Request Timeout</p>
</div>
<?php
include("shared/footer.php");

?>