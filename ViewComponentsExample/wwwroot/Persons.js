document.querySelector("#load-persons-button").addEventListener("click", async function () {
    var response = await fetch("persons-list");
    var responseBody = await response.text();
    document.querySelector("#list").innerHTML = responseBody;
});