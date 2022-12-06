window.onscroll = function () { scrollFunction() };

function scrollFunction() {
    if (document.body.scrollTop > 20 || document.documentElement.scrollTop > 20) {

        document.getElementById("navbar").style.background = "#101010";
        document.getElementById("my-name").style = "margin-top: 25px; margin-bottom: 25px; transition: all 0.5s ease-out;";
    } else {

        document.getElementById("navbar").style = "none";
        document.getElementById("my-name").style = "margin-top: 50px; margin-bottom: 50px; transition: all 0.5s ease-out;";
    }
}

const btn = document.getElementById('navbar-toggler');

btn.addEventListener('click', function onClick() {
        document.getElementById("navbar").style = "background: #101010;";
});

