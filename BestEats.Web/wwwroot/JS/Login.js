


function loginSubmit(event) {

    event.preventDefault();

    const customer = {
        fullName: document.getElementById('usernameLogin').value,
        custPassword: document.getElementById('passwordLogin').value,
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


    fetch(`/api/login/${customer.fullName}/${customer.custPassword}`)
        .then(response => {
            if (!response.ok) {
                throw new error(`Error on Network response with Login (${response.status})`);
            }

            else {
                return response.json();
            }
        }
    ).then(response => {
        if (response) {
            alert(`Successfully logged in ${customer.fullName}`);
            sessionStorage.setItem("fullName", customer.fullName);
            window.location.assign("./Profile.html");
        }
        else {
            alert(`failed to login`);
        }
    });
}
let registerForm = document.getElementById('loginCustomer');
registerForm.onsubmit = loginSubmit;

