'use strict';



// register a customer name and password
async function registerSubmit(event) {


        event.preventDefault();

        const customer = {
            fullName: document.getElementById('usernameRegister').value,
            custPassword: document.getElementById('passwordRegister').value,
    };

    let wordTest = /^[A-Za-z]+$/;
    
        if (!customer.fullName.match(wordTest)) {
            alert(`Invalid username. Please retry`);
            throw TypeError("invalid username.");
        }
        
        if (customer.custPassword.length < 8) {
            alert(`Invalid password. Please retry`);
            throw RangeError("invalid password");
        }
    

    await fetch("/api/customers/new", {
        method: "POST",
        body: JSON.stringify(customer),
        headers: {
            'Content-Type': 'application/json'
        },
    }).then(response => {
        if (!response.ok) {
            throw new error(`Error on Network response with Customer (${response.status})`);
        }
        else {
            alert(`Successfully added ${customer.fullName}`);
            location.reload();
        }
    });

    
}

let registerForm = document.getElementById('registerCustomer');
registerForm.onsubmit = registerSubmit;

