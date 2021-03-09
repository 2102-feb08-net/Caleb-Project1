
const profileBody = document.getElementById("profileBody");
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
            for (const order of orders) {
                const row = profileBody.insertRow();
                row.innerHTML = `<td class="oItemName">${order.itemName}</td>
                    <td class="oItemAmount">${order.itemAmount}</td>
                    <td class="oStoreId">${order.storeId}</td>
                    <td class="oPurchaseDate">${order.purchaseDate}</td>`;
            }
        });
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