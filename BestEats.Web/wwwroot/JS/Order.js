
let storeSelectId;
let productSelectId;
let productName;
let customerID;

let fullCustName = sessionStorage.getItem("fullName");




jQuery("#Northerville").click(function (e) {
    
    storeSelectId = 1;
    e.preventDefault();
});

jQuery("#Westerville").click(function (e) {

    storeSelectId = 2;
    e.preventDefault();
});

jQuery("#Southerville").click(function (e) {

    storeSelectId = 3;
    e.preventDefault();
});
jQuery("#Easterville").click(function (e) {

    storeSelectId = 4;
    e.preventDefault();
});



// item selection

jQuery("#Apple").click(function (e) {

    productSelectId = 1;
    productName = "Apple";
    e.preventDefault();
});

jQuery("#Orange").click(function (e) {

    productSelectId = 2;
    productName = "Orange";
    e.preventDefault();
});

jQuery("#Banana").click(function (e) {

    productSelectId = 3;
    productName = "Banana";
    e.preventDefault();
});


getCustomerIDFromName(fullCustName)
let orderForm = document.getElementById('itemQuantity');
orderForm.onsubmit = orderSubmit;


function getCustomerIDFromName(fullCustName) {

    fetch(`/api/customer/${fullCustName}`)
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
            customerID = (response);
        });
}



function orderSubmit(event) {

    event.preventDefault();

    ;



    let productAmount = parseInt(document.getElementById('itemAmount').value);

    let order = {
        customerId: customerID,
        StoreId: storeSelectId,
        ProductId: productSelectId,
        ItemName: productName,
        ProductQuantity: productAmount,
    };

    fetch("/api/order/new", {
        method: `POST`,
        body: JSON.stringify(order),
        headers: {
            'Content-Type': 'application/json'
        },
    }).then(response => {
        if (!response.ok) {
            throw new Error(`Network response not ok (${response.status})`);
        }
        else {
            alert("Successful order added");
        }
    });
}



/*
function getProductName(productId) {
    fetch(`/api/order/${productId}`)
        .then(response => {
            if (!response.ok) {
                throw new error(`Error on Network response with order (${response.status})`);
            }
        }).then(response => response.json())
         .then(data => productName = data)
        .then(() => alert(`${productName}`))      
}
*/



/*
$("#storeDrop").find('li').click(function (e) {

    storeSelectedID = $(this).id();
    alert(`${storeSelectedID}`);
    e.preventDefault();

});
*/
/*
 public void AddOrder(BestEats.Logic.Order DBorder)
{
    Order order = new Order
    {
        OrderId = DBorder.OrderId,
            CustomerId = DBorder.CustomerId,
            StoreId = DBorder.StoreId,
            ProductId = DBorder.ProductId,
            ItemName = DBorder.ItemName,
            ProductQuantity = DBorder.ProductQuantity,
            OrderPurchaseDate = DBorder.OrderPurchaseDate

    };
    _context.Add(order);
}

public string GetItemNameByProductID(int productID)
        {

            var itemName = _context.Products
                .Where(n => n.ProductId == productID)
                .AsEnumerable()
                .First().ProductName;


            return itemName;
        }





//testing pipeline

let storeSelect = document.getElementById('storeDropDownSelection');
storeSelect.onclick = alert(`Showing ${storeSelect}`);
*/