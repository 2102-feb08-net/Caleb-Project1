jQuery("#Northerville").click(function (e) {
    
    alert(`Showing Northerville`);
    e.preventDefault();
});

jQuery("#Westerville").click(function (e) {

    alert("Showing Westerville");
    e.preventDefault();
});

jQuery("#Southerville").click(function (e) {

    alert(`Showing Southerville`);
    e.preventDefault();
});
jQuery("#Easterville").click(function (e) {

    alert(`Showing Easterville`);
    e.preventDefault();
});

/*
let storeSelect = document.getElementById('storeDropDownSelection');
storeSelect.onclick = alert(`Showing ${storeSelect}`);
*/