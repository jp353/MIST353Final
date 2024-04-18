// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

async function getClimateEvents(RNum) {

    const response = await fetch(`https://localhost:7006/api/Region/${RNum}`);
    const data = await response.json();
    var innerHtml = '<table class="table"><tr><th>ceType</th><th>ceDate</th></tr>';
    for (let i = 0; i < data.length; i++) {
        innerHtml += `<tr><td>${data[i].ceType}</td><td>${data[i].ceDate}</td></tr>`
    }
    innerHtml += "</table>";
    document.getElementById('weatherStuff').innerHTML = innerHtml;
    document.getElementById('weatherStuff').style.visibility = "visible";

}



// Function to update UI with climate event details
function displayClimateEvents(climateEvents) {
    // You can customize this function to update your webpage's UI with the retrieved climate events
    // For example, you can populate a table or list with the climate event data
    if (climateEvents && climateEvents.length > 0) {
        const eventList = document.getElementById('climateEventList');
        eventList.innerHTML = ''; // Clear previous entries
        climateEvents.forEach(event => {
            const listItem = document.createElement('li');
            listItem.textContent = `Event ID: ${event.eventNum}, Type: ${event.cEType}, Date: ${event.cEDate}, Severity: ${event.cESeverity}`;
            eventList.appendChild(listItem);
        });
    } else {
        console.error('No climate events found');
    }
}

// Fetch climate events when the page loads
document.addEventListener('DOMContentLoaded', async function () {
    try {
        const RNum = 1; // Replace with the actual region number
        const climateEvents = await getClimateEvents(RNum);
        displayClimateEvents(climateEvents);
    } catch (error) {
        console.error('Error:', error);
    }
});
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