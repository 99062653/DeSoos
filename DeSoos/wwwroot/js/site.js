function OpenDropdownResponsive() {
    var x = document.getElementById("NavRightButtons");
  if (x.className === "nav_right_buttons") {
      x.className += " responsive";
  } else {
    x.className = "nav_right_buttons";
  }
}