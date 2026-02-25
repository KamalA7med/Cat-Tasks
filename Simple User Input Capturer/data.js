let email = document.querySelector(".Email");
let name = document.querySelector(".Name");
let form = document.querySelector("form");

form.addEventListener("submit", e=> {
    e.preventDefault();
    console.log("Email: " + email.value);
    console.log("Name: " + name.value);
});