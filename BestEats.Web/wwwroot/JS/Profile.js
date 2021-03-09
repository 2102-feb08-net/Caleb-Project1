
let profileForm = document.getElementById('profileForm');
let fullName = sessionStorage.getItem("fullName");
let customerId;
getCustomerIDFromName(fullName);
profileForm.onsubmit = ProfileTable;


function ProfileTable(event) {
    
    event.preventDefault();



    fetch(`/api/profile/new/${customerId}`)
        .then(response => {
        if (!response.ok) {
            alert('Something went wrong, please try again.');
        }
        return response.json();
    })
        .then(orders => {
            for (const order in orders) {
                const row = profileOrdersTable.insertRow();
                row.innerHTML = `<td class="oTableName">${orders[order].oTableName}</td>
                    <td class="oTableAmount">${orders[order].oTableAmount}</td>
                    <td class="oStoreLocation">${orders[order].oStoreLocation}</td>
                    <td class="oPurchaseDate">${orders[order].oPurchaseDate}</td>`;
            }
        });
    window.location.replace("./Profile.html");
}


function getCustomerIDFromName(fullName) {



    fetch(`/api/customer/${fullName}`)
        .then(response => {
            if (!response.ok) {
                throw new Error(`Network response not ok at order customer (${response.status})`);
            }
            else {
                return response.json();
            }
        })
        .then(response => {
            console.log(response);
            customerId = (response);
        });
}