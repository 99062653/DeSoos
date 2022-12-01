function OpenDropdownResponsive() {
  var x = document.getElementById("NavRight");
  if (x.className === "nav_right") {
    x.className += " responsive";
  } else {
    x.className = "nav_right";
  }
}