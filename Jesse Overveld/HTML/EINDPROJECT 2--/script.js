function pageLoaded() {
    document.querySelector("body").style.opacity = 1;
    document.getElementById("book").style.display = "none";
}
window.onload = pageLoaded;

function meter() {
  var x = document.createElement("METER");
  x.setAttribute("min", "0");
  x.setAttribute("max", "100");
  x.setAttribute("value", "65");
  document.body.appendChild(x);
}

function book() {
    document.getElementById("book").style.display = "block";
        }