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

var cursor = document.querySelector('.cursor');
var cursorinner = document.querySelector('.cursor2');
var a = document.querySelectorAll('a');

document.addEventListener('mousemove', function (e) {
    var x = e.clientX;
    var y = e.clientY;
    cursor.style.transform = `translate3d(calc(${e.clientX}px - 50%), calc(${e.clientY}px - 50%), 0)`
});

document.addEventListener('mousemove', function (e) {
    var x = e.clientX;
    var y = e.clientY;
    cursorinner.style.left = x + 'px';
    cursorinner.style.top = y + 'px';
});

document.addEventListener('mousedown', function () {
    cursor.classList.add('click');
    cursorinner.classList.add('cursorinnerhover')
});

document.addEventListener('mouseup', function () {
    cursor.classList.remove('click')
    cursorinner.classList.remove('cursorinnerhover')
});

a.forEach(item => {
    item.addEventListener('mouseover', () => {
        cursor.classList.add('hover');
    });
    item.addEventListener('mouseleave', () => {
        cursor.classList.remove('hover');
    });
})



