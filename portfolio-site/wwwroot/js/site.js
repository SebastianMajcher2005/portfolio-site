window.onscroll = function () { scrollFunction() };
let mybutton = document.getElementById("mouse-btn");
let navbar = document.getElementById("navbar");
let myname = document.getElementById("my-name");

function scrollFunction() {
    if (document.body.scrollTop > 20 || document.documentElement.scrollTop > 20) {
        navbar.style.background = "#101010";
        myname.style = "margin-top: 25px; margin-bottom: 25px; transition: all 0.5s ease-out;";
        mybutton.style = "visibility: hidden;";
    } else {
        navbar.style.background = "none";
        myname.style = "margin-top: 50px; margin-bottom: 50px; transition: all 0.5s ease-out;";
        mybutton.style = "visibility: visible;";
    }
}

const btn = document.getElementById('navbar-toggler');

btn.addEventListener('click', function onClick() {
        navbar.style = "background: #101010;";
});
