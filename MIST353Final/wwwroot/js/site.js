// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

async function goToCartPage(subid, price) {
    var cartid = 2;
    var cdate = new Date();
    const response = await fetch(`https://localhost:7238/api/Cart/api/CartAddSubscription/cart=${cartid}&cdate=${price}&cartid=${cdate}&price=${subid}`);
    const data = await response.json();
    window.location.href("https://localhost:7228/Cart");
}

async function displayUserData(UID) {
    const response = await fetch(`https://localhost:7228/api/Users/${UID}`);
    const data await response.json();
    document.getElementById('userFirstName').innerHTML = data[0].userFirstName; 
    document.getElementById('userFirstName').style.visibility = "visible";
}