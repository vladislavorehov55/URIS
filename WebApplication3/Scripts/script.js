var login = document.querySelector(".js-login");
var password = document.querySelector(".js-password");
var auto_button = document.querySelector(".authorization__button");
var auto_error = document.querySelector(".authorization__error");

auto_button.addEventListener("click", function (evt) {
    auto_error.classList.remove("error-show");
    if ((login.value != "ivnek") || (password.value != "111")) {
        evt.preventDefault();
        auto_error.classList.add("error-show");
    }
});