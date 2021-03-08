
let storeSelectedID;
let productSelectedID;

let currentCustomer = sessionStorage.getItem("fullName");




jQuery("#Northerville").click(function (e) {
    
    storeSelectedID = 1;
    e.preventDefault();
});

jQuery("#Westerville").click(function (e) {

    storeSelectedID = 2;
    e.preventDefault();
});

jQuery("#Southerville").click(function (e) {

    storeSelectedID = 3;
    e.preventDefault();
});
jQuery("#Easterville").click(function (e) {

    storeSelectedID = 4;
    e.preventDefault();
});



// item selection

jQuery("#Apple").click(function (e) {

    productSelectedID = 1;
    e.preventDefault();
});

jQuery("#Orange").click(function (e) {

    productSelectedID = 2;
    e.preventDefault();
});

jQuery("#Banana").click(function (e) {

    productSelectedID = 3;
    e.preventDefault();
});


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


//testing pipeline

let storeSelect = document.getElementById('storeDropDownSelection');
storeSelect.onclick = alert(`Showing ${storeSelect}`);
*/