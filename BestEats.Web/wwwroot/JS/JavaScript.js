'use strict';







registerForm = document.getElementById('registerCustomer');

// register submit event
registerForm.addEventListener('submit', event => {





});

// register a customer name and password
function registerSubmit(event) {
    try {

        event.preventDefault();

        let customer = {
            fullName: registerForm.getElementById('usernameRegister').value,
            password: registerForm.getElementById('passwordRegister').value,
        };

        if (fullName.validity.typeMismatch) {
            throw new error("invalid username.");
        }
        if (password.validity.typeMismatch) {
            throw new error("invalid password");
        }
        sendRegister(customer);
        registerForm.getElementById('usernameRegister').value = '';
        registerForm.getElementById('passwordRegister').value = '';


    }
    catch (error) {
        alert("invalid username or password");
    }
}

function sendRegister(customer) {

    return fetch('/api/register'), {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },

    }
        

}

function sendMessage(message) {
    return fetch('/api/send-message', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(message)
    }).then(response => {
        if (!response.ok) {
            throw new Error(`Network response was not ok (${response.status})`);
        }
    });
}